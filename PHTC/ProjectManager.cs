using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHTC.Model;
using PHTC.DB;
using System.Data;
namespace PHTC
{
    public class ProjectManager
    {
        public static Project Load(int id)
        {
            return DBProjectAdapter.LoadWithId(id);
        }
        public static bool Delete(int id)
        {
            return DBProjectAdapter.Delete(id);
        }
        public static bool Update(Project pro)
        {
            return DBProjectAdapter.Update(pro);
        }
        public static bool Insert(Project pro)
        {
            return DBProjectAdapter.Insert(pro);
        }
        public static Project New()
        {
            return Project.Default();
        }
        public static DataTable Search(string keyword,int ownerid,bool share)
        {
            return DBProjectAdapter.Search(keyword, ownerid, share);
        }
        public static DataTable Search(string keyword)
        {
            return DBProjectAdapter.Search(keyword);
        }
    }
}
