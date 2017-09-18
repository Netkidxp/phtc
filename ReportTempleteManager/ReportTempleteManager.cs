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
using System.IO;
namespace ReportTempleteManager
{
    public partial class ReportTempleteManager : Form
    {
        public ReportTempleteManager()
        {
            InitializeComponent();
            cb_type.SelectedIndex = 0;
            RefreshList();
        }

        private void bu_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (cb_type.SelectedIndex == 0)
                ofd.Filter = "word模板(*.dot)|*.dot";
            else
                ofd.Filter = "html模板(*.htt)|*.htt";
            ofd.Title = "请选择一个模板文件";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                tb_path.Text = ofd.FileName;
            }

        }

        private void bu_add_Click(object sender, EventArgs e)
        {
            if(tb_name.Text.Length!=0&&tb_path.Text.Length!=0)
            {
                byte[] buffer = FileToByte(tb_path.Text);
                if (buffer != null)
                {
                    ReportTemplete rt = new ReportTemplete();
                    rt.Type = cb_type.SelectedIndex;
                    rt.Name = tb_name.Text;
                    rt.Induction = tb_induction.Text;
                    rt.OwnerId = 0;
                    rt.Raw = buffer;
                    bool res=DBReportTempleteAdapter.Insert(rt);
                    if(res)
                    {
                        RefreshList();
                        MessageBox.Show("添加成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("无法读取" + tb_path.Text, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    
            }
            else
            {
                MessageBox.Show("请您填写名称和文件路径", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }
        private byte[] FileToByte(string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                byte[] buffer = new byte[fs.Length];
                fs.Seek(0, SeekOrigin.Begin);
                fs.Read(buffer, 0, (int)fs.Length);
                fs.Close();
                return buffer;
            }
            catch(Exception)
            {
                return null;
            }
            
        }
        private void RefreshList()
        {
            DataTable dt = DBReportTempleteAdapter.ListAllTemplete();
            if(dt==null)
            {
                MessageBox.Show("无法检索模板文件,请检查网络连接或者联系管理员", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgv_list.DataSource = dt.DefaultView;
        }

        private void mi_refresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void mi_delete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dgvr in dgv_list.SelectedRows)
            {
                int id = (int)dgvr.Cells["id"].Value;
                DBReportTempleteAdapter.Delete(id);
            }
            RefreshList();
        }
    }
}
