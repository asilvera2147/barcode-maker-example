using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_barcode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(txt_barcode.Text,100);
        }

        private void btn_qrCode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrCode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrCode.Draw(txt_barcode.Text,16);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap s = new Bitmap(pictureBox1.Image);
            s.Save("Saves/"+txt_barcode.Text+".png");
        }
    }
}
