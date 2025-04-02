using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
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



        private void submitButtonClicked(object sender, EventArgs e)
        {
            if (enterTextBox.Text == reenterTextBox.Text && enterTextBox != null)
            {
                if (enterTextBox.Text.Length > 7)
                {
                    myCon.ConnectionString = @"data source=DESKTOP-OSUV1BO\SQLEXPRESS;initial catalog=LogisticDB;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";
                    myCon.Open();

                    SqlCommand command = new SqlCommand("SELECT Username\nFROM Users\nWHERE Username NOT LIKE '" + this.menuPage.username + "';", myCon);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        if (this.infoToChange == "username")
                        {
                            try
                            {
                                command = new SqlCommand("UPDATE Users\nSET Username = '" + enterTextBox.Text + "'\nWHERE Username = '" + this.menuPage.username + "';", myCon);
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
                                MessageBox.Show("This username already exists");
                            }
                        }
                        if (this.infoToChange == "email")
                        {
                            if (IsValidEmail(enterTextBox.Text))
                            {
                                command = new SqlCommand("UPDATE Users\nSET Email = '" + enterTextBox.Text + "'\nWHERE Email = '" + this.menuPage.email + "';", myCon);
                                command.ExecuteNonQuery();
                                foreach (Control c in this.settingsPage.Controls)
                                {
                                    if (c.TabIndex == 7)
                                    {
                                        c.Text = enterTextBox.Text;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email");
                            }
                        }
                        if (this.infoToChange == "password")
                        {
                            command = new SqlCommand("UPDATE Users\nSET Password = '" + enterTextBox.Text + "'\nWHERE Password = '" + this.menuPage.password + "';", myCon);
                            command.ExecuteNonQuery();
                        }
                    }


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
