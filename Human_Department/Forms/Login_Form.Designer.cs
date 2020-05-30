namespace Human_Department
{
    partial class Login_Form
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
            this.Main_Login_Panel = new System.Windows.Forms.Panel();
            this.Close_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.User_Name_Label = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_Title = new System.Windows.Forms.Label();
            this.Main_Login_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_Login_Panel
            // 
            this.Main_Login_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Main_Login_Panel.BackgroundImage = global::Human_Department.Properties.Resources.Login_BG;
            this.Main_Login_Panel.Controls.Add(this.Close_Label);
            this.Main_Login_Panel.Controls.Add(this.Password_Label);
            this.Main_Login_Panel.Controls.Add(this.User_Name_Label);
            this.Main_Login_Panel.Controls.Add(this.Login_Button);
            this.Main_Login_Panel.Controls.Add(this.Password);
            this.Main_Login_Panel.Controls.Add(this.pictureBox2);
            this.Main_Login_Panel.Controls.Add(this.Login);
            this.Main_Login_Panel.Controls.Add(this.pictureBox1);
            this.Main_Login_Panel.Controls.Add(this.Login_Title);
            this.Main_Login_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Login_Panel.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Login_Panel.Location = new System.Drawing.Point(0, 0);
            this.Main_Login_Panel.Name = "Main_Login_Panel";
            this.Main_Login_Panel.Size = new System.Drawing.Size(476, 415);
            this.Main_Login_Panel.TabIndex = 0;
            this.Main_Login_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.Main_Login_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_MouseMove);
            // 
            // Close_Label
            // 
            this.Close_Label.AutoSize = true;
            this.Close_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Label.ForeColor = System.Drawing.Color.White;
            this.Close_Label.Location = new System.Drawing.Point(434, 0);
            this.Close_Label.Name = "Close_Label";
            this.Close_Label.Size = new System.Drawing.Size(36, 44);
            this.Close_Label.TabIndex = 8;
            this.Close_Label.Text = "x";
            this.Close_Label.Click += new System.EventHandler(this.Close_Label_Click);
            this.Close_Label.MouseLeave += new System.EventHandler(this.Close_Label_MouseLeave);
            this.Close_Label.MouseHover += new System.EventHandler(this.Close_Label_MouseHover);
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Password_Label.Location = new System.Drawing.Point(130, 216);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(101, 26);
            this.Password_Label.TabIndex = 7;
            this.Password_Label.Text = "Password";
            // 
            // User_Name_Label
            // 
            this.User_Name_Label.AutoSize = true;
            this.User_Name_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.User_Name_Label.Location = new System.Drawing.Point(130, 120);
            this.User_Name_Label.Name = "User_Name_Label";
            this.User_Name_Label.Size = new System.Drawing.Size(118, 26);
            this.User_Name_Label.TabIndex = 6;
            this.User_Name_Label.Text = "User_Name";
            // 
            // Login_Button
            // 
            this.Login_Button.BackColor = System.Drawing.Color.Turquoise;
            this.Login_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_Button.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.Login_Button.FlatAppearance.BorderSize = 2;
            this.Login_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.Login_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.Login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Button.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_Button.Location = new System.Drawing.Point(135, 336);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(172, 52);
            this.Login_Button.TabIndex = 5;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Turquoise;
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(135, 245);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(239, 38);
            this.Password.TabIndex = 4;
            this.Password.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Human_Department.Properties.Resources.Lock;
            this.pictureBox2.InitialImage = global::Human_Department.Properties.Resources.User;
            this.pictureBox2.Location = new System.Drawing.Point(56, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Turquoise;
            this.Login.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(135, 148);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(239, 38);
            this.Login.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Human_Department.Properties.Resources.User;
            this.pictureBox1.InitialImage = global::Human_Department.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(56, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Title
            // 
            this.Login_Title.BackColor = System.Drawing.Color.Transparent;
            this.Login_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Login_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login_Title.Location = new System.Drawing.Point(0, 0);
            this.Login_Title.Name = "Login_Title";
            this.Login_Title.Size = new System.Drawing.Size(476, 109);
            this.Login_Title.TabIndex = 0;
            this.Login_Title.Text = "Authorization";
            this.Login_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.Login_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_MouseMove);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 415);
            this.Controls.Add(this.Main_Login_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.Main_Login_Panel.ResumeLayout(false);
            this.Main_Login_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_Login_Panel;
        private System.Windows.Forms.Label Login_Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Label User_Name_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Label Close_Label;
    }
}