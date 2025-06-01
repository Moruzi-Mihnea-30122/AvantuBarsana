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
    public partial class VerifyChangeMail : Form
    {
        private readonly string email;
        private readonly string userId;
        private readonly VerificationManager verificationManager;
        private bool clicked;
        private DateTime lastResendTime = DateTime.MinValue;
        private Timer resendCooldownTimer;

        public VerifyChangeMail(string email, string userId, VerificationManager manager)
        {
            InitializeComponent();
            this.email = email;
            this.userId = userId;
            this.verificationManager = manager;

            btn_RESEND.Enabled = false;

            resendCooldownTimer = new Timer();
            resendCooldownTimer.Interval = 1000;
            resendCooldownTimer.Tick += new EventHandler(ResendCooldownTimer_Tick);
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            string inputCode = txtVerificationCode.Text;

            if (verificationManager.ValidateCode(email, inputCode))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(HomePageForm.connString))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("UPDATE Users SET Email = @newEmail WHERE UserID = @userID", conn);
                        cmd.Parameters.AddWithValue("@newEmail", email);
                        cmd.Parameters.AddWithValue("@userID", userId);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Email schimbat cu succes!");
                    clicked = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la schimbarea emailului: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Cod incorect sau expirat.");
            }
        }

        private void btn_RESEND_Click(object sender, EventArgs e)
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
            if ((DateTime.Now - lastResendTime).TotalSeconds >= 30)
            {
                btn_RESEND.Enabled = true;
                resendCooldownTimer.Stop();
            }
        }
    }

}
