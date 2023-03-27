namespace Student_Management_System
{
    partial class Fees
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
            this.total_label = new System.Windows.Forms.Label();
            this.paid_label = new System.Windows.Forms.Label();
            this.topay_label = new System.Windows.Forms.Label();
            this.proceed_button = new System.Windows.Forms.Button();
            this.back_button4 = new System.Windows.Forms.Button();
            this.Feeshead_label = new System.Windows.Forms.Label();
            this.total_textBox = new System.Windows.Forms.TextBox();
            this.paid_textBox = new System.Windows.Forms.TextBox();
            this.topay_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.Location = new System.Drawing.Point(150, 200);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(185, 38);
            this.total_label.TabIndex = 0;
            this.total_label.Text = "Total Fees";
            // 
            // paid_label
            // 
            this.paid_label.AutoSize = true;
            this.paid_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_label.Location = new System.Drawing.Point(150, 275);
            this.paid_label.Name = "paid_label";
            this.paid_label.Size = new System.Drawing.Size(326, 38);
            this.paid_label.TabIndex = 1;
            this.paid_label.Text = "Fees you have paid";
            // 
            // topay_label
            // 
            this.topay_label.AutoSize = true;
            this.topay_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topay_label.Location = new System.Drawing.Point(150, 350);
            this.topay_label.Name = "topay_label";
            this.topay_label.Size = new System.Drawing.Size(291, 38);
            this.topay_label.TabIndex = 2;
            this.topay_label.Text = "Fees need to pay";
            // 
            // proceed_button
            // 
            this.proceed_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.proceed_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceed_button.Location = new System.Drawing.Point(428, 458);
            this.proceed_button.Name = "proceed_button";
            this.proceed_button.Size = new System.Drawing.Size(300, 100);
            this.proceed_button.TabIndex = 3;
            this.proceed_button.Text = "Proceed to pay";
            this.proceed_button.UseVisualStyleBackColor = false;
            this.proceed_button.Click += new System.EventHandler(this.Paybtn_Click);
            // 
            // back_button4
            // 
            this.back_button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.back_button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.back_button4.Location = new System.Drawing.Point(970, 741);
            this.back_button4.Name = "back_button4";
            this.back_button4.Size = new System.Drawing.Size(200, 100);
            this.back_button4.TabIndex = 13;
            this.back_button4.Text = "Back";
            this.back_button4.UseVisualStyleBackColor = false;
            this.back_button4.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Feeshead_label
            // 
            this.Feeshead_label.AutoSize = true;
            this.Feeshead_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feeshead_label.Location = new System.Drawing.Point(150, 120);
            this.Feeshead_label.Name = "Feeshead_label";
            this.Feeshead_label.Size = new System.Drawing.Size(462, 38);
            this.Feeshead_label.TabIndex = 14;
            this.Feeshead_label.Text = "Your Fees information are...";
            // 
            // total_textBox
            // 
            this.total_textBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_textBox.Location = new System.Drawing.Point(500, 200);
            this.total_textBox.Name = "total_textBox";
            this.total_textBox.ReadOnly = true;
            this.total_textBox.Size = new System.Drawing.Size(171, 38);
            this.total_textBox.TabIndex = 15;
            this.total_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // paid_textBox
            // 
            this.paid_textBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_textBox.Location = new System.Drawing.Point(500, 275);
            this.paid_textBox.Name = "paid_textBox";
            this.paid_textBox.ReadOnly = true;
            this.paid_textBox.Size = new System.Drawing.Size(171, 38);
            this.paid_textBox.TabIndex = 16;
            this.paid_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // topay_textBox
            // 
            this.topay_textBox.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topay_textBox.Location = new System.Drawing.Point(500, 350);
            this.topay_textBox.Name = "topay_textBox";
            this.topay_textBox.ReadOnly = true;
            this.topay_textBox.Size = new System.Drawing.Size(171, 38);
            this.topay_textBox.TabIndex = 17;
            this.topay_textBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.topay_textBox);
            this.Controls.Add(this.paid_textBox);
            this.Controls.Add(this.total_textBox);
            this.Controls.Add(this.Feeshead_label);
            this.Controls.Add(this.back_button4);
            this.Controls.Add(this.proceed_button);
            this.Controls.Add(this.topay_label);
            this.Controls.Add(this.paid_label);
            this.Controls.Add(this.total_label);
            this.Name = "Fees";
            this.Text = "Fees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.Label paid_label;
        private System.Windows.Forms.Label topay_label;
        private System.Windows.Forms.Button proceed_button;
        private System.Windows.Forms.Button back_button4;
        private System.Windows.Forms.Label Feeshead_label;
        private System.Windows.Forms.TextBox total_textBox;
        private System.Windows.Forms.TextBox paid_textBox;
        private System.Windows.Forms.TextBox topay_textBox;
    }
}