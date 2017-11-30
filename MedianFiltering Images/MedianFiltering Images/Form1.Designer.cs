using System;
using System.Windows.Forms;

namespace MedianFiltering_Images
{
    partial class FilteringForm
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

        [STAThread]
        static void Main()
        {
            Application.Run(new FilteringForm());

        }
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.oneThreadB = new System.Windows.Forms.Button();
            this.TwoThreadsB = new System.Windows.Forms.Button();
            this.timeL = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.saveFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(124, 22);
            this.openFile.Text = "Open File";
            this.openFile.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(468, 359);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // oneThreadB
            // 
            this.oneThreadB.Location = new System.Drawing.Point(296, 1);
            this.oneThreadB.Name = "oneThreadB";
            this.oneThreadB.Size = new System.Drawing.Size(84, 23);
            this.oneThreadB.TabIndex = 2;
            this.oneThreadB.Text = "One Thread";
            this.oneThreadB.UseVisualStyleBackColor = true;
            this.oneThreadB.Click += new System.EventHandler(this.OneThreadB_Click);
            // 
            // TwoThreadsB
            // 
            this.TwoThreadsB.Location = new System.Drawing.Point(386, 0);
            this.TwoThreadsB.Name = "TwoThreadsB";
            this.TwoThreadsB.Size = new System.Drawing.Size(83, 24);
            this.TwoThreadsB.TabIndex = 3;
            this.TwoThreadsB.Text = "Two Threads";
            this.TwoThreadsB.UseVisualStyleBackColor = true;
            this.TwoThreadsB.Click += new System.EventHandler(this.TwoThreadsB_Click);
            // 
            // timeL
            // 
            this.timeL.AutoSize = true;
            this.timeL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeL.Location = new System.Drawing.Point(0, 370);
            this.timeL.Name = "timeL";
            this.timeL.Size = new System.Drawing.Size(87, 13);
            this.timeL.TabIndex = 4;
            this.timeL.Text = "time of execution";
            // 
            // FilteringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(468, 383);
            this.Controls.Add(this.timeL);
            this.Controls.Add(this.TwoThreadsB);
            this.Controls.Add(this.oneThreadB);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FilteringForm";
            this.Text = "Median Filtering";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button oneThreadB;
        private System.Windows.Forms.Button TwoThreadsB;
        private System.Windows.Forms.Label timeL;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private SaveFileDialog saveFileDialog;




    }
}

