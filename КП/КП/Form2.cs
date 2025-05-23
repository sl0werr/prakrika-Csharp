using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КП
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            guna2PictureBox2.BringToFront();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            guna2PictureBox3.BringToFront();

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            guna2PictureBox4.BringToFront();

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            guna2PictureBox5.BringToFront();

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            guna2PictureBox6.BringToFront();
        }

        private void guna2CustomRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            guna2PictureBox7.BringToFront();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Form1 mainform = new Form1();
            this.Close();
            mainform.Show();
        }
        public event Action<string> UrlRequested;

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (guna2CustomRadioButton1.Checked==false && guna2CustomRadioButton2.Checked == false && guna2CustomRadioButton3.Checked == false && guna2CustomRadioButton4.Checked == false && guna2CustomRadioButton5.Checked == false && guna2CustomRadioButton6.Checked == false)
            { MessageBox.Show("Пожалуйста, выберите одну из систем автомобиля."); }
            if (guna2CustomRadioButton1.Checked == true)
            {
                DataBank.PathFile = Path.Combine(Application.StartupPath, "Системы\\Кузов.html");
            }
            if (guna2CustomRadioButton2.Checked == true)
            {
                DataBank.PathFile = Path.Combine(Application.StartupPath, "Системы\\Двигатель.html");
            }
            if (guna2CustomRadioButton3.Checked == true)
            {
                DataBank.PathFile = Path.Combine(Application.StartupPath, "Системы\\Трансмиссия.html");
            }
            if (guna2CustomRadioButton4.Checked == true)
            {
                DataBank.PathFile = Path.Combine(Application.StartupPath, "Системы\\Ходовая.html");
            }
            if (guna2CustomRadioButton5.Checked == true)
            {
                DataBank.PathFile = Path.Combine(Application.StartupPath, "Системы\\Управление.html");
            }
            if (guna2CustomRadioButton6.Checked == true)
            {
                DataBank.PathFile = Path.Combine(Application.StartupPath, "Системы\\Электро.html");
            }
            Form4 form4 = new Form4();
            this.Close();
            form4.Show();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
