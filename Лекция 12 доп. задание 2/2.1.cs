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
            SolidBrush mySolidBrush;
            TextureBrush myBrushTexture;
            HatchBrush myHatchBrush;
            LinearGradientBrush myBrushGrad;
            HatchStyle myHatchStyle;
            LinearGradientMode myLinearGradientMode;
            
            Color cl = Color.FromArgb(255, 255, 255);
            g.Clear(cl);
            Pen myPen = new Pen(Color.Black, 1);
            mySolidBrush = new SolidBrush(Color.Silver);
            // Рисование сплошной кистью

          
            g.FillRectangle(mySolidBrush, 10, 10, 390, 250);

            // рисование кистью со стандартными стилями

            myHatchStyle = HatchStyle.Cross;
            myHatchBrush = new HatchBrush(myHatchStyle, myPen.Color, mySolidBrush.Color);
            g.FillRectangle(myHatchBrush, 10, 10, 390, 250);

            // рисование кистью с градиентной заливкой

            myLinearGradientMode = LinearGradientMode.Horizontal;
            Rectangle r = new Rectangle(10, 10, 390, 250);
             myBrushGrad = new LinearGradientBrush(r, Color.White, Color.Gray, myLinearGradientMode);
            g.FillRectangle(myBrushGrad, r);

            //рисование текстурной кистью

              myBrushTexture = new TextureBrush(new Bitmap(@"d://T.bmp"));
            g.FillRectangle(myBrushTexture,
             new Rectangle(10, 10, 390, 250));

        }
    }
}