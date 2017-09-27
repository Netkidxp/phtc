﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHTC.Model;
using PHTC.DB;
using System.Security.Cryptography;//MD5加密需引入的命名空间

namespace PHTC
{
    public class UserManager
    {
        private static string GetMD5(string strPwd)
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
        public static bool ValidateUser(string name,string password)
        {
            string md5pass = GetMD5(password);
            int res = DBUserAdapter.Exist(name);
            if (res != 1)
                return false;
            User u = DBUserAdapter.LoadWithName(name);
            if (u == null)
                return false;
            if (u.Login_password == md5pass)
                return true;
            else
                return false;
        }
        public static User LoginOn(string name,string password)
        {
            if (ValidateUser(name, password))
            {
                return DBUserAdapter.LoadWithName(name);
            }
            else
                return null;
        }
        public static bool ChangePassword(string name,string oldpassword,string newpassword)
        {
            if (ValidateUser(name, oldpassword))
            {
                User u = DBUserAdapter.LoadWithName(name);
                u.Login_password = GetMD5(newpassword);
                return DBUserAdapter.Update(u);
            }
            else
                return false;
        }
        public static void WriteRememberName(string name)
        {
            GlobalTool.WriteRegKeyValue("lastuser", "name", name);
        }
        public static void WriteRememberPassword(string password)
        {
            string encPassword = NetCryptoHelper.EncryptDes(password, NetCryptoHelper.DesKey, NetCryptoHelper.DesIv);
            GlobalTool.WriteRegKeyValue("lastuser", "password", encPassword);
        }
        public static string ReadRememberName()
        {
            return GlobalTool.ReadRegKeyValue("lastuser", "name");
        }
        public static string ReadRememberPassword()
        {
            string encPassword = GlobalTool.ReadRegKeyValue("lastuser", "password");
            if (encPassword == null)
                return null;
            else
                return NetCryptoHelper.DecryptDes(encPassword, NetCryptoHelper.DesKey, NetCryptoHelper.DesIv);
        }
        public static void DeleteRememberPassword()
        {
            GlobalTool.DeleteRegKeyValue("lastuser", "password");
        }
        public static void DeleteRememberName()
        {
            GlobalTool.DeleteRegKeyValue("lastuser", "name");
        }
    }
}