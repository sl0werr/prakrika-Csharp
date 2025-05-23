using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КП
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            webBrowser1.Navigate(DataBank.PathFile2);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Ждем полной загрузки
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                // Проверяем существование функции
                object result = webBrowser1.Document.InvokeScript("eval",
                    new object[] { "typeof toggleAnswer === 'function'" });

                if (result is bool && (bool)result)
                {
                    // Функция существует
                }
                else
                {
                    // Восстанавливаем функцию
                    InjectJavaScript();
                }
            }
        }

        private void InjectJavaScript()
        {
            string js = @"
        function toggleAnswer(id) {
            var answer = document.getElementById('answer' + id);
            if (answer) {
                answer.style.display = answer.style.display === 'block' ? 'none' : 'block';
            }
        }";

            webBrowser1.Document.InvokeScript("eval", new object[] { js });
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Close();
            form3.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
