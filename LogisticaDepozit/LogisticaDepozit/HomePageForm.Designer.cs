namespace LogisticaDepozit
{
    partial class HomePageForm
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
            this.btn_SignUpOpen = new System.Windows.Forms.Button();
            this.btn_LogInOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SignUpOpen
            // 
            this.btn_SignUpOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SignUpOpen.Location = new System.Drawing.Point(55, 235);
            this.btn_SignUpOpen.Name = "btn_SignUpOpen";
            this.btn_SignUpOpen.Size = new System.Drawing.Size(361, 35);
            this.btn_SignUpOpen.TabIndex = 5;
            this.btn_SignUpOpen.Text = "Sign Up";
            this.btn_SignUpOpen.UseVisualStyleBackColor = true;
            this.btn_SignUpOpen.Click += new System.EventHandler(this.btn_SignUpOpen_Click);
            // 
            // btn_LogInOpen
            // 
            this.btn_LogInOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogInOpen.Location = new System.Drawing.Point(55, 158);
            this.btn_LogInOpen.Name = "btn_LogInOpen";
            this.btn_LogInOpen.Size = new System.Drawing.Size(361, 35);
            this.btn_LogInOpen.TabIndex = 4;
            this.btn_LogInOpen.Text = "Log In";
            this.btn_LogInOpen.UseVisualStyleBackColor = true;
            this.btn_LogInOpen.Click += new System.EventHandler(this.btn_LogInOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to Avantu Barsana Logistics APP";
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 364);
            this.Controls.Add(this.btn_SignUpOpen);
            this.Controls.Add(this.btn_LogInOpen);
            this.Controls.Add(this.label1);
            this.Name = "HomePageForm";
            this.Text = "HomePageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePageForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SignUpOpen;
        private System.Windows.Forms.Button btn_LogInOpen;
        private System.Windows.Forms.Label label1;
    }
}