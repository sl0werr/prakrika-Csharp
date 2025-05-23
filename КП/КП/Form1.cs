using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace КП
{
    public partial class Form1 : Form
    {

        private void MakeButtonRound(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void SetImageOpacity(PictureBox pictureBox, float opacity)
        {
            if (pictureBox.Image == null) return;

            // Создаем временный Bitmap для работы с прозрачностью
            Bitmap bmp = new Bitmap(pictureBox.Image.Width, pictureBox.Image.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Создаем матрицу для изменения прозрачности
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity; // Устанавливаем уровень прозрачности (0.0 - 1.0)

                // Применяем матрицу к изображению
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                // Рисуем изображение с новой прозрачностью
                g.DrawImage(
                    pictureBox.Image,
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, bmp.Width, bmp.Height,
                    GraphicsUnit.Pixel,
                    attributes);
            }

            // Обновляем изображение в PictureBox
            pictureBox.Image = bmp;
        }
    

    public Form1()
        {
            InitializeComponent();

            this.Text = "AutoGuide Pro";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;


            //this.DoubleBuffered = true;


        }
        private void InitializeNavigationPanel()
        {
            var navPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(20, 20, 25)
            };

            // Логотип
            this.Controls.Add(navPanel);
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // Увеличиваем на 10% при наведении
            pictureBox1.Size = new Size(
                (int)(pictureBox1.Width * 1.1),
                (int)(pictureBox1.Height * 1.1)
            );
            pictureBox1.Top -= (int)(pictureBox1.Height * 0.05); // Центрируем
            pictureBox1.Left -= (int)(pictureBox1.Width * 0.05);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            // Возвращаем исходный размер
            pictureBox1.Size = new Size(
                (int)(pictureBox1.Width / 1.1),
                (int)(pictureBox1.Height / 1.1)
            );
            pictureBox1.Top += (int)(pictureBox1.Height * 0.05);
            pictureBox1.Left += (int)(pictureBox1.Width * 0.05);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form2 secondaryform = new Form2();
            this.Hide();
            secondaryform.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            this.Hide();
            form6.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
