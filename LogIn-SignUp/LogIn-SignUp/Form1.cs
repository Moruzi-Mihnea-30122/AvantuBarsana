using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn_SignUp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_LogInOpen_Click(object sender, EventArgs e)
        {
            
            Form2 logIn = new Form2();
            this.Hide();
            logIn.Show();
            
        }

        private void btn_SignUpOpen_Click(object sender, EventArgs e)
        {
            Form3 logIn = new Form3();
            this.Hide();
            logIn.Show();
        }
    }
}
