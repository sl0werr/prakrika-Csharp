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
    public partial class Form6 : Form
    {
        Form1 mainForm;
        public Form6(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            LoadFAQ();
            webBrowser1.AllowWebBrowserDrop = false;
            webBrowser1.IsWebBrowserContextMenuEnabled = false;
            webBrowser1.WebBrowserShortcutsEnabled = false;
            webBrowser1.ScriptErrorsSuppressed = true; // Отключаем сообщения об ошибках JS

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

        private void LoadFAQ()
        {
            string htmlPath = Path.Combine(Application.StartupPath, "faq.html");

            if (File.Exists(htmlPath))
            {
                string htmlContent = File.ReadAllText(htmlPath);
                webBrowser1.DocumentText = htmlContent;
            }
            else
            {
                webBrowser1.DocumentText = "<h1>Файл FAQ не найден!</h1>";
            }

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            mainForm.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }
    }
}
