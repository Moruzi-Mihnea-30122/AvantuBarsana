using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticaDepozit
{
    public partial class AddManagerForm: Form
    {
        MenuForm menuForm;
        SqlConnection myCon = new SqlConnection(HomePageForm.connString);

        public AddManagerForm(MenuForm form)
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            this.menuForm = form;
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void addManagerButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "" || emailTextBox.Text == "" || label3.Text == "" || label4.Text == "")
            {
                MessageBox.Show("Completați toate câmpurile!");
                return;
            }

            if (!IsValidEmail(emailTextBox.Text))
            {
                MessageBox.Show("Emailul nu este valid!");
                return;
            }

            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
            {
                MessageBox.Show("Parola nu corespunde!");
                return;
            }
            myCon.Open();

            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Users (UserID, Password, Email, Role, Balance, Username)\nVALUES ('" + usernameTextBox.Text + "', '" + passwordTextBox.Text + "', '" + emailTextBox.Text + "', 'Manager', '99999', '" + usernameTextBox.Text + "');", myCon); ;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }

            myCon.Close();
            MessageBox.Show("Manager Added Succesfully");
            this.Close();
        }
    }
}
