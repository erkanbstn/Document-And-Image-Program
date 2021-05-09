using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_Resim_İşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string img;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            img = openFileDialog1.FileName;
            pictureBox1.ImageLocation = img;


        }
        Color clr;
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            clr = colorDialog1.Color;
        }
        Bitmap bmp;
        private void simpleButton4_Click(object sender, EventArgs e)
        {
           
            bmp = new Bitmap(img);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawString(textEdit1.Text, new Font("Segoe UI ",Convert.ToInt32(textEdit2.Text),FontStyle.Bold),new SolidBrush(clr),20,30);
            pictureBox1.Image = bmp;
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Picture|.jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
