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
    public partial class VerificationForm : Form
    {
        private string email;
        private VerificationManager verificationManager;

        public VerificationForm(string email, VerificationManager verificationManager)
        {
            InitializeComponent();
            this.email = email;
            this.verificationManager = verificationManager;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string inputCode = txtVerificationCode.Text;

            if (verificationManager.ValidateCode(email, inputCode))
            {
                MessageBox.Show("Verificare reușită!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cod incorect sau expirat.");
            }
        }
    }
}
