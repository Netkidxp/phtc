using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHTC.Model
{
    [Serializable]
    public class User
    {
        private int id;
        private string login_id;
        private string login_password;
        private string name;
        private string department;

        private volatile static User currentUser=null;

        public int Id { get => id; set => id = value; }
        public string Login_id { get => login_id; set => login_id = value; }
        public string Login_password { get => login_password; set => login_password = value; }
        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public static User CurrentUser { get => currentUser; set => currentUser = value; }
        public int Level { get; set; }
        private User() { }
        public User(int _id,string _login_id,string _login_password,string _name,string _department)
        {
            id = _id;
            login_id = _login_id;
            login_password = _login_password;
            name = _name;
            department = _department;
            Level = 10;
        }

    }
    
}
