using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Human_Department.Models;

namespace Human_Department
{
    public partial class Start_Form : Form
    {
        public Start_Form()
        {
            InitializeComponent();
        }

        private void Start_Login_Picture_Click(object sender, EventArgs e)
        {
            var LF = new Login_Form();
            LF.Show();
            this.Hide();
        }

        private void Start_Login_Click(object sender, EventArgs e)
        {
            var LF = new Login_Form();
            LF.Show();
            this.Hide();
        }

        private void Start_Add_User_Picture_Click(object sender, EventArgs e)
        {
            var LF = new Adding_Form();
            LF.Show();
            this.Hide();
        }

        private void Start_Add_User_Click(object sender, EventArgs e)
        {
            var LF = new Adding_Form();
            LF.Show();
            this.Hide();
        }

        private void Start_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
