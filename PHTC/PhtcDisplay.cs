using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using PHTC.Model;
namespace PHTC
{
    public partial class PhtcDisplay : UserControl
    {
        public delegate void HotfaceDbClickHandler();
        public delegate void ColdfaceDbClickHandler();
        public delegate void LayerDbClickHandler(int index);

        private Project project;
        public Project Project
        {
            get
            {
                return project;
            }
            set
            {
                project = value;
                this.Refresh();
            }
        }
        private HotfaceDbClickHandler onHotfaceDbClick;
        private ColdfaceDbClickHandler onColdfaceDbClick;
        private LayerDbClickHandler onLayerDbClick;

        private Rectangle RStaff
        {
            get
            {
                Rectangle r = this.Bounds;
                return new Rectangle(r.Left, r.Top, 130, r.Height);
            }
        }
        private Rectangle RHotface
        {
            get
            {
                Rectangle r = this.Bounds;
                return new Rectangle(RStaff.Right + 10, r.Top + r.Height / 10, 20, 175);
            }
        }
        private Rectangle RLayers
        {
            get
            {
                Rectangle r = this.Bounds;
                return new Rectangle(RHotface.Right, RHotface.Top, 500, 175);
            } 
        }
        private Rectangle RColdface
        {
            get
            {
                Rectangle r = this.Bounds;
                return new Rectangle(RLayers.Right, RLayers.Top, 20, 175);
            }
        }
        private Rectangle RGeo
        {
            get
            {
                Rectangle r = this.Bounds;
                return new Rectangle(RHotface.Left, RHotface.Top, RHotface.Width + RLayers.Width + RColdface.Width, RHotface.Height);
            }
        }
        private List<Rectangle> RLayerList
        {
            get
            {
                List<Rectangle> rs = new List<Rectangle>();
                Rectangle r = RLayers;
                const double rlWidth = 5;
                double sumThickness = 0;
                int sumResitanceLayer = 0;
                double t = r.Left;
                foreach (Layer l in Project.LayerList)
                {
                    if (l is ResistanceLayer)
                    {
                        sumResitanceLayer += 1;
                    }
                    else
                    {
                        sumThickness += l.Thickness;
                    }

                }
                for (int i = 0; i < Project.LayerList.Count; i++)
                {
                    Layer l = Project.LayerList[i];
                    if (l is ResistanceLayer)
                    {
                        Rectangle rect = new Rectangle((int)t, r.Top, (int)rlWidth, r.Height);
                        rs.Add(rect);
                        t += rlWidth;
                    }
                    else
                    {
                        double width = l.Thickness / sumThickness * (r.Width - sumResitanceLayer * rlWidth);
                        if (width < rlWidth)
                            width = rlWidth;
                        Rectangle rect = new Rectangle((int)t, r.Top, (int)width, r.Height);
                        rs.Add(rect);
                        t += width;
                    }

                }
                return rs;
            }
        }
        
        public HotfaceDbClickHandler OnHotfaceClick { get => onHotfaceDbClick; set => onHotfaceDbClick = value; }
        public ColdfaceDbClickHandler OnColdfaceClick { get => onColdfaceDbClick; set => onColdfaceDbClick = value; }
        public LayerDbClickHandler OnLayerDbClick { get => onLayerDbClick; set => onLayerDbClick = value; }

        public PhtcDisplay()
        {
            InitializeComponent();
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawPhtc(e.Graphics, e.ClipRectangle);
        }
        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (Project == null)
                return;
            if(RHotface.Contains(e.Location))
            {
                double t = GlobalTool.K2C(Project.HotfaceTemperature);
                lb_temperature.Text = t.ToString();
            }
            else if(RColdface.Contains(e.Location))
            {
                double t = GlobalTool.K2C(Project.ColdfaceBoundary.Temperature);
                lb_temperature.Text = t.ToString();
            }
            else if(RLayers.Contains(e.Location))
            {
                lb_temperature.Text = PointTemperature(e.Location).ToString();
            }
            else
            {
                lb_temperature.Text = "0";
            }
        }
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            if (Project == null)
                return;
            if (RHotface.Contains(e.Location))
            {
                if (OnHotfaceClick != null)
                    OnHotfaceClick();
            }
            else if (RColdface.Contains(e.Location))
            {
                if (OnColdfaceClick != null)
                    OnColdfaceClick();
            }
            else if (RLayers.Contains(e.Location))
            {
                if (OnLayerDbClick != null)
                {
                    int i = PointLayerIndex(e.Location);
                    if(i!=-1)
                        OnLayerDbClick(i);
                }
                    
            }
        }
        private int PointLayerIndex(Point p)
        {
            int pi = -1;
            for (int i = 0; i < Project.LayerList.Count; i++)
            {
                if (RLayerList[i].Contains(p))
                {
                    pi = i;
                }
            }
            return pi;
        }
        private double PointTemperature(Point p)
        {
            
            Layer l=null;
            Rectangle r=new Rectangle();
            for(int i=0;i<Project.LayerList.Count;i++)
            {
                if (RLayerList[i].Contains(p))
                {
                    r = RLayerList[i];
                    l = Project.LayerList[i];
                }
            }
            if (l == null||l is ResistanceLayer)
                return 0;
            double t = l.HighTemperature-((double)p.X - (double)r.Left) / (double)r.Width * (l.HighTemperature -l.LowTemperature);
            return GlobalTool.K2C(t);
        }
        private void DrawPhtc(Graphics g,Rectangle r)
        {
            if (Project == null)
                return; 
            DrawStaff(g,RStaff);
            DrawRect(g, RHotface, COT(Project.HotfaceTemperature), COT(Project.HotfaceTemperature), "热面");
            DrawLayers(g, RLayers);
            DrawRect(g, RColdface, COT(Project.ColdfaceBoundary.Temperature), COT(Project.ColdfaceBoundary.Temperature), "冷面");
            g.DrawRectangle(new Pen(Color.Black), RGeo);
            lb_hotflow.Text = Project.ColdfaceBoundary.Heatflow.ToString("F0");
        }
        private void DrawRect(Graphics g,Rectangle r,Color hotColor,Color coldColor)
        {
            Brush b = new LinearGradientBrush(r, hotColor, coldColor,LinearGradientMode.Horizontal);
            using (b)
            {
                g.FillRectangle(b, r);
                g.DrawRectangle(new Pen(Color.White), r);
            }
        }
        private void DrawRect(Graphics g, Rectangle r, Color hotColor, Color coldColor,string vs)
        {
            Brush b = new LinearGradientBrush(r, hotColor, coldColor, LinearGradientMode.Horizontal);
            Brush bs = new SolidBrush(Color.White);
            Font font = new Font("宋体", 9);
            g.FillRectangle(b, r);
            g.DrawRectangle(new Pen(Color.White), r);
            SizeF sz=g.MeasureString(vs, font,0, new StringFormat(StringFormatFlags.DirectionVertical));
            if(sz.Width<r.Width&&sz.Height<r.Height)
            {
                g.DrawString(vs, font, bs, r.Left + (r.Width - sz.Width) / 2, r.Top + (r.Height - sz.Height) / 2,new StringFormat(StringFormatFlags.DirectionVertical));
            }

        }
        private void DrawLayers(Graphics g, Rectangle r)
        {
            for(int i=0;i<Project.LayerList.Count;i++)
            {
                Layer l = Project.LayerList[i];
                if(l is ResistanceLayer)
                {
                    DrawRect(g, RLayerList[i], Color.Gray, Color.Gray);
                }
                else
                {
                    DrawRect(g, RLayerList[i], COT(l.HighTemperature), COT(l.LowTemperature), l.Name);
                }
                
            }
        }
        private Color COT(double temperature)
        {
            int maxc = Color.Red.ToArgb();
            int minc = Color.Blue.ToArgb();
            double maxt = Project.HotfaceTemperature;
            double mint = Project.ColdfaceBoundary.Temperature;
            int resc = minc+(int)((temperature - mint) / (maxt - mint) * (maxc - minc));
            return Color.FromArgb(resc);
        }
        private void DrawStaff(Graphics g, Rectangle r)
        {
            Rectangle rStaff = new Rectangle(r.Left + r.Width / 4, r.Top + r.Height/10, r.Width / 4, r.Height - r.Height/4);
            using (Brush b = new LinearGradientBrush(rStaff, Color.Red, Color.Blue, LinearGradientMode.Vertical))
            {
                g.FillRectangle(b, rStaff);
                Font font = new Font("宋体", 9);
                Brush bs = new SolidBrush(Color.Black);
                for (double i = 0; i <= 5; i++)
                {
                    double v = GlobalTool.K2C(Project.HotfaceTemperature-i / 5.0 * (Project.HotfaceTemperature - Project.ColdfaceBoundary.Temperature));
                    string vs = v.ToString("F0");
                    g.DrawString(vs, font, bs, rStaff.Right, rStaff.Top + (int)(i / 5 * rStaff.Height)-8);

                }
                g.DrawString("温度[℃]", font, bs, rStaff.Left, rStaff.Bottom+10);
                bs.Dispose();
                font.Dispose();
                
            }
        }
    }
}
