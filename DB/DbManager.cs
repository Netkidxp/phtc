﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace PHTC.DB
{
    public class DbManager
    {
        //连接用的字符串  
        private string connStr; 
        public string ConnStr
        {
            get { return connStr; }
            //set { this.connStr = value; }
        }
        private DbManager() {
            /*
            string s1 = GlobalTool.GetConnectStringsConfig();
            string s2 = GlobalTool.GetConnectStringsLanConfig();
            MySqlConnection con = new MySqlConnection(s1);
            try
            {
                con.Open();
                connStr = s1;
                con.Close();
            }
            catch(Exception)
            {
                connStr = s2;
            }
            */
            connStr = GlobalTool.GetConnectStringsLanConfig();
        }

        //DbManager单实例  
        private volatile static DbManager _instance = null;
        private static readonly object lockHelper = new object();
        public static DbManager Ins
        {
            get {
                if (_instance == null)
                {
                    lock (lockHelper)
                    {
                        if (_instance == null)
                            _instance = new DbManager();
                    }
                }
                return _instance;
            }
        }

        /// <summary>  
        /// 需要获得多个结果集的时候用该方法，返回DataSet对象。  
        /// </summary>  
        /// <param name="sql语句"></param>  
        /// <returns></returns>  

        public DataSet ExecuteDataSet(string sql, params MySqlParameter[] paras)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnStr))
                {
                    //数据适配器  
                    MySqlDataAdapter sqlda = new MySqlDataAdapter(sql, con);
                    sqlda.SelectCommand.Parameters.AddRange(paras);
                    DataSet ds = new DataSet();
                    sqlda.Fill(ds);
                    return ds;
                    //不需要打开和关闭链接.  
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                GlobalTool.LogError("Datebase Manager", e.Message, true);
                return null;
            }

        }

        /// <summary>  
        /// 获得单个结果集时使用该方法，返回DataTable对象。  
        /// </summary>  
        /// <param name="sql"></param>  
        /// <returns></returns>  

        public DataTable ExcuteDataTable(string sql, params MySqlParameter[] paras)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnStr))
                {
                    MySqlDataAdapter sqlda = new MySqlDataAdapter(sql, con);
                    sqlda.SelectCommand.Parameters.AddRange(paras);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    return dt;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                GlobalTool.LogError("Datebase Manager", e.Message, true);
                return null;
            }
        }


        /// <summary>     
        /// 执行一条计算查询结果语句，返回查询结果（object）。     
        /// </summary>     
        /// <param name="SQLString">计算查询结果语句</param>     
        /// <returns>查询结果（object）</returns>     
        public object ExecuteScalar(string SQLString, params MySqlParameter[] paras)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.Parameters.AddRange(paras);
                        object obj = cmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (MySql.Data.MySqlClient.MySqlException e)
                    {
                        connection.Close();
                        GlobalTool.LogError("Datebase Manager", e.Message, true);
                        return null;
                    }
                }
            }
        }

        /// <summary>  
        /// 执行Update,Delete,Insert操作  
        /// </summary>  
        /// <param name="sql"></param>  
        /// <returns></returns>  
        /// 
        public int ExecuteNonquery(string sql, params MySqlParameter[] paras)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnStr))
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddRange(paras);
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                GlobalTool.LogError("Datebase Manager", e.Message, true);
                return 0;
            }
        }

        /// <summary>  
        /// 调用存储过程 无返回值  
        /// </summary>  
        /// <param name="procname">存储过程名</param>  
        /// <param name="paras">sql语句中的参数数组</param>  
        /// <returns></returns>  
        public int ExecuteProcNonQuery(string procname, params MySqlParameter[] paras)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnStr))
                {
                    MySqlCommand cmd = new MySqlCommand(procname, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(paras);
                    con.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                GlobalTool.LogError("Datebase Manager", e.Message, true);
                return 0;
            }

        }

        /// <summary>  
        /// 存储过程 返回Datatable  
        /// </summary>  
        /// <param name="procname"></param>  
        /// <param name="paras"></param>  
        /// <returns></returns>  
        public DataTable ExecuteProcQuery(string procname, params MySqlParameter[] paras)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnStr))
                {
                    MySqlCommand cmd = new MySqlCommand(procname, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddRange(paras);
                    MySqlDataAdapter sqlda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sqlda.Fill(dt);
                    return dt;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                GlobalTool.LogError("Datebase Manager", e.Message, true);
                return null;
            }
        }

        /// <summary>  
        /// 多语句的事物管理  
        /// </summary>  
        /// <param name="cmds">命令数组</param>  
        /// <returns></returns>  
        public bool ExcuteCommandByTran(params MySqlCommand[] cmds)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnStr))
                {
                    con.Open();
                    MySqlTransaction tran = con.BeginTransaction();
                    foreach (MySqlCommand cmd in cmds)
                    {
                        cmd.Connection = con;
                        cmd.Transaction = tran;
                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    return true;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                GlobalTool.LogError("Datebase Manager", e.Message, true);
                return false;
            }
        }

        ///分页  
        public DataTable ExcuteDataWithPage(string sql, ref int totalCount, params MySqlParameter[] paras)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnStr))
                {
                    MySqlDataAdapter dap = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    dap.SelectCommand.Parameters.AddRange(paras);
                    dap.Fill(dt);
                    MySqlParameter ttc = dap.SelectCommand.Parameters["@totalCount"];
                    if (ttc != null)
                    {
                        totalCount = Convert.ToInt32(ttc.Value);
                    }
                    return dt;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                GlobalTool.LogError("Datebase Manager", e.Message, true);
                return null;
            }
        }

        public bool TestConnection()
        {
            bool connected = false;
            MySqlConnection con = new MySqlConnection(ConnStr);
            try
            {
                con.Open();
                connected= true;
            }
            catch(Exception)
            {
                connected = false;
            }
            finally
            {
                if (connected)
                    con.Close();
            }
            return connected;
        }
    }
}
