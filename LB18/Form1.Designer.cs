
namespace LB18
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
            this.components = new System.ComponentModel.Container();
            this.listViewProcesses = new System.Windows.Forms.ListView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.contextMenuProcess = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.infoProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.killMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProcesses
            // 
            this.listViewProcesses.HideSelection = false;
            this.listViewProcesses.Location = new System.Drawing.Point(117, 33);
            this.listViewProcesses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewProcesses.Name = "listViewProcesses";
            this.listViewProcesses.Size = new System.Drawing.Size(388, 382);
            this.listViewProcesses.TabIndex = 0;
            this.listViewProcesses.UseCompatibleStateImageBehavior = false;
            this.listViewProcesses.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewProcesses_MouseClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(11, 33);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(88, 29);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Оновити";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(11, 93);
            this.buttonExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(88, 29);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Експортувати";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // contextMenuProcess
            // 
            this.contextMenuProcess.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuProcess.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoProcess,
            this.killMenuItem,
            this.infoThreadsToolStripMenuItem,
            this.infoModulesToolStripMenuItem});
            this.contextMenuProcess.Name = "contextMenuProcess";
            this.contextMenuProcess.Size = new System.Drawing.Size(206, 92);
            // 
            // infoProcess
            // 
            this.infoProcess.Name = "infoProcess";
            this.infoProcess.Size = new System.Drawing.Size(205, 22);
            this.infoProcess.Text = "Інформація про процес";
            this.infoProcess.Click += new System.EventHandler(this.infoProcess_Click);
            // 
            // killMenuItem
            // 
            this.killMenuItem.Name = "killMenuItem";
            this.killMenuItem.Size = new System.Drawing.Size(205, 22);
            this.killMenuItem.Text = "Зупинити процес";
            this.killMenuItem.Click += new System.EventHandler(this.killMenuItem_Click);
            // 
            // infoThreadsToolStripMenuItem
            // 
            this.infoThreadsToolStripMenuItem.Name = "infoThreadsToolStripMenuItem";
            this.infoThreadsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.infoThreadsToolStripMenuItem.Text = "Інформація про потоки";
            this.infoThreadsToolStripMenuItem.Click += new System.EventHandler(this.infoThreadsToolStripMenuItem_Click);
            // 
            // infoModulesToolStripMenuItem
            // 
            this.infoModulesToolStripMenuItem.Name = "infoModulesToolStripMenuItem";
            this.infoModulesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.infoModulesToolStripMenuItem.Text = "Інформація про модулі";
            this.infoModulesToolStripMenuItem.Click += new System.EventHandler(this.infoModulesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(571, 426);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.listViewProcesses);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "LAB18";
            this.contextMenuProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewProcesses;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.ContextMenuStrip contextMenuProcess;
        private System.Windows.Forms.ToolStripMenuItem infoProcess;
        private System.Windows.Forms.ToolStripMenuItem killMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem infoThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoModulesToolStripMenuItem;
    }
}

