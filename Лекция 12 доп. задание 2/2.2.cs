using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace lektsia_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
       

                Color cl = Color.FromArgb(255, 255, 255);
                g.Clear(cl);
                Pen myPen = new Pen(Color.Black, 1);

                Point[] p = {
    new Point() {X=20, Y=60},
    new Point() {X=60, Y=40},
    new Point() {X=120, Y=20},
    new Point() {X=200, Y=40},
    new Point() {X=160, Y=60},
    new Point() {X=120, Y=100},
    new Point() {X=40, Y=80},
    };

                TextureBrush myBrushTexture = new TextureBrush(new Bitmap(@"d://Help.bmp"));
                // полигон 
               // g.FillPolygon(myBrushTexture, p);
               // g.DrawPolygon(myPen, p);

               
                // замкнутая фундаментальная линия
               // 
                float tension = 0.5F;
               // g.FillClosedCurve(myBrushTexture, p, FillMode.Alternate, tension);
               // g.DrawClosedCurve(myPen, p, tension, FillMode.Alternate);
               
                // фундаментальная линия с поверотом на 90 
                
                myBrushTexture.RotateTransform(90);
                g.FillClosedCurve(myBrushTexture, p, FillMode.Winding, tension);
                g.DrawClosedCurve(myPen, p, tension, FillMode.Alternate);
     
        }
    }
}