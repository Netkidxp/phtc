using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHTC.Model;
using PHTC.DB;
using System.Windows.Forms;
namespace PHTC
{
    public class MaterialManager
    {
        public static Material LoadMaterial(int id)
        {
            return DbMaterialAdapter.LoadWithId(id);
        }
        public static int NewMaterial()
        {
            List<RefValue> hcs = new List<RefValue> { new RefValue(298.15, 2.5) };
            List<RefValue> shs = new List<RefValue> { new RefValue(298.15, 20) };
            Material mat = new Material(0, "new material", User.CurrentUser, User.CurrentUser.Id, "code", "use for", DateTime.Now, DateTime.Now, 2000, "remark", hcs, shs, false, false, true);
            MaterialDetailsForm mdf = new MaterialDetailsForm(mat, MaterialDetailsForm.ButtonType.Save);
            mdf.ShowDialog();
            if (mdf.ExitResult == MaterialDetailsForm.ExitResultType.Save)
            {
                Material newmat = mdf.MaterialResult;
                newmat.Create_time = DateTime.Now;
                newmat.Modify_time = DateTime.Now;
                newmat.OwnerId = User.CurrentUser.Id;
                newmat.Owner = User.CurrentUser;
                bool res = DbMaterialAdapter.Insert(newmat);
                if (!res)
                {
                    GlobalTool.LogError("MaterialManageForm.NewMaterial", "保存材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                    return 0;
                }
                else
                {
                    return newmat.Index;
                }
            }
            return 0;
        }
        public static bool DeleteMaterial(int id)
        {
            Material mat = DbMaterialAdapter.LoadWithId(id);
            if (mat == null)
            {
                GlobalTool.LogError("MaterialManageForm.DeleteMaterial", "读取材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                return false;
            }
            if (mat.OwnerId == User.CurrentUser.Id)
            {
                bool res = DbMaterialAdapter.Delete(id);
                if (!res)
                {
                    GlobalTool.LogError("MaterialManageForm.DeleteMaterial", "删除材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                    return false;
                }
                return true;

            }
            else
            {
                MessageBox.Show("该材料不为您所有，您无法删除！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        public static int ShowMaterial(int id)
        {
            Material mat = DbMaterialAdapter.LoadWithId(id);
            if (mat == null)
            {
                GlobalTool.LogError("MaterialManageForm.ShowMaterial", "读取材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                return 0;
            }
            if (mat.OwnerId == User.CurrentUser.Id || mat.Share)
            {
                MaterialDetailsForm mdf = new MaterialDetailsForm(mat, MaterialDetailsForm.ButtonType.Save);
                mdf.ShowDialog();
                if (mdf.ExitResult == MaterialDetailsForm.ExitResultType.Save)
                {
                    Material newmat = mdf.MaterialResult;

                    if (mat.OwnerId == User.CurrentUser.Id)
                    {
                        newmat.Modify_time = DateTime.Now;
                        bool res = DbMaterialAdapter.Update(newmat);
                        if (!res)
                        {
                            GlobalTool.LogError("MaterialManageForm.ShowMaterial", "保存材料出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                            return 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("该材料不为您所有，您将保存为所有者为自己的副本!", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        newmat.OwnerId = User.CurrentUser.Id;
                        newmat.Owner = User.CurrentUser;
                        newmat.Create_time = DateTime.Now;
                        newmat.Modify_time = DateTime.Now;
                        bool res = DbMaterialAdapter.Insert(newmat);
                        if (!res)
                        {
                            GlobalTool.LogError("MaterialManageForm.ShowMaterial", "保存材料副本出现错误，请检查您的网络连接，或者向管理员寻求帮助！", true);
                            return 0;
                        }
                        else
                        {
                            return newmat.Index;
                        }
                    }
                }
                return id;
            }
            else
            {
                MessageBox.Show("该材料所有者不共享材料信息，请您联系材料所有者！", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
        }
    }
}
