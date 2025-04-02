﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticaDepozit
{
    public partial class MenuForm: Form
    {
        private LoginForm loginPage;
        private SettingsForm settingsPage;
        private SqlConnection myCon = new SqlConnection();
        private DataSet dsUsers;

        // accesibile de catre orice clasa din proiectul curent

        internal string username;
        internal string role;
        internal string password;
        internal string email;
        internal double balance;
        internal int cartId;
        
        public MenuForm(LoginForm form)
        {
            this.loginPage = form;
            InitializeComponent();

            myCon.ConnectionString = @"data source=DESKTOP-OSUV1BO\SQLEXPRESS;initial catalog=LogisticDB;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";

            this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
            this.MaximumSize = new Size(this.Size.Width, this.Size.Height);

            try
            {
                foreach (Control c in this.loginPage.Controls)
                {
                    if (c is TextBox && c.TabIndex == 6)
                    {
                        this.username = c.Text;
                    }
                }

                usernameLabel.Text = username.ToString();

                myCon.Open();

                SqlCommand command = new SqlCommand("SELECT *\nFROM Users\nWHERE Username LIKE '"+ this.username +"';",myCon);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    this.password = reader.GetString(1);
                    this.email = reader.GetString(2);
                    this.role = reader.GetString(3);
                    this.balance = Convert.ToDouble(reader.GetString(4));
                    if (!reader.IsDBNull(5))
                    {
                        this.cartId = Convert.ToInt32(reader.GetString(5));
                    }
                }

                if (this.role != "Manager")
                {
                    this.Controls.Remove(productStockButton);
                }

                this.balanceTextBox.Text = this.balance.ToString() + " RON";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }

            myCon.Close();
        }

        private void settingsClicked(object sender, EventArgs e)
        {
            settingsPage = new SettingsForm(this);
            settingsPage.Show();
        }

        private void startShoppingClicked(object sender, EventArgs e)
        {

        }

        private void shoppingCartClicked(object sender, EventArgs e)
        {

        }

        private void addBalanceClicked(object sender, EventArgs e)
        {

        }

        private void productStockClicked(object sender, EventArgs e)
        {

        }

        private void logOutClicked(object sender, EventArgs e)
        {
            username = null;
            role = null;
            password = null;
            email = null;
            balance = 0;
            cartId = 0;
            loginPage.Show();

            foreach (Control c in this.loginPage.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = null;
                }
            }

            this.Close();
        }

        private void MenuFormClosing(object sender, FormClosingEventArgs e)
        {
            loginPage.Show();
        }

    }
}
