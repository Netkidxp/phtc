using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHTC
{
    public partial class PictureComboBox : ComboBox
    {
        public ImageList ItemImageList { get; set; }
        public PictureComboBox()
        {
            InitializeComponent();
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            //base.OnDrawItem(e);
            if(ItemImageList==null)
            {
                base.OnDrawItem(e);
            }
            else
            {
                Graphics g = e.Graphics;
                Rectangle r = e.Bounds;
                Rectangle rs = new Rectangle(r.Left + ItemHeight, r.Top, r.Width - ItemHeight, r.Height);
                Size imageSize = ItemImageList.ImageSize;
                Pen pb = new Pen(Color.Black, 2);
                Pen pw = new Pen(Color.White, 2);
                Brush b = new SolidBrush(base.ForeColor);
                if (e.Index >= 0)
                {
                    if (e.State == (DrawItemState.NoAccelerator | DrawItemState.NoFocusRect))
                    {
                        //画条目背景 
                        //e.Graphics.FillRectangle(new SolidBrush(Color.Red), r);
                        //绘制图像 
                        if (e.Index < ItemImageList.Images.Count)
                        {
                            ItemImageList.Draw(e.Graphics, r.Left, r.Top, e.Index);
                        }
                        //显示取得焦点时的虚线框 
                        e.DrawFocusRectangle();
                        g.DrawRectangle(pw, r);
                    }
                    else
                    {
                        //e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), r);
                        
                        if (e.Index < ItemImageList.Images.Count)
                        {
                            ItemImageList.Draw(e.Graphics, r.Left, r.Top, e.Index);
                        }
                        e.DrawFocusRectangle();
                        g.DrawRectangle(pb, r);
                    }
                    g.DrawString((string)base.Items[e.Index], base.Font, b, rs);
                }
                pb.Dispose();
                pw.Dispose();
                b.Dispose();
            }
        }
    }
}
