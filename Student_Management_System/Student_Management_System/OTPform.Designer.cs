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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTPform));
            this.HomePageLink = new System.Windows.Forms.Button();
            this.OTPprompt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HomePageLink
            // 
            this.HomePageLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.HomePageLink.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageLink.Location = new System.Drawing.Point(682, 491);
            this.HomePageLink.Name = "HomePageLink";
            this.HomePageLink.Size = new System.Drawing.Size(154, 53);
            this.HomePageLink.TabIndex = 0;
            this.HomePageLink.Text = "Login";
            this.HomePageLink.UseVisualStyleBackColor = false;
            this.HomePageLink.Click += new System.EventHandler(this.HomePageLink_Click);
            // 
            // OTPprompt
            // 
            this.OTPprompt.AutoSize = true;
            this.OTPprompt.BackColor = System.Drawing.Color.White;
            this.OTPprompt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPprompt.Location = new System.Drawing.Point(423, 426);
            this.OTPprompt.Name = "OTPprompt";
            this.OTPprompt.Size = new System.Drawing.Size(332, 17);
            this.OTPprompt.TabIndex = 1;
            this.OTPprompt.Text = "Please input the OTP code sent to your email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(792, 424);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 22);
            this.textBox1.TabIndex = 2;
            // 
            // OTPform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OTPprompt);
            this.Controls.Add(this.HomePageLink);
            this.DoubleBuffered = true;
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