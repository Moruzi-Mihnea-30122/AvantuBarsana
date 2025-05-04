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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orderManagerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Yellow;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.welcomeLabel.Location = new System.Drawing.Point(332, 48);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(188, 46);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome";
            // 
            // shoppingCartButton
            // 
            this.shoppingCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.shoppingCartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingCartButton.ForeColor = System.Drawing.Color.White;
            this.shoppingCartButton.Location = new System.Drawing.Point(323, 274);
            this.shoppingCartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shoppingCartButton.Name = "shoppingCartButton";
            this.shoppingCartButton.Size = new System.Drawing.Size(213, 55);
            this.shoppingCartButton.TabIndex = 1;
            this.shoppingCartButton.Text = "View Orders";
            this.shoppingCartButton.UseVisualStyleBackColor = false;
            this.shoppingCartButton.Click += new System.EventHandler(this.shoppingCartClicked);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(674, 492);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(213, 55);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutClicked);
            // 
            // startShoppingButton
            // 
            this.startShoppingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.startShoppingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startShoppingButton.ForeColor = System.Drawing.Color.White;
            this.startShoppingButton.Location = new System.Drawing.Point(323, 211);
            this.startShoppingButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startShoppingButton.Name = "startShoppingButton";
            this.startShoppingButton.Size = new System.Drawing.Size(213, 55);
            this.startShoppingButton.TabIndex = 3;
            this.startShoppingButton.Text = "Start Shopping";
            this.startShoppingButton.UseVisualStyleBackColor = false;
            this.startShoppingButton.Click += new System.EventHandler(this.startShoppingClicked);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.White;
            this.settingsButton.Location = new System.Drawing.Point(323, 336);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(213, 55);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsClicked);
            // 
            // productStockButton
            // 
            this.productStockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.productStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productStockButton.ForeColor = System.Drawing.Color.White;
            this.productStockButton.Location = new System.Drawing.Point(323, 399);
            this.productStockButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productStockButton.Name = "productStockButton";
            this.productStockButton.Size = new System.Drawing.Size(213, 55);
            this.productStockButton.TabIndex = 5;
            this.productStockButton.Text = "Product Stock";
            this.productStockButton.UseVisualStyleBackColor = false;
            this.productStockButton.Click += new System.EventHandler(this.productStockClicked);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.usernameLabel.Location = new System.Drawing.Point(332, 95);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(203, 46);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(741, 42);
            this.balanceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(83, 26);
            this.balanceTextBox.TabIndex = 7;
            this.balanceTextBox.Text = "0.00 RON";
            // 
            // addBalanceButton
            // 
            this.addBalanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.addBalanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBalanceButton.ForeColor = System.Drawing.Color.White;
            this.addBalanceButton.Location = new System.Drawing.Point(831, 15);
            this.addBalanceButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addBalanceButton.Name = "addBalanceButton";
            this.addBalanceButton.Size = new System.Drawing.Size(55, 58);
            this.addBalanceButton.TabIndex = 8;
            this.addBalanceButton.Text = "+";
            this.addBalanceButton.UseVisualStyleBackColor = false;
            this.addBalanceButton.Click += new System.EventHandler(this.addBalanceClicked);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.balanceLabel.Location = new System.Drawing.Point(737, 15);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(90, 25);
            this.balanceLabel.TabIndex = 9;
            this.balanceLabel.Text = "Balance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 122);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // orderManagerButton
            // 
            this.orderManagerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.orderManagerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderManagerButton.ForeColor = System.Drawing.Color.White;
            this.orderManagerButton.Location = new System.Drawing.Point(323, 462);
            this.orderManagerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderManagerButton.Name = "orderManagerButton";
            this.orderManagerButton.Size = new System.Drawing.Size(213, 55);
            this.orderManagerButton.TabIndex = 11;
            this.orderManagerButton.Text = "Order Manager";
            this.orderManagerButton.UseVisualStyleBackColor = false;
            this.orderManagerButton.Click += new System.EventHandler(this.orderManagerButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.orderManagerButton);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button orderManagerButton;
    }
}