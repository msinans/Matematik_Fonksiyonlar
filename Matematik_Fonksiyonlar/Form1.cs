using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Fonksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToString().Replace('.', ',');
            double sayi = Convert.ToDouble(textBox1.Text);
            //label2.Text = Math.Abs(sayi).ToString(); 
            //label2.Text = Math.Ceiling(sayi).ToString();
            label2.Text = Math.Floor(sayi).ToString();
            //label2.Text = Math.Pow(sayi, 3).ToString();
            //label2.Text = Math.Sqrt(sayi).ToString();
            //label2.Text = Math.PI.ToString();

            // Abs = Mutlak Değer,
            // Ceiling = Yukarı Yuvarlar
            // Floor = Aşağı Yuvarlar
            // Pow = Üslü olarak çarpar (ikinci parametere üs olarak atanır)
            // Sqrt = Karekök Alır

        }
    }
}
