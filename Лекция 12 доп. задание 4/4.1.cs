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
    g.FillRectangle(Brushes.White, ClientRectangle); 
    theImg = new Bitmap("Star.bmp"); 
    smallImg = new Bitmap(theImg, new Size(theImg.Width/2, theImg.Height/2));
     
    Brush tBrush = new TextureBrush(smallImg, new Rectangle(0,0,smallImg.Width, smallImg.Height)); 
    g.FillEllipse (tBrush, ClientRectangle);
    tBrush.Dispose();
    theImg.Dispose();
    smallImg.Dispose();
        }
    }
}