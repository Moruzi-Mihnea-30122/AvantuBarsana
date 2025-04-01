using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn_SignUp
{
    public partial class Form2: Form
    {
        SqlConnection myCon = new SqlConnection();
        public Form2()
        {
            InitializeComponent();
            //Closes the App is the form is closed
            this.FormClosed += Form2_FormClosed;
            myCon.ConnectionString = @"data source=DESKTOP-8FI7P38\SQLEXPRESS;initial catalog=LogisticDB;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";
            myCon.Open();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 loginForm = Application.OpenForms["Form1"] as Form1; // Get existing Form1
            if (loginForm != null)
            {
                loginForm.Show(); // Show Form1 again
                this.Hide(); // Hide Form2
            }
            else
            {
                loginForm = new Form1(); // Create a new Form1 if it doesn't exist
                loginForm.Show();
                this.Hide(); // Hide Form2
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {

        }
    }
}
