
namespace LAB11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InsertDataButton = new System.Windows.Forms.Button();
            this.DisplayDataButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.departureTextBox = new System.Windows.Forms.TextBox();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ReportButton = new System.Windows.Forms.Button();
            this.reportRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchResultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.reportRichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.averagePriceButton = new System.Windows.Forms.Button();
            this.airlineTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flightIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertDataButton
            // 
            this.InsertDataButton.Location = new System.Drawing.Point(561, 10);
            this.InsertDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.InsertDataButton.Name = "InsertDataButton";
            this.InsertDataButton.Size = new System.Drawing.Size(255, 19);
            this.InsertDataButton.TabIndex = 0;
            this.InsertDataButton.Text = "Внести дані";
            this.InsertDataButton.UseVisualStyleBackColor = true;
            this.InsertDataButton.Click += new System.EventHandler(this.InsertDataButton_Click);
            // 
            // DisplayDataButton
            // 
            this.DisplayDataButton.Location = new System.Drawing.Point(561, 32);
            this.DisplayDataButton.Margin = new System.Windows.Forms.Padding(2);
            this.DisplayDataButton.Name = "DisplayDataButton";
            this.DisplayDataButton.Size = new System.Drawing.Size(255, 19);
            this.DisplayDataButton.TabIndex = 1;
            this.DisplayDataButton.Text = "Показати таблицю";
            this.DisplayDataButton.UseVisualStyleBackColor = true;
            this.DisplayDataButton.Click += new System.EventHandler(this.DisplayDataButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(362, 88);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(454, 312);
            this.dataGridView.TabIndex = 2;
            // 
            // departureTextBox
            // 
            this.departureTextBox.Location = new System.Drawing.Point(9, 10);
            this.departureTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.departureTextBox.Name = "departureTextBox";
            this.departureTextBox.Size = new System.Drawing.Size(99, 20);
            this.departureTextBox.TabIndex = 3;
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Location = new System.Drawing.Point(9, 47);
            this.destinationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(99, 20);
            this.destinationTextBox.TabIndex = 4;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(-215, 299);
            this.positionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(76, 20);
            this.positionTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(241, 11);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(112, 20);
            this.priceTextBox.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(-215, 216);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 7;
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(9, 112);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(308, 19);
            this.ReportButton.TabIndex = 9;
            this.ReportButton.Text = "Показати запити";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // reportRichTextBox
            // 
            this.reportRichTextBox.Location = new System.Drawing.Point(9, 136);
            this.reportRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.reportRichTextBox.Name = "reportRichTextBox";
            this.reportRichTextBox.Size = new System.Drawing.Size(137, 91);
            this.reportRichTextBox.TabIndex = 10;
            this.reportRichTextBox.Text = "";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(10, 232);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(212, 19);
            this.SearchButton.TabIndex = 11;
            this.SearchButton.Text = "Пошук по ID";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(226, 232);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(119, 20);
            this.searchTextBox.TabIndex = 12;
            // 
            // searchResultsRichTextBox
            // 
            this.searchResultsRichTextBox.Location = new System.Drawing.Point(10, 257);
            this.searchResultsRichTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchResultsRichTextBox.Name = "searchResultsRichTextBox";
            this.searchResultsRichTextBox.Size = new System.Drawing.Size(335, 145);
            this.searchResultsRichTextBox.TabIndex = 13;
            this.searchResultsRichTextBox.Text = "";
            // 
            // reportRichTextBox2
            // 
            this.reportRichTextBox2.Location = new System.Drawing.Point(165, 136);
            this.reportRichTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.reportRichTextBox2.Name = "reportRichTextBox2";
            this.reportRichTextBox2.Size = new System.Drawing.Size(152, 91);
            this.reportRichTextBox2.TabIndex = 14;
            this.reportRichTextBox2.Text = "";
            // 
            // averagePriceButton
            // 
            this.averagePriceButton.Location = new System.Drawing.Point(561, 56);
            this.averagePriceButton.Name = "averagePriceButton";
            this.averagePriceButton.Size = new System.Drawing.Size(253, 23);
            this.averagePriceButton.TabIndex = 15;
            this.averagePriceButton.Text = "Звіт по середній ціні рейсу";
            this.averagePriceButton.UseVisualStyleBackColor = true;
            // 
            // airlineTextBox
            // 
            this.airlineTextBox.Location = new System.Drawing.Point(241, 47);
            this.airlineTextBox.Name = "airlineTextBox";
            this.airlineTextBox.Size = new System.Drawing.Size(112, 20);
            this.airlineTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Місце відправлення";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Місце прибуття";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ціна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Авіакомпанія";
            // 
            // flightIdTextBox
            // 
            this.flightIdTextBox.Location = new System.Drawing.Point(436, 14);
            this.flightIdTextBox.Name = "flightIdTextBox";
            this.flightIdTextBox.Size = new System.Drawing.Size(42, 20);
            this.flightIdTextBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 410);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.flightIdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.airlineTextBox);
            this.Controls.Add(this.averagePriceButton);
            this.Controls.Add(this.reportRichTextBox2);
            this.Controls.Add(this.searchResultsRichTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.reportRichTextBox);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.departureTextBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.DisplayDataButton);
            this.Controls.Add(this.InsertDataButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "LAB11";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertDataButton;
        private System.Windows.Forms.Button DisplayDataButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox departureTextBox;
        private System.Windows.Forms.TextBox destinationTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.RichTextBox reportRichTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RichTextBox searchResultsRichTextBox;
        private System.Windows.Forms.RichTextBox reportRichTextBox2;
        private System.Windows.Forms.Button averagePriceButton;
        private System.Windows.Forms.TextBox airlineTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox flightIdTextBox;
        private System.Windows.Forms.Label label5;
    }
}

