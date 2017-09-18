using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHTC.Model;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;

namespace PHTC
{

    public partial class MaterialDetailsForm : Form
    {
        public enum ButtonType
        {
            Update,
            Modify
        }
        private ButtonType type; 
        public static string REGSTR_PositiveRealNumber = @"^[0-9]\d*(\.\d+)?$";
        public static string REGSTR_RealNumber = @"^[+-]?\d+(\.\d+)?$";
        private Material material;
        private DataTable dt_hc_dis;
        private DataTable dt_sh_dis;
        private DataTable dt_hc_fun;
        private DataTable dt_sh_fun;
        private DataSet ds;
        private MaterialDetailsForm() { }   
        private static void SortList(List<RefValue> list)
        {
            List<RefValue> tl = new List<RefValue>();
            foreach(RefValue r in list)
            {
                tl.Add(new RefValue(r.r, r.v));
            }
            list.Clear();
            int i = 0,N=tl.Count;
            for(i=0;i<N;i++)
            {
                int p = 0,minI=0;
                double min =tl[0].r;
                for(p=0;p<tl.Count;p++)
                {
                    if(tl[p].r<min)
                    {
                        minI = p;
                        min = tl[p].r;
                    }
                }
                list.Add(new RefValue(tl[minI].r, tl[minI].v));
                tl.RemoveAt(minI);
            }
        }
        private void InitDataset()
        {
            ds = new DataSet();
            dt_hc_dis = new DataTable("hc_dis");
            dt_sh_dis = new DataTable("sh_dis");
            ds.Tables.Add(dt_hc_dis);
            ds.Tables.Add(dt_sh_dis);
            dt_hc_dis.Columns.Add("温度[℃]", typeof(double));
            dt_hc_dis.Columns.Add("导热系数[W m^-1 ℃^-1]", typeof(double));
            dt_sh_dis.Columns.Add("温度[℃]", typeof(double));
            dt_sh_dis.Columns.Add("比热容[J kg^-1 ℃^-1]", typeof(double));

            dt_hc_fun = new DataTable("hc_fun");
            ds.Tables.Add(dt_hc_fun);
            dt_hc_fun.Columns.Add("K", typeof(double));
            dt_hc_fun.Columns.Add("N", typeof(double));
            

            dt_sh_fun = new DataTable("sh_fun");
            ds.Tables.Add(dt_sh_fun);
            dt_sh_fun.Columns.Add("K", typeof(double));
            dt_sh_fun.Columns.Add("N", typeof(double));
            

            dgv_hc.DataSource = ds;
            dgv_sh.DataSource = ds;

        }
        public MaterialDetailsForm(Material mat,ButtonType _type)
        {
            InitializeComponent();
            material = mat;
            if (_type == ButtonType.Modify)
            {
                bu_f1.Text = "修改";
             
            }
            else if(_type == ButtonType.Update)
            {
                bu_f1.Text = "更新";
                
            }
            InitDataset();

        }
        public Material Material
        {
            get
            {
                material = UpdateData();
                return material;
            }
            set
            {
                material = value;
                UpdateUi();
            }
        }
        private void ListToDataTable(DataTable dt,List<RefValue> list)
        {
            dt.Clear();
            foreach(RefValue r in list)
            {
                DataRow dr = dt.NewRow();
                dr[0] = r.r;
                dr[1] = r.v;
                dt.Rows.Add(dr);
            }
            dt.AcceptChanges();
        }
        private void ListToDataTableK2C(DataTable dt, List<RefValue> list)
        {
            dt.Clear();
            foreach (RefValue r in list)
            {
                DataRow dr = dt.NewRow();
                dr[0] = GlobalTool.K2C(r.r);
                dr[1] = r.v;
                dt.Rows.Add(dr);
            }
            dt.AcceptChanges();
        }
        private void DataTableToList(DataTable dt, List<RefValue> list)
        {
            list.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                if (dr[0].ToString() == "" || dr[1].ToString() == "")
                    continue;
                RefValue r = new RefValue((double)dr[0], (double)dr[1]);
                list.Add(r);
            }
        }
        private void DataTableToListC2K(DataTable dt, List<RefValue> list)
        {
            list.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr[0].ToString() == "" || dr[1].ToString() == "")
                    continue;
                RefValue r = new RefValue(GlobalTool.C2K((double)dr[0]), (double)dr[1]);
                list.Add(r);
            }
        }
        private void UpdateUi()
        {
            tb_name.Text = material.Name;
            tb_code.Text = material.Code;
            tb_owner.Text = material.Owner.Name;
            tb_usefor.Text = material.Use_for;
            tb_remark.Text = material.Remark;
            cb_share.Checked = material.Share;
            tb_density.Text = material.Density.ToString();
            
            if(material.TcIsFun)
            {
                ListToDataTable(dt_hc_fun, material.TCs);
                dgv_hc.DataMember = "hc_fun";
            }
            else
            {
                ListToDataTableK2C(dt_hc_dis, material.TCs);
                dgv_hc.DataMember = "hc_dis";
            }
            if (material.ShIsFun)
            {
                ListToDataTable(dt_sh_fun, material.SHs);
                dgv_sh.DataMember = "sh_fun";
            }
            else
            {
                ListToDataTableK2C(dt_sh_dis, material.SHs);
                dgv_sh.DataMember = "sh_dis";
            }

            rb_hc_disperse.Checked = !material.TcIsFun;
            rb_hc_function.Checked = material.TcIsFun;
            rb_sh_disperse.Checked = !material.ShIsFun;
            rb_sh_function.Checked = material.ShIsFun;

            UpdateHCChart();
            UpdateSHChart();
        }
        private bool CheckDataValidated()
        {
            if (tb_name.Text.Length == 0)
                return false;
            if (!Regex.IsMatch(tb_density.Text, REGSTR_RealNumber))
                return false;
            if (dgv_hc.Rows.Count == 0 || dgv_sh.Rows.Count == 0)
                return false;
            Material mat = UpdateData();
            if (mat.TCs.Count == 0 || mat.SHs.Count == 0)
                return false;
            return true;
        }
        private Material UpdateData()
        {
            List<RefValue> hcs = new List<RefValue>();
            if(rb_hc_function.Checked)
                DataTableToList(dt_hc_fun, hcs);
            else
                DataTableToListC2K(dt_hc_dis, hcs);
            List<RefValue> shs = new List<RefValue>();
            if (rb_sh_function.Checked)
                DataTableToList(dt_sh_fun, shs);
            else
                DataTableToListC2K(dt_sh_dis, shs);
            SortList(hcs);
            SortList(shs);
            return new Material(material.Index, tb_name.Text, material.Owner,material.OwnerId, tb_code.Text, tb_usefor.Text, material.Create_time, material.Modify_time, double.Parse(tb_density.Text), tb_remark.Text, hcs, shs, rb_hc_function.Checked, rb_sh_function.Checked, cb_share.Checked);
        }
        
        private void UpdateChart(DataGridView d,Chart c,bool fun)
        {
            Series s = new Series();
            s.BorderWidth = 3;
            s.ChartType = SeriesChartType.Spline;
            if(fun)
            {
                for(int i=0;i<100;i++)
                {
                    double x = 273.15 + 17.0 * i;
                    double y = 0;
                    foreach (DataGridViewRow dgvr in d.Rows)
                    {
                        if(dgvr.Cells[0].Value!=null&& dgvr.Cells[1].Value!= null)
                            if(dgvr.Cells[0].Value.ToString()!=""&& dgvr.Cells[1].Value.ToString() != "")
                                y += double.Parse(dgvr.Cells[0].Value.ToString()) * Math.Pow(x, double.Parse(dgvr.Cells[1].Value.ToString()));
                    }
                    s.Points.AddXY(x, y);
                }
            }
            else
            {
                foreach (DataGridViewRow dgvr in d.Rows)
                {
                    if (dgvr.Cells[0].Value != null && dgvr.Cells[1].Value != null)
                        if (dgvr.Cells[0].Value.ToString() != "" && dgvr.Cells[1].Value.ToString() != "")
                            s.Points.AddXY(double.Parse(dgvr.Cells[0].Value.ToString()), double.Parse(dgvr.Cells[1].Value.ToString()));
                }
            }
            c.Series.Clear();
            c.Series.Add(s);
            c.ChartAreas[0].RecalculateAxesScale();

        }
        private void UpdateHCChart()
        {
            UpdateChart(dgv_hc, ct_hc, rb_hc_function.Checked);
        }
        private void UpdateSHChart()
        {
            UpdateChart(dgv_sh, ct_sh, rb_sh_function.Checked);
        }

        private void MaterialDetailsForm_Load(object sender, EventArgs e)
        {
            
            UpdateUi();
            
        }

        private void OnHCCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateHCChart();
        }
        private void OnSHCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            UpdateSHChart();
        }

        private void OnHCDGVCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
            if(rb_hc_function.Checked)
            {
                if (Regex.IsMatch(e.FormattedValue.ToString(), REGSTR_RealNumber) || e.FormattedValue.ToString()=="")
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                if (Regex.IsMatch(e.FormattedValue.ToString(), REGSTR_PositiveRealNumber) && double.Parse(e.FormattedValue.ToString()) != 0 || e.FormattedValue.ToString() == "")
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                   
                }
            }
        }

        private void OnSHDGVCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (rb_sh_function.Checked)
            {
                if (Regex.IsMatch(e.FormattedValue.ToString(), REGSTR_RealNumber) || e.FormattedValue.ToString() == "")
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                if (Regex.IsMatch(e.FormattedValue.ToString(), REGSTR_PositiveRealNumber) && double.Parse(e.FormattedValue.ToString()) != 0 || e.FormattedValue.ToString() == "")
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;

                }
            }
        }

        private void OnRbHcCheckedChanged(object sender, EventArgs e)
        {
            if (rb_hc_disperse.Checked)
                dgv_hc.DataMember = "hc_dis";
            else
                dgv_hc.DataMember = "hc_fun";
            UpdateHCChart();
        }

        private void OnRbShCheckedChanged(object sender, EventArgs e)
        {
            if (rb_sh_disperse.Checked)
                dgv_sh.DataMember = "sh_dis";
            else
                dgv_sh.DataMember = "sh_fun";
            UpdateSHChart();
        }
        private void bu_f1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
       
        private void bu_cancel_Click(object sender, EventArgs e)
        {
            //MaterialResult = null;
            this.Close();
        }

        private void bu_ok_Click(object sender, EventArgs e)
        {
            if (!CheckDataValidated())
                MessageBox.Show("您输入的数据不合法，请检查您输入的数据！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //MaterialResult = UpdateData();
                Close();
            }
        }

        private void bu_f2_Click(object sender, EventArgs e)
        {

        }
    }
}
