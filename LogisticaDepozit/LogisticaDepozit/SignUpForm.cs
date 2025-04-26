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
            myCon.ConnectionString = @"Data Source=DESKTOP-QUDR49C;Initial Catalog=LogisticDB;Integrated Security=True;Connect Timeout=30;Encrypt=False";
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
            if (txtBox_UserS.Text == "" || txtBox_MailS.Text == "" || txtBox_PassS.Text == "" || txtBox_ConfPassS.Text == "" || comboBox_Role.Text == "")
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
                string query = "INSERT INTO Users (Username, Password, Email, Role, Balance, CartID) VALUES (@username, @password, @email, @role, @balance, @cartid)";
                SqlCommand cmd = new SqlCommand(query, myCon);
                cmd.Parameters.AddWithValue("@username", txtBox_UserS.Text);
                cmd.Parameters.AddWithValue("@password", txtBox_PassS.Text);
                cmd.Parameters.AddWithValue("@email", txtBox_MailS.Text);
                cmd.Parameters.AddWithValue("@role", comboBox_Role.Text);
                cmd.Parameters.AddWithValue("@balance", comboBox_Role.Text == "Manager" ? 1000000 : 0);
                cmd.Parameters.AddWithValue("@cartid", DBNull.Value); // Sau setează un ID valid

                cmd.ExecuteNonQuery();
                myCon.Close();

                MessageBox.Show("Cont creat cu succes!");
                this.Hide();
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
