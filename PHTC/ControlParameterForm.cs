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
    public partial class ControlParameterForm : Form
    {
        private static string REGSTR_NonnegativeInteger = @"^\d+$";
        private static string REGSTR_PositiveRealNumber = @"^[0-9]\d*(\.\d+)?$";
        private SolverControlParameter parameter;
        public SolverControlParameter ControlParameter
        {
            set
            {
                parameter = new SolverControlParameter(value.CcType,value.Residual,value.MaxStep,value.IntegrateCount);
                tb_residual.Text = parameter.Residual.ToString();
                tb_maxstep.Text = parameter.MaxStep.ToString();
                if (parameter.CcType==SolverControlParameter.ConvergenceCriterionType.RESIDUAL)
                {
                    cb_residual.Checked = true;
                    tb_residual.Enabled = true;
                    cb_maxstep.Checked = false;
                    tb_maxstep.Enabled = false;
                    
                }
                else if(parameter.CcType==SolverControlParameter.ConvergenceCriterionType.MAXSTEP)
                {
                    cb_residual.Checked = false;
                    tb_residual.Enabled = false;
                    cb_maxstep.Checked = true;
                    tb_maxstep.Enabled = true;
                   
                }
                else
                {
                    cb_residual.Checked = true;
                    tb_residual.Enabled = true;
                    cb_maxstep.Checked = true;
                    tb_maxstep.Enabled = true; 
                }
                
            }
            get
            {
                if (cb_maxstep.Checked&&cb_residual.Checked)
                {
                    parameter.CcType = SolverControlParameter.ConvergenceCriterionType.RESIDUAL_OR_MAXSTEP;
                    parameter.Residual = double.Parse(tb_residual.Text);
                    parameter.MaxStep = int.Parse(tb_maxstep.Text);
                }
                else
                {
                    if (cb_maxstep.Checked)
                    {
                        parameter.CcType = SolverControlParameter.ConvergenceCriterionType.MAXSTEP;
                        parameter.MaxStep = int.Parse(tb_maxstep.Text);
                    }
                    else
                    {
                        parameter.CcType = SolverControlParameter.ConvergenceCriterionType.RESIDUAL;
                        parameter.Residual = double.Parse(tb_residual.Text);
                    }
                }
                return parameter;
            }
        }
        public ControlParameterForm(SolverControlParameter _parameter)
        {
            InitializeComponent();
            ControlParameter = _parameter;
        }
        private bool CheckInput()
        {
            Regex r1 = new Regex(REGSTR_NonnegativeInteger);
            Regex r2 = new Regex(REGSTR_PositiveRealNumber);
            if (!cb_residual.Checked && !cb_maxstep.Checked)
                return false;
            if (cb_residual.Checked)
            {
                double re = 0.0;
                if (!double.TryParse(tb_residual.Text,out re))
                    return false;
                if (double.Parse(tb_residual.Text) <= 0)
                    return false;
            }   
            if (cb_maxstep.Checked)
            {
                int mt = 0;
                if (!int.TryParse(tb_maxstep.Text,out mt))
                    return false;
                mt = int.Parse(tb_maxstep.Text);
                if (mt<=0||mt>10000)
                {
                    return false;
                }
            }
                
            return true;
        }
        private void bu_ok_Click(object sender, EventArgs e)
        {
            if(CheckInput())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("您的输入不合法", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnCbResidualCheckChanged(object sender, EventArgs e)
        {
            tb_residual.Enabled = cb_residual.Checked;
        }

        private void OnCbMaxstepCheckChanged(object sender, EventArgs e)
        {
            tb_maxstep.Enabled = cb_maxstep.Checked;
        }
    }
}
