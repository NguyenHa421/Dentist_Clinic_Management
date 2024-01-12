namespace Dentist_Clinic_Management.Warming_Client
{
    partial class No_Appointment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Beck = new System.Windows.Forms.Button();
            this.bt_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bt_Beck);
            this.panel1.Controls.Add(this.bt_Ok);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 196);
            this.panel1.TabIndex = 1;
            // 
            // bt_Beck
            // 
            this.bt_Beck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.bt_Beck.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Beck.ForeColor = System.Drawing.Color.White;
            this.bt_Beck.Location = new System.Drawing.Point(53, 103);
            this.bt_Beck.Name = "bt_Beck";
            this.bt_Beck.Size = new System.Drawing.Size(151, 60);
            this.bt_Beck.TabIndex = 45;
            this.bt_Beck.TabStop = false;
            this.bt_Beck.Text = "Quay lại";
            this.bt_Beck.UseVisualStyleBackColor = false;
            // 
            // bt_Ok
            // 
            this.bt_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.bt_Ok.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_Ok.ForeColor = System.Drawing.Color.White;
            this.bt_Ok.Location = new System.Drawing.Point(300, 103);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(151, 60);
            this.bt_Ok.TabIndex = 44;
            this.bt_Ok.TabStop = false;
            this.bt_Ok.Text = "Đặt lịch ngay";
            this.bt_Ok.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn chưa có lịch hẹn nào tại phòng khám!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // No_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(531, 220);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "No_Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button bt_Beck;
        private Button bt_Ok;
        private Label label1;
    }
}