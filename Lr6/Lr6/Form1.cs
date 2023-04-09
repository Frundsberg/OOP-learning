using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            e.Handled = true; // інші символи заборонені

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            e.Handled = true; // інші символи заборонені

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
            e.Handled = true; // інші символи заборонені



        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a; // оголошення вхідних змінних
            double b;
            double c;
            double p;
            double res; //змінна результату

            // Якщо у полі редагування немає даних,
            // то при спробі перетворити порожні
            // рядки у число виникає виняток. 
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
                {
                    throw new ArgumentException("Трикутник з такими сторонами не можливий");
                }
                // при введенні некоректних значень (0 або коли сума двох сторін більше за третю)
                // генерується виключення
                p = (a + b + c) / 2; //напівпериметр 
                res = Math.Sqrt(p * (p - a) * (p - b) * (p - c));//площа за формулою Герона
                label5.Text = res.ToString();// приведення до рядкового значення і виведенні результату
            }
            catch (ArgumentException ex)
            // обробка виключення:
            // перемістити курсор в поле редагування
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, ex.Message);
                errorProvider1.SetError(textBox2, ex.Message);
                errorProvider1.SetError(textBox3, ex.Message);
              
            }
        }
    }
}
