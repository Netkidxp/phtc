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
    public partial class MainDisplay : UserControl
    {
        public enum LANG{
            ENG = 0,
            CH = 1
        }
        int space;
        int xAxisHeight;
        int yAxisWidth;
        int minWidth;
        int boundaryWidth;
        Color maxColor;
        Color minColor;
        double maxt;
        double mint;
        Project pro;
        LANG lang;
        Dictionary<LANG, Dictionary<string, string>> STR;
        private string Str(string key)
        {
            Dictionary<string, string> dic = STR[lang];
            if (dic == null)
                return "null";
            string s = dic[key];
            if (s == null)
                return "null";
            else
                return s;
        }
        public LANG Language
        {
            get
            {
                return lang;
            }
            set
            {
                lang = value;
                Refresh();
            }
        }
        public delegate void HotfaceDbClickHandler();
        public delegate void ColdfaceDbClickHandler();
        public delegate void LayerDbClickHandler(int index);
        private HotfaceDbClickHandler onHotfaceDbClick;
        private ColdfaceDbClickHandler onColdfaceDbClick;
        private LayerDbClickHandler onLayerDbClick;
        public MainDisplay()
        {
            AxisFont= new Font("宋体", 9);
            NumberFont = new Font("Arial Unicode MS", 10);
            TitleFont = new Font("宋体",12,FontStyle.Bold);
            TitleHeight = 40;
            TickLength = 2;
            RightSpace = 30;
            STR = new Dictionary<LANG, Dictionary<string, string>>();
            Dictionary<string, string> Eng = new Dictionary<string, string>();
            Eng.Add("szAxisXName", "Thickness[mm]");
            Eng.Add("szAxisYName", "Temperature[℃]");
            Eng.Add("szHeatflow", "Heatflow:");
            Eng.Add("szTitle", "Temperature Diagram");
            Eng.Add("szHotface", "Hotface");
            Eng.Add("szColdface", "Coldface");
            STR.Add(LANG.ENG, Eng);
            Dictionary<string, string> Ch = new Dictionary<string, string>();
            Ch.Add("szAxisXName", "厚度[mm]");
            Ch.Add("szAxisYName", "温度[℃]");
            Ch.Add("szHeatflow", "热流:");
            Ch.Add("szTitle", "温度示意图");
            Ch.Add("szHotface", "热面");
            Ch.Add("szColdface", "冷面");
            STR.Add(LANG.CH, Ch);
            lang = LANG.CH;

            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            
            Space = 5;
            XAxisHeight = 100;
            YAxisWidth = 60;
            MinWidth = 2;
            MaxColor = Color.Red;
            MinColor = Color.Blue;
            BoundaryWidth = 20;
           
        }
        private int XAxisHeight
        {
            get => xAxisHeight;
            set
            {
                xAxisHeight = value;
                //Refresh();
            }
        }
        private int YAxisWidth
        {
            get => yAxisWidth;
            set
            {
                yAxisWidth = value;
                //Refresh();
            }
        }
        public int MinWidth
        {
            get => minWidth;
            set
            {
                minWidth = value;
                Refresh();
            } 
        }
        public int BoundaryWidth
        {
            get => boundaryWidth;
            set
            {
                boundaryWidth = value;
                Refresh();
            }
        }
        public Project Pro
        {
            get => pro;
            set
            {
                pro = value;
                if(pro!=null)
                {
                    this.mint = Math.Min(GlobalTool.K2C(pro.HotfaceTemperature), GlobalTool.K2C(pro.ColdfaceBoundary.Temperature));
                    this.maxt = Math.Max(GlobalTool.K2C(pro.HotfaceTemperature), GlobalTool.K2C(pro.ColdfaceBoundary.Temperature));
                }
                Refresh();
            }
        }
        public int Space
        {
            get
            {
                return space;
            }
            set
            {
                space = value;
                Refresh();
            }
        }
        Rectangle RView
        {
            get
            {
                Rectangle r = this.Bounds;
                return new Rectangle(r.X + Space, r.Y + Space, r.Width - 2 * Space, r.Height - 2 * Space);
            }
        }
        Rectangle RGeo
        {
            get
            {
                return new Rectangle(RYAxis.Right,RTitle.Bottom,RView.Width-AxisSpace.Width-RightSpace,RView.Height-TitleHeight-AxisSpace.Height);
            }
        }
        Rectangle RHotFace
        {
            get
            {
                return new Rectangle(RGeo.X,RGeo.Y,BoundaryWidth,RGeo.Height);
            }
        }
        Rectangle RColdFace
        {
            get
            {
                return new Rectangle(RGeo.Right - BoundaryWidth, RGeo.Y, BoundaryWidth, RGeo.Height);
            }
        }
        Rectangle RXAxis
        {
            get
            {
                Rectangle r = new Rectangle();
                r.X = RView.X+AxisSpace.Width;
                r.Width = RView.Width - AxisSpace.Width-RightSpace;
                r.Y = RView.Bottom - AxisSpace.Height;
                r.Height = AxisSpace.Height;
                return r;
            }
        }      
        Size AxisSpace
        {
            get
            {
                Size s = new Size();
                s.Height = (int)(SingleCharSize + MaxXStringHeight + TickLength + Space*5);
                s.Width = (int)(SingleCharSize + MaxYStringWidth + TickLength + Space * 3);
                return s;
            }
        }
        int TickLength
        {
            get;set;
        }
        int TitleHeight
        {
            get;set;
        }
        int RightSpace
        {
            get;set;
        }
        Rectangle RYAxis
        {
            get
            {
                Rectangle r = new Rectangle();
                r.X = RView.X;
                r.Y = RView.Top + TitleHeight;
                r.Width = AxisSpace.Width;
                r.Height = RView.Height - AxisSpace.Height - TitleHeight;
                return r;
            }
        }
        Rectangle RTitle
        {
            get
            {
                return new Rectangle(RView.X, RView.Y, RView.Width, TitleHeight);
            }
        }
        Font AxisFont
        {
            get;set;
        }
        Font NumberFont
        {
            get;set;
        }
        Font TitleFont
        {
            get;set;
        }
        float MaxXStringHeight
        {
            get
            {
                Graphics g = this.CreateGraphics();
                SizeF s = g.MeasureString(MaxLayThickness.ToString("F0"), AxisFont, 0, new StringFormat(StringFormatFlags.DirectionVertical));
                g.Dispose();
                return s.Height;
            }
        }
        float MaxYStringWidth
        {
            get
            {
                double t = 0;
                if (Pro != null)
                    t = Pro.HotfaceTemperature;
                Graphics g = this.CreateGraphics();
                SizeF s = g.MeasureString(t.ToString("F0"), AxisFont, 0);
                g.Dispose();
                return s.Width;
            }
        }
        float SingleCharSize
        {
            get
            {
                Graphics g = this.CreateGraphics();
                SizeF s = g.MeasureString("哈", AxisFont, 0);
                g.Dispose();
                return s.Height;
            }
        }
        double MaxLayThickness
        {
            get
            {
                double mt = 0;
                if(Pro!=null&&Pro.LayerList.Count>0)
                {
                    foreach(Layer l in Pro.LayerList)
                    {
                        if (l.Thickness > mt)
                            mt = l.Thickness;
                    }
                }
                return mt;
            }
        }
        List<Rectangle> RLayers
        {
            get
            {
                List<Rectangle> list = new List<Rectangle>();
                if (Pro == null)
                    return list;
                int numResiLayer = 0;
                double sumGeoThickness = 0;
                foreach(Layer l in Pro.LayerList)
                {
                    if (l is ResistanceLayer)
                        numResiLayer++;
                    else
                    {
                        sumGeoThickness += l.Thickness;
                    }
                        
                }
                int sumGeoLayerWidth = RGeo.Width - numResiLayer * MinWidth-2*BoundaryWidth;
                double scaler = sumGeoLayerWidth / sumGeoThickness;
                int offset = RHotFace.Right;
                foreach (Layer l in Pro.LayerList)
                {
                    Rectangle r;
                    if (l is ResistanceLayer)
                    {
                        r = new Rectangle(offset, RGeo.Y, MinWidth, RGeo.Height);
                        offset += MinWidth;
                    }  
                    else
                    {
                        int width = (int)(l.Thickness * scaler);
                        if (width < MinWidth)
                            width = MinWidth;
                        r = new Rectangle(offset, RGeo.Y, width, RGeo.Height);
                        offset += width;
                    }
                    list.Add(r);
                }
                return list;
            }
        }
        public Color MaxColor
        {
            get => maxColor;
            set
            {
                maxColor = value;
                Refresh();
            }
        }
        public Color MinColor
        {
            get => minColor;
            set
            {
                minColor = value;
                Refresh();
            }
        }
        public HotfaceDbClickHandler OnHotfaceClick { get => onHotfaceDbClick; set => onHotfaceDbClick = value; }
        public ColdfaceDbClickHandler OnColdfaceClick { get => onColdfaceDbClick; set => onColdfaceDbClick = value; }
        public LayerDbClickHandler OnLayerDbClick { get => onLayerDbClick; set => onLayerDbClick = value; }
        public void DrawTemperatureAxis(Graphics g)
        {
            if (Pro == null)
                return;
            if (Pro.LayerList.Count == 0)
                return;
            string axisYName = Str("szAxisYName");
            float mw = 0;
            double max = this.maxt;
            double min = this.mint;
            int tickCount = 6;
            double dtemp = (max - min) / tickCount;
            int dheight = RYAxis.Height / tickCount;
            Pen p = new Pen(Color.Black, 2);
            Brush b = new SolidBrush(Color.Black);
            for (int i=0;i<tickCount;i++)
            {
                Point pl = new Point(RYAxis.Right-Space, RYAxis.Bottom - i * dheight);
                Point ph = new Point(pl.X, pl.Y - dheight);
                Point pl_ = new Point(pl.X - TickLength, pl.Y);
                Point ph_ = new Point(ph.X - TickLength, ph.Y);
                g.DrawLine(p, pl, ph);
                g.DrawLine(p, pl, pl_);
                g.DrawLine(p, ph, ph_);
                string ts = (min + dtemp * i).ToString("F0");
                SizeF sz = g.MeasureString(ts, AxisFont, 0);
                RectangleF rf = new RectangleF(pl_.X - sz.Width -Space, pl_.Y - sz.Height/2, sz.Width, sz.Height);
                g.DrawString(ts, AxisFont, b, rf, null);
                if(i==tickCount-1)
                {
                    ts = (min + dtemp * (i+1)).ToString("F0");
                    sz = g.MeasureString(ts, AxisFont, 0);
                    rf = new RectangleF(ph_.X - sz.Width - Space, ph_.Y - sz.Height / 2, sz.Width, sz.Height);
                    g.DrawString(ts, AxisFont, b, rf, null);
                }
            }
            SizeF sz1 = g.MeasureString(axisYName, AxisFont, 0, new StringFormat(StringFormatFlags.DirectionVertical));
            RectangleF rf1 = new RectangleF(RYAxis.Left, RYAxis.Top+(RYAxis.Height-sz1.Height)/2,sz1.Width, sz1.Height);
            g.DrawString(axisYName, AxisFont, b, rf1, new StringFormat(StringFormatFlags.DirectionVertical));
            p.Dispose();
            b.Dispose();
        }
        public void DrawThicknessAxis(Graphics g)
        {
            if (Pro == null)
                return;
            if (Pro.LayerList.Count == 0)
                return;
            string axisXName = Str("szAxisXName");
            string szHeatflow = Str("szHeatflow");
            try
            {
                Pen p = new Pen(Color.Black, 2);
                Brush b = new SolidBrush(Color.Black);
                float mh = 0;
                for (int i = 0; i < RLayers.Count; i++)
                {
                    
                    Rectangle r = RLayers[i];
                    Layer l = Pro.LayerList[i];
                    Point pH = new Point(r.Left, RXAxis.Top+Space);
                    Point pL = new Point(r.Right, RXAxis.Top+Space);
                    Point pH_ = new Point(pH.X, pH.Y + TickLength);
                    Point pL_ = new Point(pL.X, pL.Y + TickLength);
                    Point pS = new Point((pH_.X + pL_.X) / 2, pH_.Y);
                    g.DrawLine(p, pH, pL);
                    g.DrawLine(p, pH, pH_);
                    g.DrawLine(p, pL, pL_);
                    string cs = (l.Thickness*1000).ToString("F0");
                    SizeF sz = g.MeasureString(cs, AxisFont, 0, new StringFormat(StringFormatFlags.DirectionVertical));
                    if (sz.Height > mh)
                        mh = sz.Height;
                    RectangleF rf = new RectangleF(pS.X - sz.Width / 2, pS.Y + Space, sz.Width, sz.Height);
                    g.DrawString(cs, AxisFont, b, rf, new StringFormat(StringFormatFlags.DirectionVertical));
                }
                SizeF sz1= g.MeasureString(axisXName, AxisFont, 0);
                RectangleF rf1 = new RectangleF(RGeo.Left + (RGeo.Width - sz1.Width) / 2, RXAxis.Bottom -sz1.Height, sz1.Width, sz1.Height);
                g.DrawString(axisXName, AxisFont, b, rf1);
                string shf = szHeatflow + Pro.ColdfaceBoundary.Heatflow.ToString("F") + "W";
                sz1 = g.MeasureString(shf, AxisFont, 0);
                rf1= new RectangleF(RGeo.Right-sz1.Width, RXAxis.Bottom - sz1.Height, sz1.Width, sz1.Height);
                Brush b1 = new SolidBrush(Color.Red);
                g.DrawString(shf, AxisFont, b1, rf1);
                p.Dispose();
                b.Dispose();
                b1.Dispose();
            }
            catch(Exception e)
            {
                string s = e.Message;
            }
        }
        protected override void DestroyHandle()
        {
            AxisFont.Dispose();
            NumberFont.Dispose();
            TitleFont.Dispose();
            base.DestroyHandle();
        }
        public void DrawLine(Graphics g)
        {

            if (Pro == null)
                return;
            try
            {
                List<Point> ps = new List<Point>();
                List<string> ss = new List<string>();
                for (int i = 0; i < RLayers.Count; i++)
                {
                    Rectangle r = RLayers[i];
                    Layer l = Pro.LayerList[i];
                    double py = RGeo.Bottom - (l.HighTemperature - this.mint-273.15) / (this.maxt -this.mint) * RGeo.Height;
                    Point p = new Point(r.Left, (int)py);
                    ps.Add(p);
                    ss.Add(GlobalTool.K2C(l.HighTemperature).ToString("f0"));
                    if (i == RLayers.Count - 1)
                    {
                        py = RGeo.Bottom - (l.LowTemperature - this.mint - 273.15) / (this.maxt - this.mint) * RGeo.Height;
                        p = new Point(r.Right, (int)py);
                        ps.Add(p);
                        ss.Add(GlobalTool.K2C(l.LowTemperature).ToString("f0"));
                    }
                }
                Pen pen = new Pen(Color.Yellow, 3);
                Brush b = new SolidBrush(Color.Black);
                SmoothingMode sm = g.SmoothingMode;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                if(ps.Count>=2)
                {
                    g.DrawLines(pen, ps.ToArray());
                    for(int i=0;i<ps.Count;i++)
                    {
                        Point p = ps[i];
                        string s = ss[i];
                        SizeF sz = g.MeasureString(s, NumberFont, 0);
                        p.Y -= (int)(sz.Height + 1);
                        g.DrawString(s, NumberFont, b, p);
                    }
                }
                g.SmoothingMode = sm;
                pen.Dispose();
                b.Dispose();
            }
            catch(Exception e)
            {
                string s = e.Message;
            }

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawGeo(e.Graphics);
            DrawThicknessAxis(e.Graphics);
            DrawTemperatureAxis(e.Graphics);
            DrawLine(e.Graphics);
            DrawTitile(e.Graphics);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (Pro == null)
                return;
            
            if (RGeo.Contains(e.Location))
            {
                this.Cursor = Cursors.Cross;
                string ss = "-";
                if (RHotFace.Contains(e.Location))
                    ss = GlobalTool.K2C(Pro.HotfaceTemperature).ToString("F0")+"℃";
                else
                {
                    ss = PointTemperature(e.Location).ToString("F0")+ "℃";
                }
                Graphics g= this.CreateGraphics();
                Brush b = new SolidBrush(Color.Black);
                Font font = new Font("Arial Unicode MS", 10);
                SizeF sz = g.MeasureString(ss, font, 0);
                PointF pf = new PointF(e.Location.X + 1, e.Location.Y - sz.Height - 1);
                Refresh();
                g.DrawString(ss, font, b, pf);
                font.Dispose();
                b.Dispose();
                g.Dispose();

            }
            else
            {
                this.Cursor = Cursors.Default;
                Refresh();
            }
                
        }
        private double PointTemperature(Point p)
        {
            double t=0;
            if (RColdFace.Contains(p))
            {
                if (Pro.ColdfaceBoundary is Class3Boundary)
                {
                    Class3Boundary b = Pro.ColdfaceBoundary as Class3Boundary;
                    t = b.Temperature - ((double)p.X - (double)RColdFace.Left) / (double)RColdFace.Width * (b.Temperature - b.AmbientTemperature);
                    return GlobalTool.K2C(t);
                }
                else
                    return GlobalTool.K2C(Pro.ColdfaceBoundary.Temperature);
            }
            Layer l = null;
            Rectangle r = new Rectangle();
            for (int i = 0; i < Pro.LayerList.Count; i++)
            {
                if (RLayers[i].Contains(p))
                {
                    r = RLayers[i];
                    l = Pro.LayerList[i];
                }
            }
            if (l == null)
                return 0;
            t = l.HighTemperature - ((double)p.X - (double)r.Left) / (double)r.Width * (l.HighTemperature - l.LowTemperature);
            return GlobalTool.K2C(t);
        }
        public void DrawGeo(Graphics g)
        {
            if (Pro == null)
                return;
            DrawRect(g, RHotFace, COT(Pro.HotfaceTemperature), COT(Pro.HotfaceTemperature),Str("szHotface"));
            for(int i=0;i<Pro.LayerList.Count;i++)
            {
                Layer l = Pro.LayerList[i];
                DrawRect(g, RLayers[i], COT(l.HighTemperature), COT(l.LowTemperature), l.Name);
            }
            Color c1, c2;
            if (Pro.ColdfaceBoundary is Class3Boundary)
            {
                Class3Boundary b = Pro.ColdfaceBoundary as Class3Boundary;
                c1 = COT(b.Temperature);
                c2 = COT(b.AmbientTemperature);
            }
            else
                c1 = c2 = COT(Pro.ColdfaceBoundary.Temperature);
            DrawRect(g, RColdFace, c1, c2, Str("szColdface"));

                
        }
        private void DrawRect(Graphics g, Rectangle r, Color hotColor, Color coldColor)
        {
            Brush b = new LinearGradientBrush(r, hotColor, coldColor, LinearGradientMode.Horizontal);
            using (b)
            {
                g.FillRectangle(b, r);
                g.DrawRectangle(new Pen(Color.White), r);
            }
        }
        private void DrawRect(Graphics g, Rectangle r, Color hotColor, Color coldColor, string vs)
        {
            Brush b = new LinearGradientBrush(r, hotColor, coldColor, LinearGradientMode.Horizontal);
            Brush bs = new SolidBrush(Color.White);
            Font font = new Font("宋体", 9);
            g.FillRectangle(b, r);
            g.DrawRectangle(new Pen(Color.White), r);
            SizeF sz = g.MeasureString(vs, font, 0, new StringFormat(StringFormatFlags.DirectionVertical));
            if (sz.Width < r.Width && sz.Height < r.Height)
            {
                g.DrawString(vs, font, bs, r.Left + (r.Width - sz.Width) / 2, r.Top + (r.Height - sz.Height) / 2, new StringFormat(StringFormatFlags.DirectionVertical));
            }

        }
        private Color COT(double temperature)
        {
            int maxc = MaxColor.ToArgb();
            int minc = MinColor.ToArgb();
            double maxt = this.maxt + 273.15;
            double mint = this.mint + 273.15;
            if(Pro.ColdfaceBoundary is Class3Boundary)
            {
                mint = (Pro.ColdfaceBoundary as Class3Boundary).AmbientTemperature;
            }
            int resc = minc + (int)((temperature - mint) / (maxt - mint) * (maxc - minc));
            return Color.FromArgb(resc);
        }
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            if (Pro == null)
                return;
            if (RHotFace.Contains(e.Location))
            {
                if (OnHotfaceClick != null)
                    OnHotfaceClick();
            }
            else if (RColdFace.Contains(e.Location))
            {
                if (OnColdfaceClick != null)
                    OnColdfaceClick();
            }
            else
            {
                int i = PointLayerIndex(e.Location);
                if(i!=-1&& OnLayerDbClick != null)
                    OnLayerDbClick(i);
            }
        }
        private int PointLayerIndex(Point p)
        {
            int pi = -1;
            for (int i = 0; i < Pro.LayerList.Count; i++)
            {
                if (RLayers[i].Contains(p))
                {
                    pi = i;
                }
            }
            return pi;
        }
        private void DrawTitile(Graphics g)
        {
            string szTitle = Str("szTitle");
            SizeF sf = g.MeasureString(szTitle, TitleFont);
            RectangleF r = new RectangleF(RTitle.Left + (RTitle.Width - sf.Width) / 2, RTitle.Top + (RTitle.Height - sf.Height) / 2, sf.Width, sf.Height);
            Brush b = new SolidBrush(Color.Black);
            g.DrawString(szTitle, TitleFont, b, r);
            b.Dispose();
        }

    }
}
