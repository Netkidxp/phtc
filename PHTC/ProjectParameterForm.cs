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
namespace PHTC
{
    public partial class ProjectParameterForm : Form
    {
        public string ProjectName
        {
            get
            {
                return tb_name.Text;
            }
            set
            {
                tb_name.Text = value;
            }
        }
        public bool Share
        {
            get
            {
                return cb_share.Checked;
            }
            set
            {
                cb_share.Checked = value;
            }
        }
        public CalculationMode SolverType
        {
            get
            {
                if (cb_SolverType.SelectedIndex == 0)
                    return CalculationMode.Temperature;
                else
                    return CalculationMode.Thickness;
            }
            set
            {
                if (value == CalculationMode.Temperature)
                    cb_SolverType.SelectedIndex = 0;
                else
                    cb_SolverType.SelectedIndex = 1;
            }
        }

        public GeometrySchema Schema
        {
            get
            {
                if (cb_GeometrySchema.SelectedIndex == 0)
                    return GeometrySchema.Plate;
                else
                    return GeometrySchema.Tubbiness;
            }
            set
            {
                if (value == GeometrySchema.Plate)
                    cb_GeometrySchema.SelectedIndex = 0;
                else
                    cb_GeometrySchema.SelectedIndex = 1;
            }
        }
        public string Remark
        {
            get
            {
                return tb_remark.Text;
            }
            set
            {
                tb_remark.Text = value;
            }
        }
        public ProjectParameterForm()
        {
            InitializeComponent();
        }

        private void bu_ok_Click(object sender, EventArgs e)
        {
            if(tb_name.Text.Length!=0)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("工程名称不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
