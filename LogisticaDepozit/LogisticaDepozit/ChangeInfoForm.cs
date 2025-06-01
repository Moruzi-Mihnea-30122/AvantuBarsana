using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LogisticaDepozit
{
    public partial class ChangeInfoForm: Form
    {

        private SettingsForm settingsPage;
        private MenuForm menuPage;
        private string infoToChange;
        private SqlConnection myCon = new SqlConnection();
        public ChangeInfoForm(SettingsForm settingsPage, MenuForm menuPage, string infoToChange)
        {
            InitializeComponent();
            this.settingsPage = settingsPage;
            this.infoToChange = infoToChange;
            this.menuPage = menuPage;

            enter.Text = "Enter " + this.infoToChange;
            reenter.Text = "Re-Enter " + this.infoToChange;

            this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
            this.MaximumSize = new Size(this.Size.Width, this.Size.Height);

            if (this.infoToChange == "password")
            {
                this.enterTextBox.UseSystemPasswordChar = true;
                this.reenterTextBox.UseSystemPasswordChar = true;
            }
        }
        /*
        static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        */
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^\p{So}\p{Cn}\s@]+@[^@\s]+\.(ro|com)$";
            return Regex.IsMatch(email, pattern);
        }
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



        private void submitButtonClicked(object sender, EventArgs e)
        {
            if (enterTextBox.Text == reenterTextBox.Text && enterTextBox != null)
            {
                if (enterTextBox.Text.Length > 7)
                {
                    SqlConnection myCon2 = new SqlConnection(connectionString: HomePageForm.connString);
                    myCon.ConnectionString = HomePageForm.connString;
                    myCon.Open();
                    myCon2.Open();

                    SqlCommand command = new SqlCommand("SELECT Username\nFROM Users\nWHERE UserID LIKE '" + this.menuPage.userID + "';", myCon2);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        if (this.infoToChange == "username")
                        {
                            try
                            {
                                command = new SqlCommand("UPDATE Users\nSET Username = '" + enterTextBox.Text + "'\nWHERE UserID = '" + this.menuPage.userID + "';", myCon);
                                command.ExecuteNonQuery();
                                

                                foreach(Control c in this.settingsPage.Controls)
                                {
                                    if(c.TabIndex == 6)
                                    {
                                        c.Text = enterTextBox.Text;
                                    }
                                }
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        if (this.infoToChange == "email")
                        {
                            if (IsValidEmail(enterTextBox.Text))
                            {
                                string newEmail = enterTextBox.Text.Trim();
                                VerificationManager verificationManager = new VerificationManager();
                                string code = verificationManager.GenerateVerificationCode(newEmail);
                                EmailService emailService = new EmailService();

                                if (emailService.SendVerificationCode(newEmail, code))
                                {
                                    MessageBox.Show("Un cod de verificare a fost trimis la noua adresă.");
                                    var verifyForm = new VerifyChangeMail(newEmail, this.menuPage.userID, verificationManager);
                                    verifyForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Eroare la trimiterea codului de verificare.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email invalid.");
                            }

                            return; // ieșim ca să nu se mai închidă formularul înainte de verificare
                        }

                        if (this.infoToChange == "password")
                        {
                            string hashedPassword = HashPassword(enterTextBox.Text);
                            command = new SqlCommand("UPDATE Users\nSET Password = '" + hashedPassword + "'\nWHERE UserID = '" + this.menuPage.userID + "';", myCon);
                            command.ExecuteNonQuery();
                        }
                    }

                    myCon2.Close();
                    myCon.Close();
                }
                else
                    MessageBox.Show("More than 7 characters required");
            }
            else
                MessageBox.Show("The two " + this.infoToChange + "s are not matching");
            this.Close();
        }
    }
}
