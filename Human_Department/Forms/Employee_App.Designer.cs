namespace Human_Department.Forms
{
    partial class Employee_App
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
            this.Vacancies = new System.Windows.Forms.Label();
            this.Employees = new System.Windows.Forms.Label();
            this.Quit_Text = new System.Windows.Forms.TextBox();
            this.Quit_Button = new System.Windows.Forms.Button();
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
            this.See_Salaries_Text = new System.Windows.Forms.TextBox();
            this.See_Salary = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vacancies
            // 
            this.Vacancies.AutoSize = true;
            this.Vacancies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vacancies.Location = new System.Drawing.Point(30, 93);
            this.Vacancies.Name = "Vacancies";
            this.Vacancies.Size = new System.Drawing.Size(265, 25);
            this.Vacancies.TabIndex = 7;
            this.Vacancies.Text = "Vacancies currently available";
            // 
            // Employees
            // 
            this.Employees.AutoSize = true;
            this.Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Employees.Location = new System.Drawing.Point(30, 40);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(91, 25);
            this.Employees.TabIndex = 6;
            this.Employees.Text = "Currently";
            // 
            // Quit_Text
            // 
            this.Quit_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Quit_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Quit_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quit_Text.Location = new System.Drawing.Point(35, 139);
            this.Quit_Text.Multiline = true;
            this.Quit_Text.Name = "Quit_Text";
            this.Quit_Text.ReadOnly = true;
            this.Quit_Text.Size = new System.Drawing.Size(318, 63);
            this.Quit_Text.TabIndex = 8;
            this.Quit_Text.Text = "If you wont to apply for dismissal click the button (quit)";
            // 
            // Quit_Button
            // 
            this.Quit_Button.BackColor = System.Drawing.Color.Turquoise;
            this.Quit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quit_Button.Location = new System.Drawing.Point(350, 162);
            this.Quit_Button.Name = "Quit_Button";
            this.Quit_Button.Size = new System.Drawing.Size(142, 40);
            this.Quit_Button.TabIndex = 9;
            this.Quit_Button.Text = "Quit";
            this.Quit_Button.UseVisualStyleBackColor = false;
            this.Quit_Button.Click += new System.EventHandler(this.Quit_Button_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(547, 30);
            this.menuStrip1.TabIndex = 10;
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
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Save";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.выборВакансииToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выборВакансииToolStripMenuItem.Text = "Quit";
            this.выборВакансииToolStripMenuItem.Click += new System.EventHandler(this.Quit_Button_Click);
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.About_us.Size = new System.Drawing.Size(224, 26);
            this.About_us.Text = "About us";
            this.About_us.Click += new System.EventHandler(this.About_us_Click);
            // 
            // See_Salaries_Text
            // 
            this.See_Salaries_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.See_Salaries_Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.See_Salaries_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.See_Salaries_Text.Location = new System.Drawing.Point(35, 208);
            this.See_Salaries_Text.Multiline = true;
            this.See_Salaries_Text.Name = "See_Salaries_Text";
            this.See_Salaries_Text.ReadOnly = true;
            this.See_Salaries_Text.Size = new System.Drawing.Size(318, 85);
            this.See_Salaries_Text.TabIndex = 11;
            this.See_Salaries_Text.Text = "If you wont to see your salary changes  click the button (Check_Salaries)";
            // 
            // See_Salary
            // 
            this.See_Salary.BackColor = System.Drawing.Color.Turquoise;
            this.See_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.See_Salary.Location = new System.Drawing.Point(350, 253);
            this.See_Salary.Name = "See_Salary";
            this.See_Salary.Size = new System.Drawing.Size(142, 40);
            this.See_Salary.TabIndex = 12;
            this.See_Salary.Text = "Check_Salaries";
            this.See_Salary.UseVisualStyleBackColor = false;
            this.See_Salary.Click += new System.EventHandler(this.See_Salary_Click);
            // 
            // Employee_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(547, 305);
            this.Controls.Add(this.See_Salary);
            this.Controls.Add(this.See_Salaries_Text);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Quit_Button);
            this.Controls.Add(this.Quit_Text);
            this.Controls.Add(this.Vacancies);
            this.Controls.Add(this.Employees);
            this.Name = "Employee_App";
            this.Text = "Employee_App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_App_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Employee_App_FormClosed);
            this.Load += new System.EventHandler(this.Employee_App_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Vacancies;
        private System.Windows.Forms.Label Employees;
        private System.Windows.Forms.TextBox Quit_Text;
        private System.Windows.Forms.Button Quit_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборВакансииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_us;
        private System.Windows.Forms.TextBox See_Salaries_Text;
        private System.Windows.Forms.Button See_Salary;
    }
}