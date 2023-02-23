using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void text_Box1KeyPress(object sender, KeyPressEventArgs e)
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
            double res; //змінна результату

            // Якщо у полі редагування немає даних,
            // то при спробі перетворити порожні
            // рядки у число виникає виняток. 
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                // обрахування результату
                res = b + Math.Sqrt(Math.Pow(b, 2) + 4 * a * c) / (2 * a) - Math.Pow(a, 3) * c + Math.Pow(b, -2);

                label4.Text = res.ToString("n");//приведення в рядкову вличину і виведення результату обчислень
            }

            catch
            // обробка виключення:
            // перемістити курсор в поле редагування
            {
                textBox1.Focus();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            int CurHours; // оголошення вхідних змінних (поточний час)
            int CurMinutes;
            int CurSeconds;
            int Hours; // оголошення вхідних змінних (час що треба додати)
            int Minutes;
            int Seconds;
            int NewHours; // змінні результату
            int NewMinutes;
            int NewSeconds;




            // Якщо у полі редагування немає даних,
            // то при спробі перетворити порожні
            // рядки у число виникає виняток. 
            try
            {
                CurHours = Convert.ToInt16(textBox4.Text);
                CurMinutes = Convert.ToInt16(textBox5.Text);
                CurSeconds = Convert.ToInt16(textBox6.Text);
                Hours = Convert.ToInt16(textBox7.Text);
                Minutes = Convert.ToInt16(textBox8.Text);
                Seconds = Convert.ToInt16(textBox9.Text);
                // обмеження на введення 
                if ((CurHours < 0) && (CurHours > 24) && (CurMinutes < 0) && (CurMinutes > 59) && (CurSeconds < 0) && (CurSeconds > 59))
                {
                    label18.Text = "Entering Eror";//Помилка введення                   
                }
                NewSeconds = (CurSeconds + Seconds) % 60; // нові секунди
                int addMinutes = (CurSeconds + Seconds) / 60; // кількість хвилин, що потрібно додати
                NewMinutes = (CurMinutes + Minutes + addMinutes) % 60; // нові хвилини
                int addHours = (CurMinutes + Minutes + addMinutes) / 60; // кількість годин, що потрібно додати
                NewHours = (CurHours + Hours + addHours) % 24; // нові години
                label15.Text = NewHours.ToString("D") + ":" + NewMinutes.ToString("D") + ":" + NewSeconds.ToString("D"); // виведення результату
            }
            catch
            // обробка виключення:
            // перемістити курсор в поле редагування
            {
                textBox1.Focus();
            }
        }
        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
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
        private void button3_Click(object sender, EventArgs e)
        {
            // Вхідні дані
            int num; // чотиризначне число
            try
            {
                num = Convert.ToInt32(textBox10.Text);
                if (num < 1000 || num > 9999)
                {
                    label14.Text = ("Entering eror");//помилка якщо число не чотирьохзначне
                }
                else
                {
                    // Обчислення перших та останніх цифр
                    int a = num / 1000;
                    int b = num / 100 % 10;
                    int c = num / 10 % 10;
                    int d = num % 10;
                    if ((a + b) == (c + d)) // перевірка на сумарність
                    {
                        label14.Text = ("True"); //виведення результату
                    }
                    else
                    {
                        label14.Text = ("False");
                    }

                }
            }

            catch
            // обробка виключення:
            // перемістити курсор в поле редагування
            {
                textBox1.Focus();
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int month = 0;
                int day = Convert.ToInt32(textBox11.Text);
                if ((day > 365) || (day < 0)) // обробка номера дня 
                {
                    label21.Text = ("Eror of entering");//помилка введення
                }
                else
                {
                    int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    switch (day)  // Визначаємо номер місяця за номером дня
                    {
                        case int n when (n >= 1 && n <= 31):
                            month = 1;
                            break;
                        case int n when (n >= 32 && n <= 59):
                            month = 2;
                            day -= 31;
                            break;
                        case int n when (n >= 60 && n <= 90):
                            month = 3;
                            day -= 59;
                            break;
                        case int n when (n >= 91 && n <= 120):
                            month = 4;
                            day -= 90;
                            break;
                        case int n when (n >= 121 && n <= 151):
                            month = 5;
                            day -= 120;
                            break;
                        case int n when (n >= 152 && n <= 181):
                            month = 6;
                            day -= 151;
                            break;
                        case int n when (n >= 182 && n <= 212):
                            month = 7;
                            day -= 181;
                            break;
                        case int n when (n >= 213 && n <= 243):
                            month = 8;
                            day -= 212;
                            break;
                        case int n when (n >= 244 && n <= 273):
                            month = 9;
                            day -= 243;
                            break;
                        case int n when (n >= 274 && n <= 304):
                            month = 10;
                            day -= 273;
                            break;
                        case int n when (n >= 305 && n <= 334):
                            month = 11;
                            day -= 304;
                            break;
                        case int n when (n >= 335 && n <= 365):
                            month = 12;
                            day -= 334;
                            break;
                    }
                    label21.Text = ("Mounth " + month + " Day " + day);//Виведення результату

                }

            }
            catch
            // обробка виключення:
            // перемістити курсор в поле редагування
            {
                textBox1.Focus();
            }

        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBox12.Text);
                // Ініціалізація змінної, яка міститиме результат перевірки
                bool isDistinct = true;

                // Перетворення числа n у рядок, щоб легше було розбити його на окремі цифри
                string nStr = n.ToString();

                // Перевірка, чи всі цифри числа різні
                for (int i = 0; i < nStr.Length - 1; i++) 
                    //цикли порівнюють цифри кожна з кожною, якщо дві цифри різні то 
                    //булева змінна isDistinct=false і цикли прериваються 
                {
                    for (int j = i + 1; j < nStr.Length; j++)
                    {
                        if (nStr[i] == nStr[j])
                        {
                            isDistinct = false;
                            break;
                        }
                    }
                    if (!isDistinct)
                    {
                        break;
                    }
                }
                label23.Text = Convert.ToString(isDistinct);


            }
            catch
            // обробка виключення:
            // перемістити курсор в поле редагування
            {
                textBox1.Focus();
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(textBox13.Text);
                int[] X = new int[N]; // створення масиву розміру N

                // заповнення масиву X введенням користувача
                for (int y = 0; y < N; y++)
                {
             
                    X[y] = int.Parse(textBox14.Text);
                }

                // перестановка елементів масиву у зворотному порядку
                int i = 0; // індекс початку масиву
                int j = N - 1; // індекс кінця масиву
                while (i < j) // поки індекс початку менший за індекс кінця
                {
                    // обмін значень елементів з індексами i та j
                    int temp = X[i];
                    X[i] = X[j];
                    X[j] = temp;
                    // зміщення індексів
                    i++;
                    j--;
                }

                // виведення масиву
                for (int k = 0; k < N; k++)
                {
                    label26.Text = (X[k] + " ");
                }

            }
            catch
            // обробка виключення:
            // перемістити курсор в поле редагування
            {
                textBox1.Focus();
            }
        }
        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    button1.Focus();
                return;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            String text = textBox15.Text; // введення тексту

            char[] delimiters = new char[] { ' ', ',', '.', ';' };// роздільники
            int wordCount = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;//підрахунок кількості слів
            label28.Text = ("Number of words = " + wordCount);//виведення відповіді
            
        }
 }   }




