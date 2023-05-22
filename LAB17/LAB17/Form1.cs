using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LAB17
{
    public partial class Form1 : Form
    {
        private TcpClient client; // Клас для взаємодії з TCP-клієнтом
        private NetworkStream stream; // Потік для зчитування та запису даних через мережу
        private Thread receiveThread; // Потік для отримання повідомлень від сервера

        public Form1()
        {
            InitializeComponent();
        }

        // Обробник натиснення кнопки "Підключитись"
        private void btnConnect_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            client = new TcpClient();

            try
            {
                // Встановлення з'єднання з сервером
                client.Connect("127.0.0.1", 8888);
                stream = client.GetStream();
                byte[] data = Encoding.Unicode.GetBytes(userName);
                stream.Write(data, 0, data.Length);

                // Створення та запуск потоку для отримання повідомлень від сервера
                receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start();

                lblStatus.Text = "Підключено";
                btnSend.Enabled = true;
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка підключення до сервера: " + ex.Message);
                Disconnect();
            }
        }

        // Обробник натиснення кнопки "Відправити"
        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            byte[] data = Encoding.Unicode.GetBytes(message);
            stream.Write(data, 0, data.Length);
            txtMessage.Clear();

            // Додавання відправленого повідомлення до текстового поля чату
            DisplayMessage("Я: " + message);
        }

        // Метод для отримання повідомлень від сервера
        private void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[64];
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;

                    // Зчитування даних з потоку, поки вони доступні
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    } while (stream.DataAvailable);

                    string message = builder.ToString();
                    DisplayMessage(message);
                }
                catch
                {
                    DisplayMessage("Підключення перервано!");
                    Disconnect();
                    break;
                }
            }
        }

        // Метод для відображення повідомлення в текстовому полі чату
        private void DisplayMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(DisplayMessage), message);
            }
            else
            {
                txtChat.AppendText(message + Environment.NewLine);
            }
        }

        // Обробник події закриття форми
        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        // Метод для відключення від сервера
        private void Disconnect()
        {
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();

            if (receiveThread != null && receiveThread.IsAlive)
                receiveThread.Join();

            lblStatus.Text = "Відключено";
            btnSend.Enabled = false;
            btnConnect.Enabled = true;
        }
    }
}