using System;
using System.Windows.Forms;

namespace BallGame
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        // Конструктор
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів
        }

        /// <summary>
        /// Вимкнення використовуваних ресурсів.
        /// </summary>
        /// <param name="disposing">True, якщо викликається з методами очищення ресурсів.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing); // Завжди викликаємо базовий метод Dispose
        }

        #region Код, що генерується Visual Studio

        /// <summary>
        /// Необхідний метод для підтримки конструктора форми.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout(); // Викликається для тимчасового вимкнення оновлень UI
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 500); // Розмір форми
            this.Name = "Form1";
            this.Text = "Ball Game"; // Заголовок форми
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint); // Обробка події Paint
            this.ResumeLayout(false); // Відновлюється оновлення UI
        }

        #endregion

        // Обробник події Paint
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Тут можна малювати на формі
            e.Graphics.Clear(System.Drawing.Color.White); // Очищення форми білим кольором
            e.Graphics.DrawString("Ball Game", new System.Drawing.Font("Arial", 16), System.Drawing.Brushes.Black, 100, 100);
        }
    }
}
