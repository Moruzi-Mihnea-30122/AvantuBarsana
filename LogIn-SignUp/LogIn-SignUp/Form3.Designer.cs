﻿namespace LogIn_SignUp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtBox_UserS = new System.Windows.Forms.TextBox();
            this.txtBox_ConfPassS = new System.Windows.Forms.TextBox();
            this.txtBox_PassS = new System.Windows.Forms.TextBox();
            this.txtBox_MailS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBackS = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_UserS
            // 
            this.txtBox_UserS.Location = new System.Drawing.Point(24, 44);
            this.txtBox_UserS.Name = "txtBox_UserS";
            this.txtBox_UserS.Size = new System.Drawing.Size(119, 20);
            this.txtBox_UserS.TabIndex = 0;
            // 
            // txtBox_ConfPassS
            // 
            this.txtBox_ConfPassS.Location = new System.Drawing.Point(24, 142);
            this.txtBox_ConfPassS.Name = "txtBox_ConfPassS";
            this.txtBox_ConfPassS.Size = new System.Drawing.Size(119, 20);
            this.txtBox_ConfPassS.TabIndex = 1;
            this.txtBox_ConfPassS.UseSystemPasswordChar = true;
            // 
            // txtBox_PassS
            // 
            this.txtBox_PassS.Location = new System.Drawing.Point(24, 95);
            this.txtBox_PassS.Name = "txtBox_PassS";
            this.txtBox_PassS.Size = new System.Drawing.Size(119, 20);
            this.txtBox_PassS.TabIndex = 2;
            this.txtBox_PassS.UseSystemPasswordChar = true;
            // 
            // txtBox_MailS
            // 
            this.txtBox_MailS.Location = new System.Drawing.Point(199, 44);
            this.txtBox_MailS.Name = "txtBox_MailS";
            this.txtBox_MailS.Size = new System.Drawing.Size(119, 20);
            this.txtBox_MailS.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_Role
            // 
            this.comboBox_Role.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Role.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Role.FormattingEnabled = true;
            this.comboBox_Role.Items.AddRange(new object[] {
            "Manager",
            "Costumer"});
            this.comboBox_Role.Location = new System.Drawing.Point(199, 95);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Role.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Role";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(342, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBackS
            // 
            this.toolStripBackS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBackS.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBackS.Image")));
            this.toolStripBackS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBackS.Name = "toolStripBackS";
            this.toolStripBackS.Size = new System.Drawing.Size(23, 22);
            this.toolStripBackS.Text = "toolStripButton1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 259);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Role);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_MailS);
            this.Controls.Add(this.txtBox_PassS);
            this.Controls.Add(this.txtBox_ConfPassS);
            this.Controls.Add(this.txtBox_UserS);
            this.Name = "Form3";
            this.Text = "Sign Up";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_UserS;
        private System.Windows.Forms.TextBox txtBox_ConfPassS;
        private System.Windows.Forms.TextBox txtBox_PassS;
        private System.Windows.Forms.TextBox txtBox_MailS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBackS;
    }
}