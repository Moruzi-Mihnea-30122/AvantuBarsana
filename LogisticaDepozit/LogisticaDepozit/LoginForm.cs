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

namespace LogisticaDepozit
{
    public partial class LoginForm: Form
    {
        internal SqlConnection myCon = new SqlConnection();
        public LoginForm()
        {
            myCon.ConnectionString = HomePageForm.connString;
            InitializeComponent();
            this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
            this.MaximumSize = new Size(this.Size.Width, this.Size.Height);

        }

        private void loginButtonClick(object sender, EventArgs e)
        {
            
            myCon.Open();

            SqlCommand command = new SqlCommand("SELECT Username, Password\nFROM Users\nWHERE Username LIKE '" + usernameLoginTextBox.Text + "' AND Password LIKE '" + passwordLoginTextBox.Text + "';", myCon);
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show("Username or Password Incorrect");
            }
            else
            {
                MenuForm meniu = new MenuForm(this,0,null);
                meniu.Show();
                this.Hide();
            }

            myCon.Close();
            reader.Close();
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePageForm loginForm = Application.OpenForms["Form1"] as HomePageForm; // Get existing Form1
            if (loginForm != null)
            {
                loginForm.Show(); // Show Form1 again
                this.Hide(); // Hide Form2
            }
            else
            {
                loginForm = new HomePageForm(); // Create a new Form1 if it doesn't exist
                loginForm.Show();
                this.Hide(); // Hide Form2
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
