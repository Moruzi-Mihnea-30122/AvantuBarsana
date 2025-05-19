using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;


namespace LogisticaDepozit
{
    public partial class SignUpForm : Form
    {
        SqlConnection myCon = new SqlConnection();

        public SignUpForm()
        {
            InitializeComponent();

            this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
            this.MaximumSize = new Size(this.Size.Width, this.Size.Height);

            this.FormClosed += Form3_FormClosed;
            myCon.ConnectionString = HomePageForm.connString;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }


        private void signUpButtonClick(object sender, EventArgs e)
        {
            if (txtBox_UserS.Text == "" || txtBox_MailS.Text == "" || txtBox_PassS.Text == "" || txtBox_ConfPassS.Text == "" )
            {
                MessageBox.Show("Completați toate câmpurile!");
                return;
            }

            if (!IsValidEmail(txtBox_MailS.Text))
            {
                MessageBox.Show("Emailul nu este valid!");
                return;
            }

            if (txtBox_PassS.Text != txtBox_ConfPassS.Text)
            {
                MessageBox.Show("Parola nu corespunde!");
                return;
            }

            try
            {
                //string hashedPassword = HashPassword(txtBox_PassS.Text);

                myCon.Open();

                SqlCommand cmd1 = new SqlCommand("Select * FROM Users", myCon);
                SqlDataReader reader1 = cmd1.ExecuteReader();
                string role = "Manager";
                if (reader1.Read()) { role = "Customer"; }
                reader1.Close();

                string query = "INSERT INTO Users (UserID, Password, Email, Role, Balance, Username) VALUES (@userID, @password, @email, @role, @balance, @username)";
                SqlCommand cmd = new SqlCommand(query, myCon);
                cmd.Parameters.AddWithValue("@userID", txtBox_UserS.Text);
                cmd.Parameters.AddWithValue("@username", txtBox_UserS.Text);
                cmd.Parameters.AddWithValue("@password", txtBox_PassS.Text);
                cmd.Parameters.AddWithValue("@email", txtBox_MailS.Text);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@balance", role == "Manager" ? 1000000 : 0);

                cmd.ExecuteNonQuery();
                myCon.Close();

                MessageBox.Show("Cont creat cu succes!");
                this.Hide();
                LoginForm loginFrom = new LoginForm();
                loginFrom.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la inserare: " + ex.Message);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePageForm signUpForm = Application.OpenForms["Form1"] as HomePageForm; // Get existing Form1
            if (signUpForm != null)
            {
                signUpForm.Show(); // Show Form1 again
                this.Hide(); // Hide Form2
            }
            else
            {
                signUpForm = new HomePageForm(); // Create a new Form1 if it doesn't exist
                signUpForm.Show();
                this.Hide(); // Hide Form2
            }
        }

        /*
                private string HashPassword(string password)
                {
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                        StringBuilder builder = new StringBuilder();
                        foreach (byte b in bytes)
                        {
                            builder.Append(b.ToString("x2"));
                        }
                        return builder.ToString();
                    }
                }
            }
        */
    }
}
