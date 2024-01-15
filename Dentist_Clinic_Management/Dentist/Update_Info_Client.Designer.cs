namespace Dentist_Clinic_Management.Dentist
{
    partial class Update_Info_Client
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
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            picLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 628);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(8, 48, 107);
            button3.Location = new Point(35, 339);
            button3.Name = "button3";
            button3.Size = new Size(270, 55);
            button3.TabIndex = 2;
            button3.Text = "Quay lại";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(8, 48, 107);
            button2.Location = new Point(34, 339);
            button2.Name = "button2";
            button2.Size = new Size(270, 55);
            button2.TabIndex = 1;
            button2.Text = "Cập nhật bệnh án";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(8, 48, 107);
            button1.Location = new Point(32, 339);
            button1.Name = "button1";
            button1.Size = new Size(270, 55);
            button1.TabIndex = 0;
            button1.Text = "Thêm hồ sơ bệnh nhân";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(8, 48, 107);
            panel2.Controls.Add(picLogo);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(35, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 417);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(8, 48, 107);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(408, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(324, 417);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(8, 48, 107);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(button3);
            panel4.Location = new Point(758, 95);
            panel4.Name = "panel4";
            panel4.Size = new Size(324, 417);
            panel4.TabIndex = 5;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.FromArgb(8, 48, 107);
            picLogo.Image = Properties.Resources.png_clipart_hospital_medicine_health_therapy_patient_medical_record_angle_text_thumbnail_removebg_preview;
            picLogo.Location = new Point(37, 32);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(265, 291);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 41;
            picLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(8, 48, 107);
            pictureBox1.Image = Properties.Resources.png_clipart_computer_icons_medicine_medical_record_text_rectangle_removebg_preview1;
            pictureBox1.Location = new Point(67, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(8, 48, 107);
            pictureBox2.Image = Properties.Resources.transparent_return_icon_back_arrow_icon_basic_ui_icon_5fd3cd93d71e77_5901981016077162438811_removebg_preview;
            pictureBox2.Location = new Point(35, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(255, 276);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // Update_Info_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(1135, 652);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Update_Info_Client";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox picLogo;
    }
}