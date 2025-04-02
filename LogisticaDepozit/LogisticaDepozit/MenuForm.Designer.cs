namespace LogisticaDepozit
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.shoppingCartButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.startShoppingButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.productStockButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.addBalanceButton = new System.Windows.Forms.Button();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(295, 38);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(153, 38);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // shoppingCartButton
            // 
            this.shoppingCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartButton.Location = new System.Drawing.Point(287, 219);
            this.shoppingCartButton.Name = "shoppingCartButton";
            this.shoppingCartButton.Size = new System.Drawing.Size(189, 44);
            this.shoppingCartButton.TabIndex = 1;
            this.shoppingCartButton.Text = "Shopping Cart";
            this.shoppingCartButton.UseVisualStyleBackColor = true;
            this.shoppingCartButton.Click += new System.EventHandler(this.shoppingCartClicked);
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(599, 394);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(189, 44);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutClicked);
            // 
            // startShoppingButton
            // 
            this.startShoppingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startShoppingButton.Location = new System.Drawing.Point(287, 169);
            this.startShoppingButton.Name = "startShoppingButton";
            this.startShoppingButton.Size = new System.Drawing.Size(189, 44);
            this.startShoppingButton.TabIndex = 3;
            this.startShoppingButton.Text = "Start Shopping";
            this.startShoppingButton.UseVisualStyleBackColor = true;
            this.startShoppingButton.Click += new System.EventHandler(this.startShoppingClicked);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(287, 269);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(189, 44);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsClicked);
            // 
            // productStockButton
            // 
            this.productStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productStockButton.Location = new System.Drawing.Point(287, 319);
            this.productStockButton.Name = "productStockButton";
            this.productStockButton.Size = new System.Drawing.Size(189, 44);
            this.productStockButton.TabIndex = 5;
            this.productStockButton.Text = "Product Stock";
            this.productStockButton.UseVisualStyleBackColor = true;
            this.productStockButton.Click += new System.EventHandler(this.productStockClicked);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(295, 76);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(168, 38);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(659, 34);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(74, 22);
            this.balanceTextBox.TabIndex = 7;
            this.balanceTextBox.Text = "0.00 RON";
            // 
            // addBalanceButton
            // 
            this.addBalanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.addBalanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBalanceButton.Location = new System.Drawing.Point(739, 12);
            this.addBalanceButton.Name = "addBalanceButton";
            this.addBalanceButton.Size = new System.Drawing.Size(49, 46);
            this.addBalanceButton.TabIndex = 8;
            this.addBalanceButton.Text = "+";
            this.addBalanceButton.UseVisualStyleBackColor = false;
            this.addBalanceButton.Click += new System.EventHandler(this.addBalanceClicked);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(655, 12);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(70, 20);
            this.balanceLabel.TabIndex = 9;
            this.balanceLabel.Text = "Balance";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addBalanceButton);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.productStockButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.startShoppingButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.shoppingCartButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuFormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button shoppingCartButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button startShoppingButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button productStockButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button addBalanceButton;
        private System.Windows.Forms.Label balanceLabel;
    }
}