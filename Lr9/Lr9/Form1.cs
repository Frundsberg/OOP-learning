using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DrawCoordinate();
        }
        private void DrawCoordinate()
        {
            // Визначення середини pictureBox
            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;

            // Координатна шкала
            using (var graphics = pictureBox1.CreateGraphics())
            {
                // Вісь X
                Pen penX = new Pen(Color.Black, 2);
                graphics.DrawLine(penX, 0, centerY, pictureBox1.Width, centerY);

                // Вісь Y
                Pen penY = new Pen(Color.Black, 2);
                graphics.DrawLine(penY, centerX, 0, centerX, pictureBox1.Height);

                // Позначення на вісі X
                int step = 20;
                for (int i = centerX + step; i < pictureBox1.Width; i += step)
                {
                    graphics.DrawString((i - centerX).ToString(), DefaultFont, Brushes.Black, i, centerY + 3);
                }

                for (int i = centerX - step; i >= 0; i -= step)
                {
                    graphics.DrawString((i - centerX).ToString(), DefaultFont, Brushes.Black, i, centerY + 3);
                }

                // Позначення на вісі Y
                for (int i = centerY + step; i < pictureBox1.Height; i += step)
                {
                    graphics.DrawString((centerY - i).ToString(), DefaultFont, Brushes.Black, centerX - 15, i);
                }

                for (int i = centerY - step; i >= 0; i -= step)
                {
                    graphics.DrawString((centerY - i).ToString(), DefaultFont, Brushes.Black, centerX - 15, i);
                }
            }
        }
        // Метод для малювання графіку
        private void DrawGraph()
        {
            double x0 = Convert.ToDouble(txtX0.Text);
            double y0 = Convert.ToDouble(txtY0.Text);
            double R = Convert.ToDouble(txtR.Text);

            using (var graphics = pictureBox1.CreateGraphics())
            {
                // Креслимо графік
                Pen pen = new Pen(Color.Blue, 2);
                double tStep = 0.01;

                for (double t = 0; t <= 2 * Math.PI; t += tStep)
                {
                    double x = x0 + R * Math.Cos(t);
                    double y = y0 - R * Math.Sin(t);
                    int xPixel = (int)(x * 20 + pictureBox1.Width / 2);
                    int yPixel = (int)(pictureBox1.Height / 2 - y * 20);
                    graphics.DrawEllipse(pen, xPixel, yPixel, 1, 1);
                }
            }
        }
        // кнопка що викликає методи
        // для системи координат і графіку
        private void button1_Click(object sender, EventArgs e)
        {
            DrawGraph();
            DrawCoordinate();
         }
}   }




