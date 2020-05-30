namespace Human_Department.Forms
{
    partial class Director_App
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
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dismiss_the_Employee_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recruitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmHireOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refuseHireOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmDismissOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refuseDismissOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.About_us = new System.Windows.Forms.ToolStripMenuItem();
            this.Job_Seekers_List = new System.Windows.Forms.CheckedListBox();
            this.Delete_Employee = new System.Windows.Forms.Button();
            this.Employees_List = new System.Windows.Forms.CheckedListBox();
            this.Recruit_Btn = new System.Windows.Forms.Button();
            this.Vacances_List = new System.Windows.Forms.CheckedListBox();
            this.Orders_for_quiting_List = new System.Windows.Forms.CheckedListBox();
            this.Confirm_Hiring = new System.Windows.Forms.Button();
            this.Refuse_Hiring = new System.Windows.Forms.Button();
            this.Orders_for_Hiring_List = new System.Windows.Forms.CheckedListBox();
            this.Refuse_Quiting = new System.Windows.Forms.Button();
            this.Confirm_Quiting = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(1356, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.файлToolStripMenuItem.Text = "File";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(123, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dismiss_the_Employee_ToolStripMenuItem,
            this.recruitToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.ChangeUserToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.действияToolStripMenuItem.Text = "Actions";
            // 
            // Dismiss_the_Employee_ToolStripMenuItem
            // 
            this.Dismiss_the_Employee_ToolStripMenuItem.Name = "Dismiss_the_Employee_ToolStripMenuItem";
            this.Dismiss_the_Employee_ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.Dismiss_the_Employee_ToolStripMenuItem.Text = "Dismiss";
            this.Dismiss_the_Employee_ToolStripMenuItem.Click += new System.EventHandler(this.Delete_Employee_Click);
            // 
            // recruitToolStripMenuItem
            // 
            this.recruitToolStripMenuItem.Name = "recruitToolStripMenuItem";
            this.recruitToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.recruitToolStripMenuItem.Text = "Recruit";
            this.recruitToolStripMenuItem.Click += new System.EventHandler(this.Recruit_Btn_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confirmHireOrderToolStripMenuItem,
            this.refuseHireOrderToolStripMenuItem,
            this.confirmDismissOrderToolStripMenuItem,
            this.refuseDismissOrderToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // confirmHireOrderToolStripMenuItem
            // 
            this.confirmHireOrderToolStripMenuItem.Name = "confirmHireOrderToolStripMenuItem";
            this.confirmHireOrderToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.confirmHireOrderToolStripMenuItem.Text = "Confirm Hire Order";
            this.confirmHireOrderToolStripMenuItem.Click += new System.EventHandler(this.Confirm_Hiring_Click);
            // 
            // refuseHireOrderToolStripMenuItem
            // 
            this.refuseHireOrderToolStripMenuItem.Name = "refuseHireOrderToolStripMenuItem";
            this.refuseHireOrderToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.refuseHireOrderToolStripMenuItem.Text = "Refuse Hire Order";
            this.refuseHireOrderToolStripMenuItem.Click += new System.EventHandler(this.Refuse_Hiring_Click);
            // 
            // confirmDismissOrderToolStripMenuItem
            // 
            this.confirmDismissOrderToolStripMenuItem.Name = "confirmDismissOrderToolStripMenuItem";
            this.confirmDismissOrderToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.confirmDismissOrderToolStripMenuItem.Text = "Confirm Dismiss Order";
            this.confirmDismissOrderToolStripMenuItem.Click += new System.EventHandler(this.Confirm_Quiting_Click);
            // 
            // refuseDismissOrderToolStripMenuItem
            // 
            this.refuseDismissOrderToolStripMenuItem.Name = "refuseDismissOrderToolStripMenuItem";
            this.refuseDismissOrderToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.refuseDismissOrderToolStripMenuItem.Text = "Refuse Dismiss Order";
            this.refuseDismissOrderToolStripMenuItem.Click += new System.EventHandler(this.Refuse_Quiting_Click);
            // 
            // ChangeUserToolStripMenuItem
            // 
            this.ChangeUserToolStripMenuItem.Name = "ChangeUserToolStripMenuItem";
            this.ChangeUserToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.ChangeUserToolStripMenuItem.Text = "Change user";
            this.ChangeUserToolStripMenuItem.Click += new System.EventHandler(this.ChangeUserToolStripMenuItem_Click);
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
            this.About_us.Click += new System.EventHandler(this.About_us_Click);
            // 
            // Job_Seekers_List
            // 
            this.Job_Seekers_List.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Job_Seekers_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Job_Seekers_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Job_Seekers_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Job_Seekers_List.FormattingEnabled = true;
            this.Job_Seekers_List.Location = new System.Drawing.Point(12, 420);
            this.Job_Seekers_List.Name = "Job_Seekers_List";
            this.Job_Seekers_List.Size = new System.Drawing.Size(382, 274);
            this.Job_Seekers_List.TabIndex = 13;
            this.Job_Seekers_List.SelectedIndexChanged += new System.EventHandler(this.Show_Recruit_Btn);
            // 
            // Delete_Employee
            // 
            this.Delete_Employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_Employee.BackColor = System.Drawing.Color.Turquoise;
            this.Delete_Employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Employee.Location = new System.Drawing.Point(1059, 700);
            this.Delete_Employee.Name = "Delete_Employee";
            this.Delete_Employee.Size = new System.Drawing.Size(127, 42);
            this.Delete_Employee.TabIndex = 15;
            this.Delete_Employee.Text = "Dismiss";
            this.Delete_Employee.UseVisualStyleBackColor = false;
            this.Delete_Employee.Visible = false;
            this.Delete_Employee.Click += new System.EventHandler(this.Delete_Employee_Click);
            // 
            // Employees_List
            // 
            this.Employees_List.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Employees_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Employees_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Employees_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Employees_List.FormattingEnabled = true;
            this.Employees_List.Location = new System.Drawing.Point(859, 420);
            this.Employees_List.Name = "Employees_List";
            this.Employees_List.Size = new System.Drawing.Size(485, 274);
            this.Employees_List.TabIndex = 16;
            this.Employees_List.SelectedIndexChanged += new System.EventHandler(this.Show_Delete_Btn);
            // 
            // Recruit_Btn
            // 
            this.Recruit_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Recruit_Btn.BackColor = System.Drawing.Color.Turquoise;
            this.Recruit_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Recruit_Btn.Location = new System.Drawing.Point(336, 700);
            this.Recruit_Btn.Name = "Recruit_Btn";
            this.Recruit_Btn.Size = new System.Drawing.Size(127, 42);
            this.Recruit_Btn.TabIndex = 17;
            this.Recruit_Btn.Text = "Recruit";
            this.Recruit_Btn.UseVisualStyleBackColor = false;
            this.Recruit_Btn.Visible = false;
            this.Recruit_Btn.Click += new System.EventHandler(this.Recruit_Btn_Click);
            // 
            // Vacances_List
            // 
            this.Vacances_List.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Vacances_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Vacances_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Vacances_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vacances_List.FormattingEnabled = true;
            this.Vacances_List.Location = new System.Drawing.Point(400, 420);
            this.Vacances_List.Name = "Vacances_List";
            this.Vacances_List.Size = new System.Drawing.Size(453, 274);
            this.Vacances_List.TabIndex = 18;
            this.Vacances_List.SelectedIndexChanged += new System.EventHandler(this.Show_Recruit_Btn);
            // 
            // Orders_for_quiting_List
            // 
            this.Orders_for_quiting_List.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Orders_for_quiting_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Orders_for_quiting_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Orders_for_quiting_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orders_for_quiting_List.FormattingEnabled = true;
            this.Orders_for_quiting_List.Location = new System.Drawing.Point(700, 63);
            this.Orders_for_quiting_List.Name = "Orders_for_quiting_List";
            this.Orders_for_quiting_List.Size = new System.Drawing.Size(644, 257);
            this.Orders_for_quiting_List.TabIndex = 19;
            this.Orders_for_quiting_List.SelectedIndexChanged += new System.EventHandler(this.Show_Decision_Btn_Quit);
            // 
            // Confirm_Hiring
            // 
            this.Confirm_Hiring.BackColor = System.Drawing.Color.Turquoise;
            this.Confirm_Hiring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm_Hiring.Location = new System.Drawing.Point(12, 336);
            this.Confirm_Hiring.Name = "Confirm_Hiring";
            this.Confirm_Hiring.Size = new System.Drawing.Size(125, 42);
            this.Confirm_Hiring.TabIndex = 20;
            this.Confirm_Hiring.Text = "Confirm";
            this.Confirm_Hiring.UseVisualStyleBackColor = false;
            this.Confirm_Hiring.Visible = false;
            this.Confirm_Hiring.Click += new System.EventHandler(this.Confirm_Hiring_Click);
            // 
            // Refuse_Hiring
            // 
            this.Refuse_Hiring.BackColor = System.Drawing.Color.Turquoise;
            this.Refuse_Hiring.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refuse_Hiring.Location = new System.Drawing.Point(531, 336);
            this.Refuse_Hiring.Name = "Refuse_Hiring";
            this.Refuse_Hiring.Size = new System.Drawing.Size(125, 42);
            this.Refuse_Hiring.TabIndex = 21;
            this.Refuse_Hiring.Text = "Refuse";
            this.Refuse_Hiring.UseVisualStyleBackColor = false;
            this.Refuse_Hiring.Visible = false;
            this.Refuse_Hiring.Click += new System.EventHandler(this.Refuse_Hiring_Click);
            // 
            // Orders_for_Hiring_List
            // 
            this.Orders_for_Hiring_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Orders_for_Hiring_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Orders_for_Hiring_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orders_for_Hiring_List.FormattingEnabled = true;
            this.Orders_for_Hiring_List.Location = new System.Drawing.Point(12, 63);
            this.Orders_for_Hiring_List.Name = "Orders_for_Hiring_List";
            this.Orders_for_Hiring_List.Size = new System.Drawing.Size(644, 257);
            this.Orders_for_Hiring_List.TabIndex = 22;
            this.Orders_for_Hiring_List.SelectedIndexChanged += new System.EventHandler(this.Show_Decision_Btn_Hire);
            // 
            // Refuse_Quiting
            // 
            this.Refuse_Quiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Refuse_Quiting.BackColor = System.Drawing.Color.Turquoise;
            this.Refuse_Quiting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refuse_Quiting.Location = new System.Drawing.Point(1219, 336);
            this.Refuse_Quiting.Name = "Refuse_Quiting";
            this.Refuse_Quiting.Size = new System.Drawing.Size(125, 42);
            this.Refuse_Quiting.TabIndex = 24;
            this.Refuse_Quiting.Text = "Refuse";
            this.Refuse_Quiting.UseVisualStyleBackColor = false;
            this.Refuse_Quiting.Visible = false;
            this.Refuse_Quiting.Click += new System.EventHandler(this.Refuse_Quiting_Click);
            // 
            // Confirm_Quiting
            // 
            this.Confirm_Quiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Confirm_Quiting.BackColor = System.Drawing.Color.Turquoise;
            this.Confirm_Quiting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm_Quiting.Location = new System.Drawing.Point(700, 336);
            this.Confirm_Quiting.Name = "Confirm_Quiting";
            this.Confirm_Quiting.Size = new System.Drawing.Size(125, 42);
            this.Confirm_Quiting.TabIndex = 23;
            this.Confirm_Quiting.Text = "Confirm";
            this.Confirm_Quiting.UseVisualStyleBackColor = false;
            this.Confirm_Quiting.Visible = false;
            this.Confirm_Quiting.Click += new System.EventHandler(this.Confirm_Quiting_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBox1.Location = new System.Drawing.Point(859, 392);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(485, 22);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "To dismiss employee choos him in the list below";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBox2.Location = new System.Drawing.Point(700, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(644, 22);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "To confirm or refuse the order of quiting choos it in the list below";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBox3.Location = new System.Drawing.Point(12, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(644, 22);
            this.textBox3.TabIndex = 27;
            this.textBox3.Text = "To confirm or refuse the order of hiring choos it in the list below";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBox4.Location = new System.Drawing.Point(12, 392);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(841, 22);
            this.textBox4.TabIndex = 28;
            this.textBox4.Text = "To hire the jobseeker choos him in the list below and then coose the vacancy for " +
    "him";
            // 
            // Director_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1356, 754);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Refuse_Quiting);
            this.Controls.Add(this.Confirm_Quiting);
            this.Controls.Add(this.Orders_for_Hiring_List);
            this.Controls.Add(this.Refuse_Hiring);
            this.Controls.Add(this.Confirm_Hiring);
            this.Controls.Add(this.Orders_for_quiting_List);
            this.Controls.Add(this.Vacances_List);
            this.Controls.Add(this.Recruit_Btn);
            this.Controls.Add(this.Employees_List);
            this.Controls.Add(this.Delete_Employee);
            this.Controls.Add(this.Job_Seekers_List);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(1374, 801);
            this.Name = "Director_App";
            this.Text = "Director_App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Director_App_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Director_App_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Dismiss_the_Employee_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem About_us;
        private System.Windows.Forms.CheckedListBox Job_Seekers_List;
        private System.Windows.Forms.Button Delete_Employee;
        private System.Windows.Forms.CheckedListBox Employees_List;
        private System.Windows.Forms.Button Recruit_Btn;
        private System.Windows.Forms.CheckedListBox Vacances_List;
        private System.Windows.Forms.CheckedListBox Orders_for_quiting_List;
        private System.Windows.Forms.Button Confirm_Hiring;
        private System.Windows.Forms.Button Refuse_Hiring;
        private System.Windows.Forms.CheckedListBox Orders_for_Hiring_List;
        private System.Windows.Forms.Button Refuse_Quiting;
        private System.Windows.Forms.Button Confirm_Quiting;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmHireOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refuseHireOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmDismissOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refuseDismissOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recruitToolStripMenuItem;
    }
}