namespace Student_Management_System
{
    partial class Attendance
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
            this.Attendance_dataGridView = new System.Windows.Forms.DataGridView();
            this.Back_button3 = new System.Windows.Forms.Button();
            this.show_btn2 = new System.Windows.Forms.Button();
            this.Attendancehead_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Attendance_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Attendance_dataGridView
            // 
            this.Attendance_dataGridView.AllowUserToAddRows = false;
            this.Attendance_dataGridView.AllowUserToDeleteRows = false;
            this.Attendance_dataGridView.AllowUserToResizeColumns = false;
            this.Attendance_dataGridView.AllowUserToResizeRows = false;
            this.Attendance_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Attendance_dataGridView.Location = new System.Drawing.Point(173, 139);
            this.Attendance_dataGridView.Name = "Attendance_dataGridView";
            this.Attendance_dataGridView.ReadOnly = true;
            this.Attendance_dataGridView.RowHeadersWidth = 51;
            this.Attendance_dataGridView.RowTemplate.Height = 24;
            this.Attendance_dataGridView.Size = new System.Drawing.Size(833, 260);
            this.Attendance_dataGridView.TabIndex = 1;
            this.Attendance_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Back_button3
            // 
            this.Back_button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Back_button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back_button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button3.Location = new System.Drawing.Point(970, 741);
            this.Back_button3.Name = "Back_button3";
            this.Back_button3.Size = new System.Drawing.Size(200, 100);
            this.Back_button3.TabIndex = 2;
            this.Back_button3.Text = "Back";
            this.Back_button3.UseVisualStyleBackColor = false;
            this.Back_button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // show_btn2
            // 
            this.show_btn2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.show_btn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn2.Location = new System.Drawing.Point(435, 63);
            this.show_btn2.Name = "show_btn2";
            this.show_btn2.Size = new System.Drawing.Size(250, 50);
            this.show_btn2.TabIndex = 20;
            this.show_btn2.Text = "View My Attendance";
            this.show_btn2.UseVisualStyleBackColor = true;
            this.show_btn2.Click += new System.EventHandler(this.show_btn2_Click);
            // 
            // Attendancehead_label
            // 
            this.Attendancehead_label.AutoSize = true;
            this.Attendancehead_label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendancehead_label.Location = new System.Drawing.Point(145, 75);
            this.Attendancehead_label.Name = "Attendancehead_label";
            this.Attendancehead_label.Size = new System.Drawing.Size(210, 35);
            this.Attendancehead_label.TabIndex = 22;
            this.Attendancehead_label.Text = "My Attendance";
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.show_btn2;
            this.ClientSize = new System.Drawing.Size(1182, 853);
            this.Controls.Add(this.Attendancehead_label);
            this.Controls.Add(this.show_btn2);
            this.Controls.Add(this.Back_button3);
            this.Controls.Add(this.Attendance_dataGridView);
            this.Name = "Attendance";
            this.Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.Attendance_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Attendance_dataGridView;
        private System.Windows.Forms.Button Back_button3;
        private System.Windows.Forms.Button show_btn2;
        private System.Windows.Forms.Label Attendancehead_label;
    }
}

