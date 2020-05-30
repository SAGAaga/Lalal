namespace Human_Department
{
    partial class Adding_Form
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
            this.Adding_Panel = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.TextBox();
            this.Birthday_Label = new System.Windows.Forms.Label();
            this.Speciality = new System.Windows.Forms.TextBox();
            this.Speciality_Label = new System.Windows.Forms.Label();
            this.Aducation = new System.Windows.Forms.TextBox();
            this.Aducation_Label = new System.Windows.Forms.Label();
            this.Passport_ID = new System.Windows.Forms.TextBox();
            this.Passport_Label = new System.Windows.Forms.Label();
            this.Second_Name = new System.Windows.Forms.TextBox();
            this.Second_Name_Label = new System.Windows.Forms.Label();
            this.First_Name = new System.Windows.Forms.TextBox();
            this.Lable_Name = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.Close_Label = new System.Windows.Forms.Label();
            this.Adding_Title = new System.Windows.Forms.Label();
            this.Adding_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Adding_Panel
            // 
            this.Adding_Panel.BackgroundImage = global::Human_Department.Properties.Resources.Login_BG;
            this.Adding_Panel.Controls.Add(this.Password);
            this.Adding_Panel.Controls.Add(this.Password_Label);
            this.Adding_Panel.Controls.Add(this.Birthday);
            this.Adding_Panel.Controls.Add(this.Birthday_Label);
            this.Adding_Panel.Controls.Add(this.Speciality);
            this.Adding_Panel.Controls.Add(this.Speciality_Label);
            this.Adding_Panel.Controls.Add(this.Aducation);
            this.Adding_Panel.Controls.Add(this.Aducation_Label);
            this.Adding_Panel.Controls.Add(this.Passport_ID);
            this.Adding_Panel.Controls.Add(this.Passport_Label);
            this.Adding_Panel.Controls.Add(this.Second_Name);
            this.Adding_Panel.Controls.Add(this.Second_Name_Label);
            this.Adding_Panel.Controls.Add(this.First_Name);
            this.Adding_Panel.Controls.Add(this.Lable_Name);
            this.Adding_Panel.Controls.Add(this.Submit);
            this.Adding_Panel.Controls.Add(this.Close_Label);
            this.Adding_Panel.Controls.Add(this.Adding_Title);
            this.Adding_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Adding_Panel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Adding_Panel.Location = new System.Drawing.Point(0, 0);
            this.Adding_Panel.Name = "Adding_Panel";
            this.Adding_Panel.Size = new System.Drawing.Size(902, 569);
            this.Adding_Panel.TabIndex = 0;
            this.Adding_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.Adding_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_MouseMove);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Turquoise;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Password.Location = new System.Drawing.Point(263, 431);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(482, 30);
            this.Password.TabIndex = 33;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.BackColor = System.Drawing.Color.Transparent;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password_Label.Location = new System.Drawing.Point(12, 434);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(183, 25);
            this.Password_Label.TabIndex = 32;
            this.Password_Label.Text = "Create_Password";
            // 
            // Birthday
            // 
            this.Birthday.BackColor = System.Drawing.Color.Turquoise;
            this.Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Birthday.Location = new System.Drawing.Point(263, 375);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(482, 30);
            this.Birthday.TabIndex = 31;
            this.Birthday.Text = "Year_Month_Day";
            this.Birthday.Enter += new System.EventHandler(this.Birthday_Enter);
            this.Birthday.Leave += new System.EventHandler(this.Birthday_Leave);
            // 
            // Birthday_Label
            // 
            this.Birthday_Label.AutoSize = true;
            this.Birthday_Label.BackColor = System.Drawing.Color.Transparent;
            this.Birthday_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Birthday_Label.Location = new System.Drawing.Point(12, 378);
            this.Birthday_Label.Name = "Birthday_Label";
            this.Birthday_Label.Size = new System.Drawing.Size(196, 25);
            this.Birthday_Label.TabIndex = 30;
            this.Birthday_Label.Text = "Enter your Birthday";
            // 
            // Speciality
            // 
            this.Speciality.BackColor = System.Drawing.Color.Turquoise;
            this.Speciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Speciality.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Speciality.Location = new System.Drawing.Point(263, 323);
            this.Speciality.Name = "Speciality";
            this.Speciality.Size = new System.Drawing.Size(482, 30);
            this.Speciality.TabIndex = 25;
            // 
            // Speciality_Label
            // 
            this.Speciality_Label.AutoSize = true;
            this.Speciality_Label.BackColor = System.Drawing.Color.Transparent;
            this.Speciality_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Speciality_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Speciality_Label.Location = new System.Drawing.Point(12, 326);
            this.Speciality_Label.Name = "Speciality_Label";
            this.Speciality_Label.Size = new System.Drawing.Size(207, 25);
            this.Speciality_Label.TabIndex = 24;
            this.Speciality_Label.Text = "Enter your speciality";
            // 
            // Aducation
            // 
            this.Aducation.BackColor = System.Drawing.Color.Turquoise;
            this.Aducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Aducation.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Aducation.Location = new System.Drawing.Point(263, 268);
            this.Aducation.Name = "Aducation";
            this.Aducation.Size = new System.Drawing.Size(482, 30);
            this.Aducation.TabIndex = 23;
            // 
            // Aducation_Label
            // 
            this.Aducation_Label.AutoSize = true;
            this.Aducation_Label.BackColor = System.Drawing.Color.Transparent;
            this.Aducation_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Aducation_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Aducation_Label.Location = new System.Drawing.Point(12, 271);
            this.Aducation_Label.Name = "Aducation_Label";
            this.Aducation_Label.Size = new System.Drawing.Size(211, 25);
            this.Aducation_Label.TabIndex = 22;
            this.Aducation_Label.Text = "Enter your aducation";
            // 
            // Passport_ID
            // 
            this.Passport_ID.BackColor = System.Drawing.Color.Turquoise;
            this.Passport_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passport_ID.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Passport_ID.Location = new System.Drawing.Point(263, 212);
            this.Passport_ID.Name = "Passport_ID";
            this.Passport_ID.Size = new System.Drawing.Size(482, 30);
            this.Passport_ID.TabIndex = 21;
            // 
            // Passport_Label
            // 
            this.Passport_Label.AutoSize = true;
            this.Passport_Label.BackColor = System.Drawing.Color.Transparent;
            this.Passport_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passport_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Passport_Label.Location = new System.Drawing.Point(12, 215);
            this.Passport_Label.Name = "Passport_Label";
            this.Passport_Label.Size = new System.Drawing.Size(227, 25);
            this.Passport_Label.TabIndex = 20;
            this.Passport_Label.Text = "Enter your passport ID";
            // 
            // Second_Name
            // 
            this.Second_Name.BackColor = System.Drawing.Color.Turquoise;
            this.Second_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Second_Name.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Second_Name.Location = new System.Drawing.Point(263, 162);
            this.Second_Name.Name = "Second_Name";
            this.Second_Name.Size = new System.Drawing.Size(482, 30);
            this.Second_Name.TabIndex = 19;
            // 
            // Second_Name_Label
            // 
            this.Second_Name_Label.AutoSize = true;
            this.Second_Name_Label.BackColor = System.Drawing.Color.Transparent;
            this.Second_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Second_Name_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Second_Name_Label.Location = new System.Drawing.Point(12, 165);
            this.Second_Name_Label.Name = "Second_Name_Label";
            this.Second_Name_Label.Size = new System.Drawing.Size(246, 25);
            this.Second_Name_Label.TabIndex = 18;
            this.Second_Name_Label.Text = "Enter your second name";
            // 
            // First_Name
            // 
            this.First_Name.BackColor = System.Drawing.Color.Turquoise;
            this.First_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.First_Name.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.First_Name.Location = new System.Drawing.Point(263, 106);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(482, 30);
            this.First_Name.TabIndex = 14;
            // 
            // Lable_Name
            // 
            this.Lable_Name.AutoSize = true;
            this.Lable_Name.BackColor = System.Drawing.Color.Transparent;
            this.Lable_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lable_Name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lable_Name.Location = new System.Drawing.Point(12, 109);
            this.Lable_Name.Name = "Lable_Name";
            this.Lable_Name.Size = new System.Drawing.Size(211, 25);
            this.Lable_Name.TabIndex = 11;
            this.Lable_Name.Text = "Enter your first name";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Turquoise;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submit.Location = new System.Drawing.Point(370, 500);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(167, 54);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Close_Label
            // 
            this.Close_Label.AutoSize = true;
            this.Close_Label.BackColor = System.Drawing.Color.Transparent;
            this.Close_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Label.ForeColor = System.Drawing.Color.White;
            this.Close_Label.Location = new System.Drawing.Point(866, 0);
            this.Close_Label.Name = "Close_Label";
            this.Close_Label.Size = new System.Drawing.Size(36, 44);
            this.Close_Label.TabIndex = 9;
            this.Close_Label.Text = "x";
            this.Close_Label.Click += new System.EventHandler(this.Close_Label_Click);
            this.Close_Label.MouseLeave += new System.EventHandler(this.Close_Label_MouseLeave);
            this.Close_Label.MouseHover += new System.EventHandler(this.Close_Label_MouseHover);
            // 
            // Adding_Title
            // 
            this.Adding_Title.BackColor = System.Drawing.Color.Transparent;
            this.Adding_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Adding_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Adding_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Adding_Title.Location = new System.Drawing.Point(0, 0);
            this.Adding_Title.Name = "Adding_Title";
            this.Adding_Title.Size = new System.Drawing.Size(902, 109);
            this.Adding_Title.TabIndex = 12;
            this.Adding_Title.Text = "Registration";
            this.Adding_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Adding_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.Adding_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_MouseMove);
            // 
            // Adding_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 569);
            this.Controls.Add(this.Adding_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adding_Form";
            this.Text = "Adding_Form";
            this.Adding_Panel.ResumeLayout(false);
            this.Adding_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Adding_Panel;
        private System.Windows.Forms.Label Close_Label;
        private System.Windows.Forms.Label Lable_Name;
        private System.Windows.Forms.Label Adding_Title;
        private System.Windows.Forms.TextBox First_Name;
        private System.Windows.Forms.TextBox Second_Name;
        private System.Windows.Forms.Label Second_Name_Label;
        private System.Windows.Forms.TextBox Passport_ID;
        private System.Windows.Forms.Label Passport_Label;
        private System.Windows.Forms.TextBox Speciality;
        private System.Windows.Forms.Label Speciality_Label;
        private System.Windows.Forms.TextBox Aducation;
        private System.Windows.Forms.Label Aducation_Label;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox Birthday;
        private System.Windows.Forms.Label Birthday_Label;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Password_Label;
    }
}