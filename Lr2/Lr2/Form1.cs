using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//обробка вхідних данних
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double rad = Convert.ToDouble(textBox3.Text);
            double scale = Convert.ToDouble(textBox4.Text);
            double move_x = Convert.ToDouble(textBox9.Text);
            double move_y = Convert.ToDouble(textBox10.Text);
            Circle circle = new Circle(x, y, rad);//створення нового круга
            try
            {

                label5.Text = Convert.ToString(circle.Area());//виклик методів для визначення площі переміщення і зміни розміру
                circle.Move(move_x, move_y);
                circle.Scale(scale);
                label14.Text = Convert.ToString(circle.getx());// виведення результату за допомогою гетерів
                label15.Text = Convert.ToString(circle.gety());
                label18.Text = Convert.ToString(circle.getr());

            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)// обробка вхідних данних
        {
            double x = Convert.ToDouble(textBox5.Text);
            double y = Convert.ToDouble(textBox6.Text);
            double size = Convert.ToDouble(textBox7.Text);
            double scale = Convert.ToDouble(textBox8.Text);
            double move_x = Convert.ToDouble(textBox11.Text);
            double move_y = Convert.ToDouble(textBox12.Text);
            Square square = new Square(x, y, size);// створення нового квадрата
            try
            {

                label27.Text = Convert.ToString(square.Area());// виклик методів для знаходження площі переміщення і зміни розміру
                square.Move(move_x, move_y);
                square.Scale(scale);
                label25.Text = Convert.ToString(square.getx());// виведення результатів
                label26.Text = Convert.ToString(square.gety());
                label28.Text = Convert.ToString(square.get_size());



            }

            catch { }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox13.Text); // введення вхідних данних
            double y = Convert.ToDouble(textBox14.Text);
            double width = Convert.ToDouble(textBox15.Text);
            double height = Convert.ToDouble(textBox16.Text);
            double move_x = Convert.ToDouble(textBox18.Text);
            double move_y = Convert.ToDouble(textBox19.Text);
            double scale = Convert.ToDouble(textBox20.Text);
            double R_angle = Convert.ToDouble(textBox17.Text);

            Rectangle rectangle = new Rectangle(x, y, width, height);// створення нового квадрата
            try
            {
 
                rectangle.Move(move_x, move_y); //виклик методів для знаходження площі переміщення і зміни розміру
                rectangle.Scale(scale);
                rectangle.Rotate(R_angle);// метод для повороту
                label46.Text = Convert.ToString(rectangle.getx());// виведення результатів
                label47.Text = Convert.ToString(rectangle.gety());
                label48.Text = Convert.ToString(rectangle.getw());
                label49.Text = Convert.ToString(rectangle.geth());
                label51.Text = Convert.ToString(rectangle.Area());
            }
            catch { }
        }
}    }

        
    





