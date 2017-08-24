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
using System.Text.RegularExpressions;

namespace PHTC
{
    public partial class ColdBoundaryForm : Form
    {
        public static string REGSTR_PositiveRealNumber = @"^[0-9]\d*(\.\d+)?$";
        public static string REGSTR_RealNumber = @"^[+-]?\d+(\.\d+)?$";
        private CalculationMode mode;
        public double TargetValue
        {
            get
            {
                if (cb_type.SelectedIndex == 0)
                {
                    return double.Parse(tb_C1Hotflow.Text);
                }
                else if (cb_type.SelectedIndex == 1)
                {
                    return GlobalTool.C2K(double.Parse(tb_C2Temperature.Text));
                }
                else
                {
                    return GlobalTool.C2K(double.Parse(tb_C3Temperature.Text));

                }
            }
            set
            {
                if (cb_type.SelectedIndex == 0)
                {
                    tb_C1Hotflow.Text = value.ToString();
                }
                else if (cb_type.SelectedIndex == 1)
                {
                    tb_C2Temperature.Text = GlobalTool.K2C(value).ToString();
                }
                else
                {
                    tb_C3Temperature.Text = GlobalTool.K2C(value).ToString();

                }
            }
        }
        public Class1Boundary Boundary
        {
            get
            {
                Class1Boundary boundary;
                if (cb_type.SelectedIndex==0)
                {
                    boundary = new Class1Boundary(GlobalTool.C2K(double.Parse(tb_C1Temperature.Text)));
                }
                else if(cb_type.SelectedIndex==1)
                {
                    boundary = new Class2Boundary(double.Parse(tb_C2Hotflow.Text));
                }
                else
                {
                    boundary = new Class3Boundary(double.Parse(tb_C3ConvectionFilmCoefficient.Text), double.Parse(tb_C3Emissivity.Text), GlobalTool.C2K(double.Parse(tb_C3AmbientTemperature.Text)),1.0);

                }
                return boundary;
            }
            set
            {
                if (value is Class3Boundary)
                {
                    cb_type.SelectedIndex = 2;
                    Class3Boundary boudary =(Class3Boundary)value;
                    tb_C3AmbientTemperature.Text = GlobalTool.K2C(boudary.AmbientTemperature).ToString();
                    tb_C3ConvectionFilmCoefficient.Text = boudary.FilmCoefficient.ToString();
                    tb_C3Emissivity.Text = boudary.Emissivity.ToString();
                }
                else if(value is Class2Boundary)
                {
                    cb_type.SelectedIndex = 1;
                    Class2Boundary boundary = (Class2Boundary)value;
                    tb_C2Hotflow.Text = boundary.Heatflow.ToString();
                }
                else
                {
                    cb_type.SelectedIndex = 0;
                    tb_C1Temperature.Text = GlobalTool.K2C(value.Temperature).ToString();
                }
            }
        }
        public CalculationMode Mode
        {
            set
            {
                mode = value;
                if(mode==CalculationMode.Temperature)
                {
                    tb_C1Hotflow.Visible = false;
                    tb_C2Temperature.Visible = false;
                    tb_C3Temperature.Visible = false;
                    lb_C1Hotflow.Visible = false;
                    lb_C2Temperature.Visible = false;
                    lb_C3Temperature.Visible = false;
                }
                else
                {
                    tb_C1Hotflow.Visible = true;
                    tb_C2Temperature.Visible = true;
                    tb_C3Temperature.Visible = true;
                    lb_C1Hotflow.Visible = true;
                    lb_C2Temperature.Visible = true;
                    lb_C3Temperature.Visible = true;
                }
            }
            get
            {
                return mode;
            }
        }
        public ColdBoundaryForm(Class1Boundary _boundary,CalculationMode _mode)
        {
            InitializeComponent();
            Boundary = _boundary;
            Mode = _mode;
        }
        private void OnCbTypeChanged(object sender, EventArgs e)
        {
            tc_main.SelectedIndex = cb_type.SelectedIndex;
            /*Class1Boundary ob = Boundary;
            Class1Boundary nb = null;
            switch(cb_type.SelectedIndex)
            {
                case 0:
                    nb = new Class1Boundary(ob.Temperature);
                    break;
                case 1:
                    nb = new Class2Boundary(ob.Heatflow);
                    break;
                case 3:
                    nb = new Class3Boundary(10.0, 0.8, 25 + 273.15, 1.0);
                    break;
            }
            Boundary = nb;*/
        }

        private void bu_Ok_Click(object sender, EventArgs e)
        {
            if(CheckInput(cb_type.SelectedIndex))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("您的输入不合法", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckInput(int index)
        {
            if (index == 0)
                return CheckC1Input();
            else if (index == 1)
                return CheckC2Input();
            else
                return CheckC3Input();
        }
        private bool CheckC1Input()
        {
            Regex r = new Regex(REGSTR_RealNumber);
            if (!r.IsMatch(tb_C1Temperature.Text))
                return false;
            if (double.Parse(tb_C1Temperature.Text) < -273.15)
                return false;
            if(Mode==CalculationMode.Thickness)
            {
                Regex r1 = new Regex(REGSTR_PositiveRealNumber);
                if (!r1.IsMatch(tb_C1Hotflow.Text))
                    return false;
            }
            return true;
        }
        private bool CheckC2Input()
        {
            Regex r = new Regex(REGSTR_PositiveRealNumber);
            if (!r.IsMatch(tb_C2Hotflow.Text))
                return false;
            if (Mode == CalculationMode.Thickness)
            {
                Regex r1 = new Regex(REGSTR_RealNumber);
                if (!r1.IsMatch(tb_C2Temperature.Text))
                    return false;
                if (double.Parse(tb_C2Temperature.Text) < -273.15)
                    return false;
            }
            return true;
        }
        private bool CheckC3Input()
        {
            Regex r1 = new Regex(REGSTR_RealNumber);
            Regex r2 = new Regex(REGSTR_PositiveRealNumber);
            if (!r1.IsMatch(tb_C3AmbientTemperature.Text))
                return false;
            if (double.Parse(tb_C3AmbientTemperature.Text) < -273.15)
                return false;
            if (!r1.IsMatch(tb_C3ConvectionFilmCoefficient.Text))
                return false;
            if (!r1.IsMatch(tb_C3Emissivity.Text))
                return false;
            double cfc = double.Parse(tb_C3ConvectionFilmCoefficient.Text);
            double emt = double.Parse(tb_C3Emissivity.Text);
            if (cfc < 0 || emt < 0 || (cfc == 0 && emt == 0))
                return false;
            if (emt > 1.0)
                return false;
            if (Mode == CalculationMode.Thickness)
            {
                if (!r1.IsMatch(tb_C3Temperature.Text))
                    return false;
                if (double.Parse(tb_C3Temperature.Text) < -273.15)
                    return false;
            }
            return true;
        }
    }
}
