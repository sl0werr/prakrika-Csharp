using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КП
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void guna2Panel2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox1.SelectedIndex == 1) {
                BMW.Visible = true;
                Chevrolet.Visible = false;
                FIAT.Visible = false;
                Ford.Visible = false;
                Honda.Visible = false;
                Hundai.Visible = false;
                INFINITY.Visible = false;
                Jaguar.Visible = false;
                Jeep.Visible = false;
                KIA.Visible = false;
                Rover.Visible = false;
                Lexus.Visible = false;
                Mazda.Visible = false;
                Mercedes.Visible = true;
                Mitsubishi.Visible = false;
                Nissan.Visible = false;
                Opel.Visible = true;
                Peugeot.Visible = false;
                Porshe.Visible = true;
                Renault.Visible = false;
                Skoda.Visible = false;
                Subaru.Visible = false; 
                Suzuki.Visible = false;
                Toyota.Visible = false;
                Volvo.Visible = true;
                VW.Visible = true;
                Audi.Visible = true;
            }
            if (guna2ComboBox1.SelectedIndex == 2)
            {
                BMW.Visible = false;
                Chevrolet.Visible = false;
                FIAT.Visible = false;
                Ford.Visible = false;
                Honda.Visible = false;
                Hundai.Visible = false;
                INFINITY.Visible = false;
                Jaguar.Visible = false;
                Jeep.Visible = false;
                KIA.Visible = false;
                Rover.Visible = false;
                Lexus.Visible = false;
                Mazda.Visible = false;
                Mercedes.Visible = false;
                Mitsubishi.Visible = false;
                Nissan.Visible = false;
                Opel.Visible = false;
                Peugeot.Visible = true;
                Porshe.Visible = false;
                Renault.Visible = true;
                Skoda.Visible = false;
                Subaru.Visible = false;
                Suzuki.Visible = false;
                Toyota.Visible = false;
                Volvo.Visible = false;
                VW.Visible = false;
                Audi.Visible = false;
            }
            if (guna2ComboBox1.SelectedIndex == 3)
            {
                BMW.Visible = false;
                Chevrolet.Visible = true;
                FIAT.Visible = false;
                Ford.Visible = true;
                Honda.Visible = false;
                Hundai.Visible = false;
                INFINITY.Visible = false;
                Jaguar.Visible = false;
                Jeep.Visible = true;
                KIA.Visible = false;
                Rover.Visible = true;
                Lexus.Visible = false;
                Mazda.Visible = false;
                Mercedes.Visible = false;
                Mitsubishi.Visible = false;
                Nissan.Visible = false;
                Opel.Visible = false;
                Peugeot.Visible = false;
                Porshe.Visible = false;
                Renault.Visible = false;
                Skoda.Visible = false;
                Subaru.Visible = false;
                Suzuki.Visible = false;
                Toyota.Visible = false;
                Volvo.Visible = false;
                VW.Visible = false;
                Audi.Visible = false;
            }
            if (guna2ComboBox1.SelectedIndex == 4)
            {
                BMW.Visible = false;
                Chevrolet.Visible = false;
                FIAT.Visible = true;
                Ford.Visible = false;
                Honda.Visible = false;
                Hundai.Visible = false;
                INFINITY.Visible = false;
                Jaguar.Visible = false;
                Jeep.Visible = false;
                KIA.Visible = false;
                Rover.Visible = false;
                Lexus.Visible = false;
                Mazda.Visible = false;
                Mercedes.Visible = false;
                Mitsubishi.Visible = false;
                Nissan.Visible = false;
                Opel.Visible = false;
                Peugeot.Visible = false;
                Porshe.Visible = false;
                Renault.Visible = false;
                Skoda.Visible = false;
                Subaru.Visible = false;
                Suzuki.Visible = false;
                Toyota.Visible = false;
                Volvo.Visible = false;
                VW.Visible = false;
                Audi.Visible = false;
            }
            if (guna2ComboBox1.SelectedIndex == 5)
            {
                BMW.Visible = false;
                Chevrolet.Visible = false;
                FIAT.Visible = false;
                Ford.Visible = false;
                Honda.Visible = true;
                Hundai.Visible = false;
                INFINITY.Visible = true;
                Jaguar.Visible = false;
                Jeep.Visible = false;
                KIA.Visible = false;
                Rover.Visible = false;
                Lexus.Visible = true;
                Mazda.Visible = true;
                Mercedes.Visible = false;
                Mitsubishi.Visible = true;
                Nissan.Visible = true;
                Opel.Visible = false;
                Peugeot.Visible = false;
                Porshe.Visible = false;
                Renault.Visible = false;
                Skoda.Visible = false;
                Subaru.Visible = false;
                Suzuki.Visible = true;
                Toyota.Visible = true;
                Volvo.Visible = false;
                VW.Visible = false;
                Audi.Visible = false;
            }
            if (guna2ComboBox1.SelectedIndex == 6)
            {
                BMW.Visible = false;
                Chevrolet.Visible = false;
                FIAT.Visible = false;
                Ford.Visible = false;
                Honda.Visible = false;
                Hundai.Visible = true;
                INFINITY.Visible = false;
                Jaguar.Visible = false;
                Jeep.Visible = false;
                KIA.Visible = true;
                Rover.Visible = false;
                Lexus.Visible = false;
                Mazda.Visible = false;
                Mercedes.Visible = false;
                Mitsubishi.Visible = false;
                Nissan.Visible = false;
                Opel.Visible = false;
                Peugeot.Visible = false;
                Porshe.Visible = false;
                Renault.Visible = false;
                Skoda.Visible = false;
                Subaru.Visible = false;
                Suzuki.Visible = false;
                Toyota.Visible = false;
                Volvo.Visible = false;
                VW.Visible = false;
                Audi.Visible = false;
            }
            if (guna2ComboBox1.SelectedIndex == 7)
            {
                BMW.Visible = false;
                Chevrolet.Visible = false;
                FIAT.Visible = false;
                Ford.Visible = false;
                Honda.Visible = false;
                Hundai.Visible = false;
                INFINITY.Visible = false;
                Jaguar.Visible = true;
                Jeep.Visible = false;
                KIA.Visible = false;
                Rover.Visible = false;
                Lexus.Visible = false;
                Mazda.Visible = false;
                Mercedes.Visible = false;
                Mitsubishi.Visible = false;
                Nissan.Visible = false;
                Opel.Visible = false;
                Peugeot.Visible = false;
                Porshe.Visible = false;
                Renault.Visible = false;
                Skoda.Visible = false;
                Subaru.Visible = false;
                Suzuki.Visible = false;
                Toyota.Visible = false;
                Volvo.Visible = false;
                VW.Visible = false;
                Audi.Visible = false;
            }
            if (guna2ComboBox1.SelectedIndex == 8)
            {
                BMW.Visible = false;
                Chevrolet.Visible = false;
                FIAT.Visible = false;
                Ford.Visible = false;
                Honda.Visible = false;
                Hundai.Visible = false;
                INFINITY.Visible = false;
                Jaguar.Visible = false;
                Jeep.Visible = false;
                KIA.Visible = false;
                Rover.Visible = false;
                Lexus.Visible = false;
                Mazda.Visible = false;
                Mercedes.Visible = false;
                Mitsubishi.Visible = false;
                Nissan.Visible = false;
                Opel.Visible = false;
                Peugeot.Visible = false;
                Porshe.Visible = false;
                Renault.Visible = false;
                Skoda.Visible = true;
                Subaru.Visible = false;
                Suzuki.Visible = false;
                Toyota.Visible = false;
                Volvo.Visible = false;
                VW.Visible = false;
                Audi.Visible = false;
            }
            if (guna2ComboBox1.SelectedIndex == 0)
            {
                BMW.Visible = true;
                Chevrolet.Visible = true;
                FIAT.Visible = true;
                Ford.Visible = true;
                Honda.Visible = true;
                Hundai.Visible = true;
                INFINITY.Visible = true;
                Jaguar.Visible = true;
                Jeep.Visible = true;
                KIA.Visible = true;
                Rover.Visible = true;
                Lexus.Visible = true;
                Mazda.Visible = true;
                Mercedes.Visible = true;
                Mitsubishi.Visible = true;
                Nissan.Visible = true;
                Opel.Visible = true;
                Peugeot.Visible = true;
                Porshe.Visible = true;
                Renault.Visible = true;
                Skoda.Visible = true;
                Subaru.Visible = true;
                Suzuki.Visible = true;
                Toyota.Visible = true;
                Volvo.Visible = true;
                VW.Visible = true;
                Audi.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();
        }

        private void Chevrolet_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Chevrolet.htm");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void BMW_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\BMW.htm");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void FIAT_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\FIAT.htm");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Ford_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Ford.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Honda_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Honda.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Hundai_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Hundai.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void INFINITY_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\INFINITY.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Jaguar_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Jaguar.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Jeep_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Jeep.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void KIA_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\KIA.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Rover_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Rover.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Lexus_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Lexus.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Mazda_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Mazda.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Mercedes_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Mercedes.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Mitsubishi_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Mitsubishi.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Nissan_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Nissan.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Opel_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Opel.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Peugeot_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Peugeot.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Porshe_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Porshe.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Renault_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Renault.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Skoda_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Skoda.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Subaru_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Subaru.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Suzuki_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Suzuki.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Toyota_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Toyota.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Volvo_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Volvo.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void VW_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\VW.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }

        private void Audi_Click(object sender, EventArgs e)
        {
            DataBank.PathFile2 = Path.Combine(Application.StartupPath, "Марки\\Audi.html");
            Form5 form5 = new Form5();
            this.Close();
            form5.Show();
        }
    }
}
