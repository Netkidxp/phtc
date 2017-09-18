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
    public partial class LayerForm : Form
    {
        private static string REGSTR_PositiveRealNumber = @"^[0-9]\d*(\.\d+)?$";
        private CalculationMode mode;
        private List<Material> materials;
        private GeometrySchema schema;
        private Layer layer;
        private bool Modify { set; get; }
        
        public Layer Layer
        {
            set
            {
                layer = value;
                if (value is ResistanceLayer)
                {
                    cb_Type.SelectedIndex = 1;
                    tb_Resistance.Text = value.HeatResistance.ToString();
                    
                }
                else
                {
                    cb_Type.SelectedIndex = 0;
                    int i = Materials.IndexOf(value.Material);
                    cb_Material.SelectedIndex = i;
                    tb_Thickness.Text = (value.Thickness*1000.0).ToString();
                }
                tb_Name.Text = value.Name;
                Modify = false;
            }
            get
            {
                if (!Modify)
                    return layer;
                else
                {
                    Layer _layer;
                    if (cb_Type.SelectedIndex == 0)
                    {
                        double thickness = double.Parse(tb_Thickness.Text)/1000.0;
                        int i = cb_Material.SelectedIndex;
                        Material mat = materials[i];
                        if (schema == GeometrySchema.Plate)
                        {
                            _layer = new Layer(mat, thickness, 1, 1);
                        }
                        else
                        {
                            _layer = new TubbinessLayer(mat, thickness, 1, 1);
                        }
                    }
                    else
                    {
                        double resistance = double.Parse(tb_Resistance.Text);
                        _layer = new ResistanceLayer(resistance);
                    }
                    _layer.Name = tb_Name.Text;
                    _layer.HighTemperature = layer.HighTemperature;
                    _layer.LowTemperature = layer.LowTemperature;
                    return _layer;
                }      
            }
        }

        public List<Material> Materials
        {   get => materials;
            set
            {
                materials = value;
                cb_Material.Items.Clear();
                foreach(Material m in materials)
                {
                    cb_Material.Items.Add(m.Name+"("+m.Index.ToString()+")");
                }
            }

        }
        public bool IsTarget
        {
            get
            {
                return cb_TargetThickness.Checked;
            }
            set
            {
                cb_TargetThickness.Checked = value;
            }
        }
        public LayerForm(Layer _layer, CalculationMode _mode, GeometrySchema _schema,List<Material> _materials,bool _isTarget)
        {
            InitializeComponent();
            Materials = _materials;
            mode = _mode;
            schema = _schema;
            Layer = _layer;
            IsTarget = _isTarget;
        }

        private void LayerForm_Load(object sender, EventArgs e)
        {
            
        }
        private void OnCbTypeSelectedChanged(object sender, EventArgs e)
        {
            if (cb_Type.SelectedIndex==1)
            {
                lb_Material.Visible = false;
                lb_Thickness.Visible = false;
                cb_Material.Visible = false;
                tb_Thickness.Visible = false;
                lb_Resistance.Visible = true;
                tb_Resistance.Visible = true;
                cb_TargetThickness.Visible = false;
            }
            else
            {
                lb_Material.Visible = true;
                lb_Thickness.Visible = true;
                cb_Material.Visible = true;
                tb_Thickness.Visible = true;
                lb_Resistance.Visible = false;
                tb_Resistance.Visible = false;
                if (mode == CalculationMode.Thickness)
                    cb_TargetThickness.Visible = true;
                else
                    cb_TargetThickness.Visible = false;

            }
        }

        private void bu_ok_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(REGSTR_PositiveRealNumber);
            if (tb_Name.Text==string.Empty)
            {
                MessageBox.Show("请您输入层名称", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cb_Type.SelectedIndex==1)
            {
                if(r.IsMatch(tb_Resistance.Text))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("热阻输入不合法", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if(r.IsMatch(tb_Thickness.Text))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("厚度输入不合法", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void OnTbNameChanged(object sender, EventArgs e)
        {
            if (tb_Name.Text != layer.Name)
                Modify = true;
            else
                Modify = false;

        }

        private void OnCbMaterialChanged(object sender, EventArgs e)
        {
            if (Materials[cb_Material.SelectedIndex] != layer.Material)
                Modify = true;
            else
                Modify = false;
        }

        private void OnTbThicknessChanged(object sender, EventArgs e)
        {
            Modify = true;
        }

        private void OnTbResidualChanged(object sender, EventArgs e)
        {
            Modify = true;
        }

        private void OnCbTargetChanged(object sender, EventArgs e)
        {
            Modify = true;
        }
    }
}
