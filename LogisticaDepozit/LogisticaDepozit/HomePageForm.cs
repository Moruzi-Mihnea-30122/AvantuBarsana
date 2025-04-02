using LogisticaDepozit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticaDepozit
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();

            this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
            this.MaximumSize = new Size(this.Size.Width, this.Size.Height);
        }

        private void btn_LogInOpen_Click(object sender, EventArgs e)
        {

            LoginForm logIn = new LoginForm();
            this.Hide();
            logIn.Show();

        }

        private void btn_SignUpOpen_Click(object sender, EventArgs e)
        {
            SignUpForm logIn = new SignUpForm();
            logIn.Show();
        }

        private void HomePageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
