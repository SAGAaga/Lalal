namespace Human_Department
{
    partial class Start_Form
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
            this.Start_Panel = new System.Windows.Forms.Panel();
            this.Start_Login = new System.Windows.Forms.Label();
            this.Start_Add_User = new System.Windows.Forms.Label();
            this.Start_Login_Picture = new System.Windows.Forms.PictureBox();
            this.Start_Add_User_Picture = new System.Windows.Forms.PictureBox();
            this.Start_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start_Login_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_Add_User_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_Panel
            // 
            this.Start_Panel.BackgroundImage = global::Human_Department.Properties.Resources.Login_BG;
            this.Start_Panel.Controls.Add(this.Start_Login);
            this.Start_Panel.Controls.Add(this.Start_Add_User);
            this.Start_Panel.Controls.Add(this.Start_Login_Picture);
            this.Start_Panel.Controls.Add(this.Start_Add_User_Picture);
            this.Start_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Start_Panel.Location = new System.Drawing.Point(0, 0);
            this.Start_Panel.Name = "Start_Panel";
            this.Start_Panel.Size = new System.Drawing.Size(411, 177);
            this.Start_Panel.TabIndex = 0;
            // 
            // Start_Login
            // 
            this.Start_Login.AutoSize = true;
            this.Start_Login.BackColor = System.Drawing.Color.Transparent;
            this.Start_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_Login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Start_Login.Location = new System.Drawing.Point(276, 118);
            this.Start_Login.Name = "Start_Login";
            this.Start_Login.Size = new System.Drawing.Size(65, 25);
            this.Start_Login.TabIndex = 7;
            this.Start_Login.Text = "Login";
            this.Start_Login.Click += new System.EventHandler(this.Start_Login_Click);
            // 
            // Start_Add_User
            // 
            this.Start_Add_User.AutoSize = true;
            this.Start_Add_User.BackColor = System.Drawing.Color.Transparent;
            this.Start_Add_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Add_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_Add_User.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Start_Add_User.Location = new System.Drawing.Point(29, 118);
            this.Start_Add_User.Name = "Start_Add_User";
            this.Start_Add_User.Size = new System.Drawing.Size(162, 25);
            this.Start_Add_User.TabIndex = 6;
            this.Start_Add_User.Text = "Add_New_User";
            this.Start_Add_User.Click += new System.EventHandler(this.Start_Add_User_Click);
            // 
            // Start_Login_Picture
            // 
            this.Start_Login_Picture.BackColor = System.Drawing.Color.Transparent;
            this.Start_Login_Picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Login_Picture.Image = global::Human_Department.Properties.Resources.Login;
            this.Start_Login_Picture.InitialImage = global::Human_Department.Properties.Resources.User;
            this.Start_Login_Picture.Location = new System.Drawing.Point(279, 40);
            this.Start_Login_Picture.Name = "Start_Login_Picture";
            this.Start_Login_Picture.Size = new System.Drawing.Size(64, 64);
            this.Start_Login_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Start_Login_Picture.TabIndex = 5;
            this.Start_Login_Picture.TabStop = false;
            this.Start_Login_Picture.Click += new System.EventHandler(this.Start_Login_Picture_Click);
            // 
            // Start_Add_User_Picture
            // 
            this.Start_Add_User_Picture.BackColor = System.Drawing.Color.Transparent;
            this.Start_Add_User_Picture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Add_User_Picture.Image = global::Human_Department.Properties.Resources.Add_User;
            this.Start_Add_User_Picture.InitialImage = global::Human_Department.Properties.Resources.User;
            this.Start_Add_User_Picture.Location = new System.Drawing.Point(32, 40);
            this.Start_Add_User_Picture.Name = "Start_Add_User_Picture";
            this.Start_Add_User_Picture.Size = new System.Drawing.Size(64, 51);
            this.Start_Add_User_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Start_Add_User_Picture.TabIndex = 4;
            this.Start_Add_User_Picture.TabStop = false;
            this.Start_Add_User_Picture.Click += new System.EventHandler(this.Start_Add_User_Picture_Click);
            // 
            // Start_Form
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 177);
            this.Controls.Add(this.Start_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Start_Form";
            this.Text = "Start_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Start_Form_FormClosed);
            this.Start_Panel.ResumeLayout(false);
            this.Start_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start_Login_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Start_Add_User_Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Start_Panel;
        private System.Windows.Forms.PictureBox Start_Login_Picture;
        private System.Windows.Forms.PictureBox Start_Add_User_Picture;
        private System.Windows.Forms.Label Start_Add_User;
        private System.Windows.Forms.Label Start_Login;
    }
}