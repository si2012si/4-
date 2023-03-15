using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private void DrawShapes(Graphics g)
        {
            // Создаем объекты кисти и пера
            Brush brush = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Blue, 2);
            // Создаем случайные координаты и размер фигур
            Random random = new Random();
            int x = random.Next(panel1.Width);
            int y = random.Next(panel1.Height);
            int size = random.Next(50, 100);
            // Отрисовываем эллипс
            g.FillEllipse(brush, x, y, size, size);
            g.DrawEllipse(pen, x, y, size, size);
            // Создаем новые координаты и размер фигур
            x = random.Next(panel1.Width);
            y = random.Next(panel1.Height);
            int width = random.Next(50, 100);
            int height = random.Next(50, 100);
            // Отрисовываем прямоугольник
            g.FillRectangle(brush, x, y, width, height);
            g.DrawRectangle(pen, x, y, width, height);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем объект графики для отрисовки на панели
            Graphics g = panel1.CreateGraphics();
            // Очищаем панель перед отрисовкой
            g.Clear(Color.White);
            // Отрисовываем 10 случайных фигур
            for (int i = 0; i < 10; i++)
            {
                DrawShapes(g);
            }
        }
    }
}
