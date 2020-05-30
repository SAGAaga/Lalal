namespace Human_Department.Forms
{
    partial class Job_Seeker_App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборВакансииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_us = new System.Windows.Forms.ToolStripMenuItem();
            this.Employees = new System.Windows.Forms.Label();
            this.Vacancies = new System.Windows.Forms.Label();
            this.Show_Button = new System.Windows.Forms.Button();
            this.Show_Button_textBox = new System.Windows.Forms.TextBox();
            this.checkedListBox_Vacancies = new System.Windows.Forms.CheckedListBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Sort_Check = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.сохранитьToolStripMenuItem.Text = "Save";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.выходToolStripMenuItem.Text = "Exit";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборВакансииToolStripMenuItem,
            this.changeUserToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.действияToolStripMenuItem.Text = "Actions";
            // 
            // выборВакансииToolStripMenuItem
            // 
            this.выборВакансииToolStripMenuItem.Name = "выборВакансииToolStripMenuItem";
            this.выборВакансииToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.выборВакансииToolStripMenuItem.Text = "Job selection";
            this.выборВакансииToolStripMenuItem.Click += new System.EventHandler(this.Show_Vacancies_List_Click);
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.changeUserToolStripMenuItem.Text = "Change user";
            this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.ChangeUserToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About_us});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.помощьToolStripMenuItem.Text = "Help";
            // 
            // About_us
            // 
            this.About_us.Name = "About_us";
            this.About_us.Size = new System.Drawing.Size(151, 26);
            this.About_us.Text = "About us";
            this.About_us.Click += new System.EventHandler(this.About_Us_ToolStripMenuItem1_Click);
            // 
            // Employees
            // 
            this.Employees.AutoSize = true;
            this.Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees.Location = new System.Drawing.Point(12, 63);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(91, 25);
            this.Employees.TabIndex = 1;
            this.Employees.Text = "Currently";
            // 
            // Vacancies
            // 
            this.Vacancies.AutoSize = true;
            this.Vacancies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vacancies.Location = new System.Drawing.Point(12, 116);
            this.Vacancies.Name = "Vacancies";
            this.Vacancies.Size = new System.Drawing.Size(265, 25);
            this.Vacancies.TabIndex = 2;
            this.Vacancies.Text = "Vacancies currently available";
            // 
            // Show_Button
            // 
            this.Show_Button.BackColor = System.Drawing.Color.Turquoise;
            this.Show_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_Button.Location = new System.Drawing.Point(354, 160);
            this.Show_Button.Name = "Show_Button";
            this.Show_Button.Size = new System.Drawing.Size(130, 51);
            this.Show_Button.TabIndex = 3;
            this.Show_Button.Text = "Show";
            this.Show_Button.UseVisualStyleBackColor = false;
            this.Show_Button.Click += new System.EventHandler(this.Show_Vacancies_List_Click);
            // 
            // Show_Button_textBox
            // 
            this.Show_Button_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Show_Button_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Show_Button_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_Button_textBox.Location = new System.Drawing.Point(17, 160);
            this.Show_Button_textBox.Multiline = true;
            this.Show_Button_textBox.Name = "Show_Button_textBox";
            this.Show_Button_textBox.ReadOnly = true;
            this.Show_Button_textBox.Size = new System.Drawing.Size(331, 72);
            this.Show_Button_textBox.TabIndex = 5;
            this.Show_Button_textBox.Text = "To see the list of available vacancies, click on the show button.";
            // 
            // checkedListBox_Vacancies
            // 
            this.checkedListBox_Vacancies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox_Vacancies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.checkedListBox_Vacancies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_Vacancies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox_Vacancies.FormattingEnabled = true;
            this.checkedListBox_Vacancies.Location = new System.Drawing.Point(543, 130);
            this.checkedListBox_Vacancies.Name = "checkedListBox_Vacancies";
            this.checkedListBox_Vacancies.Size = new System.Drawing.Size(334, 308);
            this.checkedListBox_Vacancies.TabIndex = 6;
            this.checkedListBox_Vacancies.Visible = false;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Turquoise;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Submit.Location = new System.Drawing.Point(354, 344);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(130, 51);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Visible = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Sort_Check
            // 
            this.Sort_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Sort_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sort_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sort_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sort_Check.FormattingEnabled = true;
            this.Sort_Check.Items.AddRange(new object[] {
            "Сортировать по алфавиту",
            "Сортировать по зарплате"});
            this.Sort_Check.Location = new System.Drawing.Point(543, 100);
            this.Sort_Check.Name = "Sort_Check";
            this.Sort_Check.Size = new System.Drawing.Size(236, 24);
            this.Sort_Check.TabIndex = 9;
            this.Sort_Check.Text = "Сортировать по алфавиту";
            this.Sort_Check.Visible = false;
            this.Sort_Check.SelectedIndexChanged += new System.EventHandler(this.Sort_Check_SelectedIndexChanged);
            // 
            // Job_Seeker_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.Sort_Check);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.checkedListBox_Vacancies);
            this.Controls.Add(this.Show_Button_textBox);
            this.Controls.Add(this.Show_Button);
            this.Controls.Add(this.Vacancies);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Job_Seeker_App";
            this.Text = "Job_Seeker_App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Job_Seeker_App_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Job_Seeker_App_FormClosed);
            this.Load += new System.EventHandler(this.Job_Seeker_App_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label Employees;
        private System.Windows.Forms.Label Vacancies;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборВакансииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_us;
        private System.Windows.Forms.Button Show_Button;
        private System.Windows.Forms.TextBox Show_Button_textBox;
        private System.Windows.Forms.CheckedListBox checkedListBox_Vacancies;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox Sort_Check;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
    }
}