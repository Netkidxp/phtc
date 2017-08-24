using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Security.Cryptography;//MD5加密需引入的命名空间
using PHTC.Model;

namespace PHTC.DB
{
    public class DbMaterialAdapter
    {
        static char[] SEP1 = { ','};
        static char[] SEP2 = { '|'};
        private static MySqlParameter[] MakeInsertParameter(Material mat)
        {
            MySqlParameter p_name = new MySqlParameter("_name", MySqlDbType.String);
            p_name.Value = mat.Name;
            MySqlParameter p_owner = new MySqlParameter("_owner", MySqlDbType.Int32);
            p_owner.Value = mat.OwnerId;
            MySqlParameter p_code = new MySqlParameter("_code", MySqlDbType.String);
            p_code.Value = mat.Code;
            MySqlParameter p_use_for = new MySqlParameter("_use_for", MySqlDbType.String);
            p_use_for.Value = mat.Use_for;
            MySqlParameter p_create_time = new MySqlParameter("_create_time", MySqlDbType.Double);
            p_create_time.Value = GlobalTool.ConvertDateTimeInt(mat.Create_time);
            MySqlParameter p_modify_time = new MySqlParameter("_modify_time", MySqlDbType.Double);
            p_modify_time.Value = GlobalTool.ConvertDateTimeInt(mat.Modify_time);
            MySqlParameter p_density = new MySqlParameter("_density", MySqlDbType.Double);
            p_density.Value = mat.Density;
            MySqlParameter p_remark = new MySqlParameter("_remark", MySqlDbType.String);
            p_remark.Value = mat.Remark;
            MySqlParameter p_tc_is_fun = new MySqlParameter("_tc_is_fun", MySqlDbType.Byte);
            p_tc_is_fun.Value = mat.TcIsFun;
            MySqlParameter p_sh_is_fun = new MySqlParameter("_sh_is_fun", MySqlDbType.Byte);
            p_sh_is_fun.Value = mat.ShIsFun;
            MySqlParameter p_tc_list = new MySqlParameter("_tc_list", MySqlDbType.String);
            p_tc_list.Value = RefvalListToStr(mat.TCs);
            MySqlParameter p_sh_list = new MySqlParameter("_sh_list", MySqlDbType.String);
            p_sh_list.Value = RefvalListToStr(mat.SHs);
            MySqlParameter p_share = new MySqlParameter("_share", MySqlDbType.Byte);
            p_share.Value = mat.Share;
            MySqlParameter[] pars = new MySqlParameter[] { p_name, p_owner, p_code, p_use_for, p_create_time, p_modify_time, p_density, p_remark, p_tc_is_fun, p_sh_is_fun, p_tc_list, p_sh_list,p_share };
            return pars;
        }
        private static MySqlParameter[] MakeUpdateParameter(Material mat)
        {

            MySqlParameter p_id = new MySqlParameter("_id", MySqlDbType.Int32);
            p_id.Value = mat.Index;
            MySqlParameter p_name = new MySqlParameter("_name", MySqlDbType.String);
            p_name.Value = mat.Name;
            MySqlParameter p_code = new MySqlParameter("_code", MySqlDbType.String);
            p_code.Value = mat.Code;
            MySqlParameter p_use_for = new MySqlParameter("_use_for", MySqlDbType.String);
            p_use_for.Value = mat.Use_for;
            MySqlParameter p_modify_time = new MySqlParameter("_modify_time", MySqlDbType.Double);
            p_modify_time.Value = GlobalTool.ConvertDateTimeInt(mat.Modify_time);
            MySqlParameter p_density = new MySqlParameter("_density", MySqlDbType.Double);
            p_density.Value = mat.Density;
            MySqlParameter p_remark = new MySqlParameter("_remark", MySqlDbType.String);
            p_remark.Value = mat.Remark;
            MySqlParameter p_tc_is_fun = new MySqlParameter("_tc_is_fun", MySqlDbType.Byte);
            p_tc_is_fun.Value = mat.TcIsFun;
            MySqlParameter p_sh_is_fun = new MySqlParameter("_sh_is_fun", MySqlDbType.Byte);
            p_sh_is_fun.Value = mat.ShIsFun;
            MySqlParameter p_tc_list = new MySqlParameter("_tc_list", MySqlDbType.String);
            p_tc_list.Value = RefvalListToStr(mat.TCs);
            MySqlParameter p_sh_list = new MySqlParameter("_sh_list", MySqlDbType.String);
            p_sh_list.Value = RefvalListToStr(mat.SHs);
            MySqlParameter p_share = new MySqlParameter("_share", MySqlDbType.Byte);
            p_share.Value = mat.Share;
            MySqlParameter[] pars = new MySqlParameter[] { p_id,p_name,  p_code, p_use_for,  p_modify_time, p_density, p_remark, p_tc_is_fun, p_sh_is_fun, p_tc_list, p_sh_list,p_share};
            return pars;
        }
        public static Material LoadWithId(int index)
        {

            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter p_index = new MySqlParameter("_id", MySqlDbType.Int32);
                p_index.Value = index;
                MySqlParameter[] pars = new MySqlParameter[] { p_index };
                DataTable dt = dm.ExecuteProcQuery("Material_LoadWithId", pars);
                DataRow dr = dt.Rows[0];
                string name = (string)dr["name"];
                int ownerid = (int)dr["owner"];
                string code = (string)dr["code"];
                string use_for = (string)dr["use_for"];
                DateTime create_time = GlobalTool.ConvertIntDateTime((double)dr["create_time"]);
                DateTime modify_time = GlobalTool.ConvertIntDateTime((double)dr["modify_time"]);
                double density = (double)dr["density"];
                Boolean tc_is_fun = Boolean.Parse(dr["tc_is_fun"].ToString());
                Boolean sh_is_fun = Boolean.Parse(dr["sh_is_fun"].ToString());
                string s_tc_list = (string)dr["tc_list"];
                string s_sh_list = (string)dr["sh_list"];
                List<RefValue> tc_list = StrToRefvalList(s_tc_list);
                List<RefValue> sh_list = StrToRefvalList(s_sh_list);
                string remark = (string)dr["remark"];
                bool share = bool.Parse(dr["share"].ToString());
                User owner = DBUserAdapter.LoadWithId(ownerid);
                Material mat = new Material(index, name, owner,ownerid, code, use_for, create_time, modify_time, density, remark, tc_list, sh_list, tc_is_fun, sh_is_fun,share);
                
                return mat;
            }
            catch(Exception)
            {
                return null;
            }
            
        }
        public static bool Insert(Material mat)
        {
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter[] pars = MakeInsertParameter(mat);
                DataTable dt=dm.ExecuteProcQuery("Material_Insert", pars);
                mat.Index = (int)dt.Rows[0][0];
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public static bool Update(Material mat)
        {
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter[] pars = MakeUpdateParameter(mat);
                dm.ExecuteProcNonQuery("Material_Update", pars);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }
        public static bool Delete(int index)
        {
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter p_index = new MySqlParameter("_id", MySqlDbType.Int32);
                p_index.Value = index;
                MySqlParameter[] pars = new MySqlParameter[] { p_index };
                dm.ExecuteProcNonQuery("Material_Delete", pars);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        
        public static DataTable Search(string name,string code,string usefor,bool shared)
        {

            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter p_name = new MySqlParameter("_name", MySqlDbType.String);
                p_name.Value = ConvertSqlParameter(name);
                MySqlParameter p_code = new MySqlParameter("_code", MySqlDbType.String);
                p_code.Value = ConvertSqlParameter(code);
                MySqlParameter p_usefor = new MySqlParameter("_usefor", MySqlDbType.String);
                p_usefor.Value = ConvertSqlParameter(usefor);
                MySqlParameter p_shared = new MySqlParameter("_shared", MySqlDbType.Byte);
                p_shared.Value = shared;
                MySqlParameter[] pars = new MySqlParameter[] { p_name,p_code,p_usefor,p_shared };
                return dm.ExecuteProcQuery("Material_Search", pars);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static DataTable Search(int userId,string name, string code, string usefor, bool shared)
        {
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter p_userid = new MySqlParameter("_userid", MySqlDbType.Int32);
                p_userid.Value = userId;
                MySqlParameter p_name = new MySqlParameter("_name", MySqlDbType.String);
                p_name.Value = ConvertSqlParameter(name);
                MySqlParameter p_code = new MySqlParameter("_code", MySqlDbType.String);
                p_code.Value = ConvertSqlParameter(code);
                MySqlParameter p_usefor = new MySqlParameter("_usefor", MySqlDbType.String);
                p_usefor.Value = ConvertSqlParameter(usefor);
                MySqlParameter p_shared = new MySqlParameter("_shared", MySqlDbType.Byte);
                p_shared.Value = shared;
                MySqlParameter[] pars = new MySqlParameter[] { p_userid,p_name, p_code, p_usefor, p_shared };
                return dm.ExecuteProcQuery("Material_SearchWithUserId", pars);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static DataTable Search(string input)
        {
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter p_input = new MySqlParameter("_input", MySqlDbType.String);
                p_input.Value = input;
                MySqlParameter[] pars = new MySqlParameter[] { p_input };
                DataTable dt= dm.ExecuteProcQuery("Material_SearchWithKeyword", pars);
                if (dt == null)
                    return null;
                dt.Columns.Add("modify_time_");
                foreach(DataRow dr in dt.Rows)
                {
                    dr["modify_time_"] = GlobalTool.ConvertIntDateTime((double)dr["modify_time"]);
                }
                dt.Columns.Remove("modify_time");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<RefValue> StrToRefvalList(String in_str)
        {
            List<RefValue> values = new List<RefValue>();
            string[] strs = in_str.Split(SEP1);
            foreach(string str in strs)
            {
                if (str == "")
                    continue;
                string[] rvs = str.Split(SEP2);
                RefValue rv = new RefValue(double.Parse(rvs[0]), double.Parse(rvs[1]));
                values.Add(rv);
            }
            return values;
        }
        public static String RefvalListToStr(List<RefValue> in_list)
        {
            String str = "";
            foreach (RefValue rv in in_list)
            {
                String tempStr = rv.r.ToString() + "|" + rv.v.ToString() + ",";
                str += tempStr;
            }
            return str;
        }
        public static string ConvertSqlParameter(string par)
        {
            if (par == "")
                return "%%";
            else
            {
                string t1 = par.Replace("%", "//%");
                t1 = t1.Replace("_", "//_");
                return t1;
            }
        }
       
    }
    public class DBUserAdapter
    {
        private static MySqlParameter[] MakeInsertParameter(User user)
        {
            MySqlParameter p_login_id = new MySqlParameter("_login_id", MySqlDbType.String);
            p_login_id.Value = user.Login_id;
            MySqlParameter p_login_password = new MySqlParameter("_login_password", MySqlDbType.String);
            p_login_password.Value =user.Login_password;
            MySqlParameter p_name = new MySqlParameter("_name", MySqlDbType.String);
            p_name.Value = user.Name;
            MySqlParameter p_department = new MySqlParameter("_department", MySqlDbType.String);
            p_department.Value = user.Department;
            MySqlParameter[] pars = new MySqlParameter[] { p_login_id, p_login_password, p_name, p_department };
            return pars;
        }
        private static MySqlParameter[] MakeUpdateParameter(User user)
        {
            MySqlParameter p_id = new MySqlParameter("_id", MySqlDbType.Int32);
            p_id.Value = user.Id;
            MySqlParameter p_login_id = new MySqlParameter("_login_id", MySqlDbType.String);
            p_login_id.Value = user.Login_id;
            MySqlParameter p_login_password = new MySqlParameter("_login_password", MySqlDbType.String);
            p_login_password.Value = GetMD5(user.Login_password);
            MySqlParameter p_name = new MySqlParameter("_name", MySqlDbType.String);
            p_name.Value = user.Name;
            MySqlParameter p_department = new MySqlParameter("_department", MySqlDbType.String);
            p_department.Value = user.Department;
            MySqlParameter[] pars = new MySqlParameter[] { p_login_id, p_login_password, p_name, p_department };
            return pars;
        }
        public static User LoadWithId(int _id)
        {
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter p_index = new MySqlParameter("_id", MySqlDbType.Int32);
                p_index.Value = _id;
                MySqlParameter[] pars = new MySqlParameter[] { p_index };
                DataTable dt = dm.ExecuteProcQuery("User_LoadWithId", pars);
                DataRow dr = dt.Rows[0];
                int id = (int)dr["id"];
                string login_id = (string)dr["login_id"];
                string login_password = (string)dr["login_password"];
                string name = (string)dr["name"];
                string department = (string)dr["department"];
                return new User(id, login_id, login_password, name, department);
            }
            catch(Exception)
            {
                return null;
            }
            
        }
        public static bool Insert(User user)
        {
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter[] pars = MakeInsertParameter(user);
                dm.ExecuteProcNonQuery("User_Insert", pars);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public static bool Update(User user)
        {

            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter[] pars = MakeUpdateParameter(user);
                dm.ExecuteProcNonQuery("User_Update", pars);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Delete(int _id)
        {
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter p_id = new MySqlParameter("_id", MySqlDbType.Int32);
                p_id.Value = _id;
                MySqlParameter[] pars = new MySqlParameter[] { p_id };
                dm.ExecuteProcNonQuery("User_Delete", pars);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public static int Exist(string _login_id)
        {
            
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter p_login_id = new MySqlParameter("_login_id", MySqlDbType.Int32);
                p_login_id.Value = _login_id;
                MySqlParameter[] pars = new MySqlParameter[] { p_login_id };
                DataTable dt = dm.ExecuteProcQuery("User_CountUserWithLoginId", pars);
                if (dt.Rows[0][0].ToString() != "0")
                    return -1;
                else
                    return 1;
            }
            catch(Exception)
            {
                return 0;
            }
            

        }
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="strPwd">被加密的字符串</param>
        /// <returns>返回加密后的字符串</returns>
        public static string GetMD5(string strPwd)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(strPwd);
            byte[] md5data = md5.ComputeHash(data);
            md5.Clear();
            string str = "";
            for (int i = 0; i < md5data.Length - 1; i++)
            {
                str += md5data[i].ToString("x").PadLeft(2, '0');
            }
            return str;
        }
    }
    public class DBProjectAdapter
    {
        private static MySqlParameter[] MakeInsertParameter(Project project)
        {
            MySqlParameter p_name = new MySqlParameter("_name", MySqlDbType.String);
            p_name.Value = project.Name;
            MySqlParameter p_ownerid = new MySqlParameter("_owner", MySqlDbType.Int32);
            p_ownerid.Value = project.OwnerId;
            MySqlParameter p_mode = new MySqlParameter("_mode", MySqlDbType.Int32);
            p_mode.Value = project.Mode;
            MySqlParameter p_type = new MySqlParameter("_type", MySqlDbType.Int32);
            p_type.Value = project.Schema;
            MySqlParameter p_time = new MySqlParameter("_time", MySqlDbType.Double);
            p_time.Value = GlobalTool.ConvertDateTimeInt(DateTime.Now);
            MySqlParameter p_data = new MySqlParameter("_data", MySqlDbType.Blob);
            p_data.Value = project.Serialize();
            MySqlParameter p_share = new MySqlParameter("_share", MySqlDbType.Byte);
            p_share.Value = project.Share;
            MySqlParameter p_remark = new MySqlParameter("_remark", MySqlDbType.String);
            p_remark.Value = project.Remark;
            MySqlParameter[] pars = new MySqlParameter[] {p_name,p_ownerid,p_mode,p_type,p_time,p_data,p_share,p_remark };
            return pars;
        }
        private static MySqlParameter[] MakeUpdateParameter(Project project)
        {
            MySqlParameter p_id = new MySqlParameter("_id", MySqlDbType.Int32);
            p_id.Value = project.Id;
            MySqlParameter p_name = new MySqlParameter("_name", MySqlDbType.String);
            p_name.Value = project.Name;
            MySqlParameter p_mode = new MySqlParameter("_mode", MySqlDbType.Int32);
            p_mode.Value = project.Mode;
            MySqlParameter p_type = new MySqlParameter("_type", MySqlDbType.Int32);
            p_type.Value = project.Schema;
            MySqlParameter p_time = new MySqlParameter("_time", MySqlDbType.Double);
            p_time.Value = GlobalTool.ConvertDateTimeInt(DateTime.Now);
            MySqlParameter p_data = new MySqlParameter("_data", MySqlDbType.Blob);
            p_data.Value = project.Serialize();
            MySqlParameter p_share = new MySqlParameter("_share", MySqlDbType.Byte);
            p_share.Value = project.Share;
            MySqlParameter p_remark = new MySqlParameter("_remark", MySqlDbType.String);
            p_remark.Value = project.Remark;
            MySqlParameter[] pars = new MySqlParameter[] { p_id,p_name, p_mode, p_type, p_time, p_data, p_share, p_remark };
            return pars;
        }
        public static bool Insert(Project project)
        {
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter[] pars = MakeInsertParameter(project);
                DataTable dt = dm.ExecuteProcQuery("Project_Insert", pars);
                project.Id = (int)dt.Rows[0][0];
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Delete(int index)
        {
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter p_index = new MySqlParameter("_id", MySqlDbType.Int32);
                p_index.Value = index;
                MySqlParameter[] pars = new MySqlParameter[] { p_index };
                dm.ExecuteProcNonQuery("Project_Delete", pars);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Update(Project project)
        {
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter[] pars = MakeUpdateParameter(project);
                dm.ExecuteProcNonQuery("Project_Update", pars);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static DataTable Search(string keyword)
        {
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter p_input = new MySqlParameter("_keyword", MySqlDbType.String);
                p_input.Value = keyword;
                MySqlParameter[] pars = new MySqlParameter[] { p_input };
                DataTable dt = dm.ExecuteProcQuery("Project_SearchWithKeyword", pars);
                if (dt == null)
                    return null;
                dt.Columns.Add("time_", typeof(DateTime));
                dt.Columns.Add("mode_", typeof(string));
                dt.Columns.Add("type_", typeof(string));
                foreach (DataRow dr in dt.Rows)
                {
                    double t = (double)dr["time"];
                    CalculationMode mode = (CalculationMode)dr["mode"];
                    GeometrySchema type = (GeometrySchema)dr["type"];
                    dr["time_"] = GlobalTool.ConvertIntDateTime(t);
                    dr["mode_"] = (mode== CalculationMode.Temperature?"温度":"厚度");
                    dr["type_"] = (type == GeometrySchema.Plate ? "平板" : "圆筒");
                }
                dt.Columns.Remove("mode");
                dt.Columns.Remove("type");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static DataTable Search(string keyword,int ownerid,bool share)
        {
            try
            {
                DbManager dm = DbManager.Ins;
                MySqlParameter p_input = new MySqlParameter("_keyword", MySqlDbType.String);
                p_input.Value = keyword;
                MySqlParameter p_ownerid = new MySqlParameter("_ownerid", MySqlDbType.Int32);
                p_ownerid.Value = ownerid;
                MySqlParameter p_share = new MySqlParameter("_share", MySqlDbType.Byte);
                p_share.Value = share;
                MySqlParameter[] pars = new MySqlParameter[] { p_input,p_ownerid,p_share };
                DataTable dt= dm.ExecuteProcQuery("Project_SearchWithKeywordOwnerShare", pars);
                if (dt == null)
                    return null;
                dt.Columns.Add("time_", typeof(DateTime));
                foreach(DataRow dr in dt.Rows)
                {
                    double t = (double)dr["time"];
                    dr["time_"] = GlobalTool.ConvertIntDateTime(t);
                }
                dt.Columns.Remove("time");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static Project LoadWithId(int index)
        {
            try
            {
                Project pro = null;
                DbManager dm = DbManager.Ins;
                MySqlParameter p_index = new MySqlParameter("_id", MySqlDbType.Int32);
                p_index.Value = index;
                MySqlParameter[] pars = new MySqlParameter[] { p_index };
                DataTable dt=dm.ExecuteProcQuery("Project_LoadWithId", pars);
                pro = Project.Deserialize((byte[])dt.Rows[0][0]);
                pro.Id = index;
                return pro;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
    
    
}
