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
            this.Timehead_label = new System.Windows.Forms.Label();
            this.time_dataGridView = new System.Windows.Forms.DataGridView();
            this.back_button2 = new System.Windows.Forms.Button();
            this.Holiday_label = new System.Windows.Forms.Label();
            this.holiday_textBox = new System.Windows.Forms.TextBox();
            this.cal_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.show_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.time_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Timehead_label
            // 
            this.Timehead_label.AutoSize = true;
            this.Timehead_label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timehead_label.Location = new System.Drawing.Point(80, 90);
            this.Timehead_label.Name = "Timehead_label";
            this.Timehead_label.Size = new System.Drawing.Size(428, 35);
            this.Timehead_label.TabIndex = 0;
            this.Timehead_label.Text = "Your Timetable information is....";
            // 
            // time_dataGridView
            // 
            this.time_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.time_dataGridView.Location = new System.Drawing.Point(100, 140);
            this.time_dataGridView.Name = "time_dataGridView";
            this.time_dataGridView.RowHeadersWidth = 51;
            this.time_dataGridView.RowTemplate.Height = 24;
            this.time_dataGridView.Size = new System.Drawing.Size(991, 213);
            this.time_dataGridView.TabIndex = 1;
            this.time_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // back_button2
            // 
            this.back_button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.back_button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.back_button2.Location = new System.Drawing.Point(970, 641);
            this.back_button2.Name = "back_button2";
            this.back_button2.Size = new System.Drawing.Size(200, 100);
            this.back_button2.TabIndex = 13;
            this.back_button2.Text = "Back";
            this.back_button2.UseVisualStyleBackColor = false;
            this.back_button2.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Holiday_label
            // 
            this.Holiday_label.AutoSize = true;
            this.Holiday_label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Holiday_label.Location = new System.Drawing.Point(80, 600);
            this.Holiday_label.Name = "Holiday_label";
            this.Holiday_label.Size = new System.Drawing.Size(270, 35);
            this.Holiday_label.TabIndex = 14;
            this.Holiday_label.Text = "Holiday Information";
            // 
            // holiday_textBox
            // 
            this.holiday_textBox.Location = new System.Drawing.Point(100, 640);
            this.holiday_textBox.Multiline = true;
            this.holiday_textBox.Name = "holiday_textBox";
            this.holiday_textBox.ReadOnly = true;
            this.holiday_textBox.Size = new System.Drawing.Size(749, 100);
            this.holiday_textBox.TabIndex = 15;
            // 
            // cal_dateTimePicker
            // 
            this.cal_dateTimePicker.Location = new System.Drawing.Point(890, 15);
            this.cal_dateTimePicker.Name = "cal_dateTimePicker";
            this.cal_dateTimePicker.Size = new System.Drawing.Size(273, 22);
            this.cal_dateTimePicker.TabIndex = 16;
            // 
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(556, 88);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(202, 46);
            this.show_btn.TabIndex = 18;
            this.show_btn.Text = "Show Timetable";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(531, 479);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.cal_dateTimePicker);
            this.Controls.Add(this.holiday_textBox);
            this.Controls.Add(this.Holiday_label);
            this.Controls.Add(this.back_button2);
            this.Controls.Add(this.time_dataGridView);
            this.Controls.Add(this.Timehead_label);
            this.Name = "Timetable";
            this.Text = "Timetable";
            this.Load += new System.EventHandler(this.Timetable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.time_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Timehead_label;
        private System.Windows.Forms.DataGridView time_dataGridView;
        private System.Windows.Forms.Button back_button2;
        private System.Windows.Forms.Label Holiday_label;
        private System.Windows.Forms.TextBox holiday_textBox;
        private System.Windows.Forms.DateTimePicker cal_dateTimePicker;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}