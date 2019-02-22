using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TragaperrasDeluxe
{
    public partial class Form1 : Form
    {
        //Variables
        Random r = new Random();
        string[] valores = { "cherry.png", "grape.png", "lemon.png", "melon.png", "orange.png", "seven.png" };
        int[] premios = { 100, 200, 300, 400, 500, 1000 };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] res = new int[3];
            for (int i = 0; i < 3; i++)
            {
                res[i] = r.Next(valores.Length);
            }
            pictureBox1.ImageLocation = valores[res[0]];
            pictureBox2.ImageLocation = valores[res[1]];
            pictureBox3.ImageLocation = valores[res[2]];
        }
    }
}
