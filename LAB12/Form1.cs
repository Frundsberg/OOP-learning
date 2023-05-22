using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace LAB12
{
    public partial class Form1 : Form
    {
        private string templatePath = "C:\\Users\\User\\Desktop\\Gift.docx";
        private string outputPath = "C:\\Users\\User\\Desktop\\NewDocument.docx";
        public Form1()
        {
            InitializeComponent();
        }
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Створення об'єкту додатку Microsoft Word
                var wordApp = new Application();

                // Відкриття шаблону документа
                var document = wordApp.Documents.Open(templatePath);

                // Отримання секцій документа
                var sections = document.Sections;
                foreach (Section section in sections)
                {
                    // Отримання назви секції
                    var sectionName = section.Range.Text;

                    // Виведення назви секції
                    Console.WriteLine("Назва секції: " + sectionName);
                }
                
                // Застосування різних шаблонів до секцій документа
                foreach (Section section in sections)
                {
                    ApplyTemplateToSection(section);
                }
                // Заміна тексту в шаблоні 1 на введений користувачем текст
                var range = document.Content;
                range.Find.Execute(FindText: "Кому:", ReplaceWith: nazvaTextBox.Text);

                var range1 = document.Content;
                range1.Find.Execute(FindText: "От:", ReplaceWith: opusTextBox.Text);

                var range2 = document.Content;
                range2.Find.Execute(FindText: "Дата выпуска:", ReplaceWith: dateTimePicker.Text);

                // Заміна тексту в шаблоні 2 на введений користувачем текст
                var range6 = document.Content;
                range6.Find.Execute(FindText: "Кому2:", ReplaceWith: nazvaTextBox.Text);

                var range7 = document.Content;
                range7.Find.Execute(FindText: "От2:", ReplaceWith: opusTextBox.Text);

                var range8 = document.Content;
                range8.Find.Execute(FindText: "Дата выпуска2:", ReplaceWith: dateTimePicker.Text);

                

          
                
                // Збереження згенерованого документа
                document.SaveAs(outputPath);

                // Закриття документа та додатку Microsoft Word
                document.Close();
                wordApp.Quit();

                MessageBox.Show("Документ згенеровано успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка при генерації документа: " + ex.Message);
            }
        }

    }
}
