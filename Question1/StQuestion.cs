using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question1
{
    public partial class StQuestion : Form
    {
        private Timer moveButtonTimer; // Таймер для руху кнопки
        private int moveStepX; // Крок переміщення по X
        private int moveStepY; // Крок переміщення по Y
        private Random random = new Random();
        public StQuestion()
        {
            InitializeComponent();

            // Налаштування таймера
            moveButtonTimer = new Timer();
            moveButtonTimer.Interval = 50; // Інтервал у мілісекундах
            moveButtonTimer.Tick += MoveButtonTimer_Tick;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Обробник події натискання кнопки "Так"
        private void btYes_Click(object sender, EventArgs e)
         {
            MessageBox.Show("Ми так і думали.");
         }

        // Обробник події наведення миші на кнопку "Ні"
        private void btNo_MouseEnter(object sender, EventArgs e)
        {
            // Генерація випадкового напрямку руху
            moveStepX = random.Next(-10, 11); // Рух по X (від -10 до 10)
            moveStepY = random.Next(-10, 11); // Рух по Y (від -10 до 10)

            // Запуск таймера для початку руху кнопки
            moveButtonTimer.Start();
        }

        // Обробник події для таймера
        private void MoveButtonTimer_Tick(object sender, EventArgs e)
        {
            // Отримуємо поточне місцезнаходження кнопки
            Point currentLocation = btNo.Location;

            // Обчислюємо нові координати
            int newX = currentLocation.X + moveStepX;
            int newY = currentLocation.Y + moveStepY;

            // Перевіряємо, щоб кнопка не виходила за межі форми
            if (newX < 0) newX = 0;
            if (newY < 0) newY = 0;
            if (newX + btNo.Width > this.ClientSize.Width)
                newX = this.ClientSize.Width - btNo.Width;
            if (newY + btNo.Height > this.ClientSize.Height)
                newY = this.ClientSize.Height - btNo.Height;

            // Переміщуємо кнопку на нове місце
            btNo.Location = new Point(newX, newY);

            // Зупиняємо таймер, якщо кнопка досягла краю
            if (newX == 0 || newY == 0 || newX == this.ClientSize.Width - btNo.Width || newY == this.ClientSize.Height - btNo.Height)
            {
                moveButtonTimer.Stop();
            }
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ухти, спіймав!");
        }
    }
}
