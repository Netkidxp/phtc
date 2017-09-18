using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHTC.Model;
namespace PHTC
{
    public partial class HotfaceParameterForm : Form
    {
        //private static string REGSTR_PositiveRealNumber = @"^[0-9]\d*(\.\d+)?$";
        private GeometrySchema schema;
        public GeometrySchema Schema
        {
            set
            {
                if (value == GeometrySchema.Plate)
                {
                    lb_RorW.Text = @"长[mm]";
                    lb_LorH.Text=@"宽[mm]";
                }
                else
                {
                    lb_RorW.Text = @"半径[mm]";
                    lb_LorH.Text = @"轴向长度[mm]";
                }
                schema = value;
            }
        }
        public double Radius
        {
            get
            {
                
                return double.Parse(tb_RorW.Text)/1000.0;
                
            }
            set
            {
                tb_RorW.Text = (value*1000.0).ToString();
            }
        }
        public double Length
        {
            get
            {

                return double.Parse(tb_LorH.Text)/1000.0;

            }
            set
            {
                tb_LorH.Text = (value*1000.0).ToString();
            }
        }
        new public double Width
        {
            get
            {

                return double.Parse(tb_RorW.Text)/1000.0;

            }
            set
            {
                tb_RorW.Text = (value*1000.0).ToString();
            }
        }
        new public double Height
        {
            get
            {

                return double.Parse(tb_LorH.Text)/1000.0;

            }
            set
            {
                tb_LorH.Text = (value*1000).ToString();
            }
        }
        public double Temperature
        {
            get
            {
                return GlobalTool.C2K(double.Parse(tb_Temperature.Text));
            }
            set
            {
                tb_Temperature.Text = GlobalTool.K2C(value).ToString();
            }
        }
        
        public HotfaceParameterForm(GeometrySchema _schema,double _RorW,double _LorH)
        {
            InitializeComponent();
            Schema = _schema;
            Radius = _RorW;
            Length = _LorH;
        }

        private void OnTemperatureChanged(object sender, EventArgs e)
        {
            
        }
        private bool CheckInput()
        {
            double v;
            if (!double.TryParse(tb_Temperature.Text, out v))
                return false;
            if (double.Parse(tb_Temperature.Text) < 273.15)
                return false;
            if (!double.TryParse(tb_RorW.Text, out v))
                return false;
            if (double.Parse(tb_RorW.Text) < 0)
                return false;
            if (!double.TryParse(tb_LorH.Text, out v))
                return false;
            if (double.Parse(tb_LorH.Text) < 0)
                return false;
            return true;
        }

        private void bu_ok_Click(object sender, EventArgs e)
        {
                if (CheckInput())
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("您的输入不合法", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
