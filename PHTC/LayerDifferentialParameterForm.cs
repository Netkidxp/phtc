using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHTC
{
    public partial class LayerDifferentialParameterForm : Form
    {
        public int DifferentialCount
        {
            get
            {
                return (int)nud_differential.Value;
            }
            set
            {
                nud_differential.Value = value;
            }
        }
        public LayerDifferentialParameterForm(int _differential)
        {
            InitializeComponent();
            DifferentialCount = _differential;
        }

        private void bu_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
