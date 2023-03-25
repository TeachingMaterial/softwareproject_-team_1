namespace Student_Management_System
{
    partial class OTPform
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
            this.HomePageLink = new System.Windows.Forms.Button();
            this.OTPprompt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HomePageLink
            // 
            this.HomePageLink.Location = new System.Drawing.Point(326, 246);
            this.HomePageLink.Name = "HomePageLink";
            this.HomePageLink.Size = new System.Drawing.Size(135, 38);
            this.HomePageLink.TabIndex = 0;
            this.HomePageLink.Text = "Login";
            this.HomePageLink.UseVisualStyleBackColor = true;
            // 
            // OTPprompt
            // 
            this.OTPprompt.AutoSize = true;
            this.OTPprompt.Location = new System.Drawing.Point(23, 173);
            this.OTPprompt.Name = "OTPprompt";
            this.OTPprompt.Size = new System.Drawing.Size(274, 16);
            this.OTPprompt.TabIndex = 1;
            this.OTPprompt.Text = "Please input the OTP code sent to your email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(326, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 22);
            this.textBox1.TabIndex = 2;
            // 
            // OTPform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OTPprompt);
            this.Controls.Add(this.HomePageLink);
            this.Name = "OTPform";
            this.Text = "OTPform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomePageLink;
        private System.Windows.Forms.Label OTPprompt;
        private System.Windows.Forms.TextBox textBox1;
    }
}