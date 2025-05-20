using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

<<<<<<< Updated upstream:LogIn-SignUp/LogIn-SignUp/Form3.cs

namespace LogIn_SignUp
=======
namespace LogisticaDepozit
>>>>>>> Stashed changes:LogisticaDepozit/LogisticaDepozit/SignUpForm.cs
{
    public partial class Form3 : Form
    {
        SqlConnection myCon = new SqlConnection();
        private EmailService emailService;
        private VerificationManager verificationManager;
        private string verificationCode;
        private string userEmail;

        public Form3()
        {
            InitializeComponent();
<<<<<<< Updated upstream:LogIn-SignUp/LogIn-SignUp/Form3.cs
=======
            emailService = new EmailService();
            verificationManager = new VerificationManager();

            this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
            this.MaximumSize = new Size(this.Size.Width, this.Size.Height);

>>>>>>> Stashed changes:LogisticaDepozit/LogisticaDepozit/SignUpForm.cs
            this.FormClosed += Form3_FormClosed;
            myCon.ConnectionString = @"data source=DESKTOP-8FI7P38\SQLEXPRESS;initial catalog=LogisticDB;integrated security=True;encrypt=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^\p{So}\p{Cn}\s@]+@[^@\s]+\.(ro|com)$";
            return Regex.IsMatch(email, pattern);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string hashedPassword = HashPassword(txtBox_PassS.Text);
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

            if (txtBox_PassS.Text.Length < 8)
            {
                MessageBox.Show("Parola trebuie să aibă minim 8 caractere!");
                return;
            }

            if (txtBox_UserS.Text.Length < 6)
            {
                MessageBox.Show("Username-ul trebuie sa aiba minim 6 caractere");
                return;
            }
            userEmail = txtBox_MailS.Text;
            verificationCode = verificationManager.GenerateVerificationCode(userEmail);

            if (emailService.SendVerificationCode(userEmail, verificationCode))
            {
                VerificationForm verificationForm = new VerificationForm(userEmail, verificationManager);
                verificationForm.Show();
                this.Hide();
            }
<<<<<<< Updated upstream:LogIn-SignUp/LogIn-SignUp/Form3.cs
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la inserare: " + ex.Message);
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
=======
            else
            {
                MessageBox.Show("Eroare la trimiterea email-ului.");
            }
        }

        private void toolStripBackS_Click(object sender, EventArgs e)
        {

        }
>>>>>>> Stashed changes:LogisticaDepozit/LogisticaDepozit/SignUpForm.cs
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