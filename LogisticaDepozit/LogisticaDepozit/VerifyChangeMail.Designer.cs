namespace LogisticaDepozit
{
    partial class VerifyChangeMail
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
            this.txtVerificationCode = new System.Windows.Forms.TextBox();
            this.btn_Verify = new System.Windows.Forms.Button();
            this.btn_RESEND = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.Location = new System.Drawing.Point(68, 78);
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.Size = new System.Drawing.Size(136, 20);
            this.txtVerificationCode.TabIndex = 0;
            // 
            // btn_Verify
            // 
            this.btn_Verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btn_Verify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Verify.ForeColor = System.Drawing.Color.White;
            this.btn_Verify.Location = new System.Drawing.Point(68, 113);
            this.btn_Verify.Name = "btn_Verify";
            this.btn_Verify.Size = new System.Drawing.Size(137, 29);
            this.btn_Verify.TabIndex = 1;
            this.btn_Verify.Text = "Confirm";
            this.btn_Verify.UseVisualStyleBackColor = false;
            this.btn_Verify.Click += new System.EventHandler(this.btn_Verify_Click);
            // 
            // btn_RESEND
            // 
            this.btn_RESEND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btn_RESEND.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RESEND.ForeColor = System.Drawing.Color.White;
            this.btn_RESEND.Location = new System.Drawing.Point(68, 148);
            this.btn_RESEND.Name = "btn_RESEND";
            this.btn_RESEND.Size = new System.Drawing.Size(137, 29);
            this.btn_RESEND.TabIndex = 2;
            this.btn_RESEND.Text = "Retrimite Email";
            this.btn_RESEND.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Verification Code";
            // 
            // VerifyChangeMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(291, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_RESEND);
            this.Controls.Add(this.btn_Verify);
            this.Controls.Add(this.txtVerificationCode);
            this.Name = "VerifyChangeMail";
            this.Text = "VerifyChangeMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVerificationCode;
        private System.Windows.Forms.Button btn_Verify;
        private System.Windows.Forms.Button btn_RESEND;
        private System.Windows.Forms.Label label1;
    }
}