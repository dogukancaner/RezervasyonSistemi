using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bilgiler.Items.Add("Kalkış: " + comboBox1.Text + " Varış: " + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Saat: "+ maskedTextBox1.Text + " Yolcu Bilgiler -- Ad: "+textBox1.Text+" T.C: "+maskedTextBox2.Text+" Telefon: "+maskedTextBox3.Text);
            MessageBox.Show("Kayıt Başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
