namespace Student_Management_System
{
    partial class Timetable
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back_button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.show_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Timetable information is....";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(991, 213);
            this.dataGridView1.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 639);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "Holiday Information";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 687);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(800, 150);
            this.textBox1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(890, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(570, 80);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(202, 46);
            this.show_btn.TabIndex = 19;
            this.show_btn.Text = "Show Timetable";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Timetable";
            this.Text = "Timetable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back_button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button show_btn;
    }
}