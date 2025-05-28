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
    public partial class VerificationForm : Form
    {
        private readonly string email;
        private readonly string username;
        private readonly string hashedPassword;
        private readonly VerificationManager verificationManager;
        private bool clicked;
        private DateTime lastResendTime = DateTime.MinValue;
        private Timer resendCooldownTimer;
        //private Button btnResend;

        public VerificationForm(string email, VerificationManager manager, string username, string hashedPassword)
        {
            InitializeComponent();
            this.email = email;
            this.username = username;
            this.hashedPassword = hashedPassword;
            this.verificationManager = manager;
            //btn_RESEND.Enabled = false;



            resendCooldownTimer = new Timer();
            resendCooldownTimer.Interval = 1000;
            resendCooldownTimer.Tick += new EventHandler(ResendCooldownTimer_Tick); // FIX: asigură conectarea evenimentului
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string inputCode = txtVerificationCode.Text;

            if (verificationManager.ValidateCode(email, inputCode))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(HomePageForm.connString))
                    {
                        conn.Open();

                        SqlCommand cmd1 = new SqlCommand("Select * FROM Users", conn);
                        SqlDataReader reader1 = cmd1.ExecuteReader();
                        string role = "Owner";
                        if (reader1.Read()) { role = "Customer"; }
                        reader1.Close();

                        string query = "INSERT INTO Users (UserID, Password, Email, Role, Balance, Username) VALUES (@userID, @password, @email, @role, @balance, @username)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@userID", username);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@balance", role == "Owner" ? 1000000 : 0);

                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    MessageBox.Show("Cont creat cu succes!");
                    clicked = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la salvarea utilizatorului: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Cod incorect sau expirat.");
            }
        }

        private void btnResend_Click(object sender, EventArgs e)
        {
            TimeSpan timeSinceLastResend = DateTime.Now - lastResendTime;
            if (timeSinceLastResend.TotalSeconds < 30)
            {
                int secondsLeft = 30 - (int)timeSinceLastResend.TotalSeconds;
                MessageBox.Show($"Poți retrimite codul după {secondsLeft} secunde.");
                return;
            }

            string newCode = verificationManager.GenerateVerificationCode(email);
            EmailService emailService = new EmailService();

            if (emailService.SendVerificationCode(email, newCode))
            {
                MessageBox.Show("Codul a fost retrimis cu succes.");
                lastResendTime = DateTime.Now;
                btn_RESEND.Enabled = false;
                resendCooldownTimer.Start();
            }
            else
            {
                MessageBox.Show("Eroare la retrimiterea codului.");
            }
        }

        private void ResendCooldownTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Timer tick"); // debug vizual

            if ((DateTime.Now - lastResendTime).TotalSeconds >= 30)
            {
                btn_RESEND.Enabled = true;
                resendCooldownTimer.Stop();
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            if (clicked)
            {
                new LoginForm().Show();
            }
            else
            {
                new SignUpForm().Show();
            }
        }
    }
}
