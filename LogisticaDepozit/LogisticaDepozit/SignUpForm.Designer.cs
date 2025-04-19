﻿namespace LogisticaDepozit
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBackS = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Role = new System.Windows.Forms.ComboBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_MailS = new System.Windows.Forms.TextBox();
            this.txtBox_PassS = new System.Windows.Forms.TextBox();
            this.txtBox_ConfPassS = new System.Windows.Forms.TextBox();
            this.txtBox_UserS = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBackS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(457, 27);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // toolStripBackS
            // 
            this.toolStripBackS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBackS.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBackS.Image")));
            this.toolStripBackS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBackS.Name = "toolStripBackS";
            this.toolStripBackS.Size = new System.Drawing.Size(29, 24);
            this.toolStripBackS.Text = "toolStripButton1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Role";
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
            this.comboBox_Role.Location = new System.Drawing.Point(263, 147);
            this.comboBox_Role.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Role.Name = "comboBox_Role";
            this.comboBox_Role.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Role.TabIndex = 21;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(30, 255);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(392, 38);
            this.signUpButton.TabIndex = 20;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Username";
            // 
            // txtBox_MailS
            // 
            this.txtBox_MailS.Location = new System.Drawing.Point(263, 84);
            this.txtBox_MailS.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_MailS.Name = "txtBox_MailS";
            this.txtBox_MailS.Size = new System.Drawing.Size(157, 22);
            this.txtBox_MailS.TabIndex = 15;
            // 
            // txtBox_PassS
            // 
            this.txtBox_PassS.Location = new System.Drawing.Point(30, 147);
            this.txtBox_PassS.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_PassS.Name = "txtBox_PassS";
            this.txtBox_PassS.Size = new System.Drawing.Size(157, 22);
            this.txtBox_PassS.TabIndex = 14;
            this.txtBox_PassS.UseSystemPasswordChar = true;
            // 
            // txtBox_ConfPassS
            // 
            this.txtBox_ConfPassS.Location = new System.Drawing.Point(30, 205);
            this.txtBox_ConfPassS.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_ConfPassS.Name = "txtBox_ConfPassS";
            this.txtBox_ConfPassS.Size = new System.Drawing.Size(157, 22);
            this.txtBox_ConfPassS.TabIndex = 13;
            this.txtBox_ConfPassS.UseSystemPasswordChar = true;
            // 
            // txtBox_UserS
            // 
            this.txtBox_UserS.Location = new System.Drawing.Point(30, 84);
            this.txtBox_UserS.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_UserS.Name = "txtBox_UserS";
            this.txtBox_UserS.Size = new System.Drawing.Size(157, 22);
            this.txtBox_UserS.TabIndex = 12;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(457, 316);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Role);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_MailS);
            this.Controls.Add(this.txtBox_PassS);
            this.Controls.Add(this.txtBox_ConfPassS);
            this.Controls.Add(this.txtBox_UserS);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBackS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Role;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_MailS;
        private System.Windows.Forms.TextBox txtBox_PassS;
        private System.Windows.Forms.TextBox txtBox_ConfPassS;
        private System.Windows.Forms.TextBox txtBox_UserS;
    }
}