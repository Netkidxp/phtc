using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHTC.DB;
using PHTC.Model;
namespace PHTC
{
    public partial class UserManageForm : Form
    {
        DataTable dt;
        public UserManageForm()
        {
            InitializeComponent();
            
        }
        private bool RefreshDate()
        {
            dt = DBUserAdapter.LoadAll();
            if (dt == null)
            {
                MessageBox.Show("查询数据库错误");
               return false;
            }
            dgv.DataSource = dt;
            dgv.Columns[0].ReadOnly = true;
            dgv.Columns[2].ReadOnly = true;
            dgv.Columns.RemoveAt(5);
            dgv.Columns.RemoveAt(5);
            dgv.Columns.RemoveAt(5);
            return true;
        }

        private void mi_refresh_Click(object sender, EventArgs e)
        {
            RefreshDate();
        }
        private string CellString(DataGridViewCell c)
        {
            if (c.Value != null)
                return c.Value.ToString();
            else
                return "";
        }
        private bool RowDataVerificate(DataGridViewRow r)
        {
            if (r.IsNewRow)
                return true;
            return (r.Cells[1].Value!=null&& r.Cells[2].Value!=null && r.Cells[3].Value != null && r.Cells[4].Value != null);
        }
        private void mi_ok_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                if (!RowDataVerificate(r))
                {
                    MessageBox.Show("请您填写完整的信息");
                    r.Selected = true;
                    return;
                }
            }
            foreach (DataGridViewRow r in dgv.Rows)
            {
                if (r.IsNewRow)
                    continue;
                int id = 0;
                if (r.Cells[0].Value is Int32)
                    id = (int)(r.Cells[0].Value);
                string lid = (string)(r.Cells[1].Value);
                string lpass = (string)(r.Cells[2].Value);
                string name = (string)(r.Cells[3].Value);
                string department = (string)(r.Cells[4].Value);
                User u = new User(id, lid, lpass, name, department);
                if (id == 0)
                {
                    if (UserManager.Exist(name))
                    {
                        MessageBox.Show("用户" + "\"" + name + "\"已经存在");
                        continue;
                    }
                    DBUserAdapter.Insert(u);
                }
                else
                {
                    User ou = DBUserAdapter.LoadWithId(id);
                    u.Level = ou.Level;
                    DBUserAdapter.Update(u);
                }
                    
            }
        }

        private void mi_delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows= dgv.SelectedRows;
            foreach(DataGridViewRow r in rows)
            {
                string id = r.Cells[0].Value.ToString();
                if(id!="")
                {
                    int i = int.Parse(id);
                    DBUserAdapter.Delete(i);
                }
            }
            RefreshDate();
        }

        private void OnDbClick(object sender, EventArgs e)
        {
            if(dgv.CurrentCell.ColumnIndex == 2)
            {
                PasswordForm pf = new PasswordForm();
                if (pf.ShowDialog()==DialogResult.OK)
                {
                    dgv.CurrentCell.Value = pf.Pass;
                }
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (!RefreshDate())
                Close();
        }

        private void mi_copy_Click(object sender, EventArgs e)
        {
            if(dgv.CurrentCell.Value is String)
            {
                Clipboard.SetDataObject((String)(dgv.CurrentCell.Value), true);
            }
        }

        private void mi_paste_Click(object sender, EventArgs e)
        {
            IDataObject data = Clipboard.GetDataObject();
            if(data.GetFormats().Length != 0&& data.GetDataPresent(typeof(String)))
            {
                String v = (String)data.GetData(typeof(String));
                foreach (DataGridViewCell c in dgv.SelectedCells)
                {
                    c.Value = v;
                }
            }   
        }
    }
}
