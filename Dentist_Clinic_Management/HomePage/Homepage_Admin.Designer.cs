namespace Dentist_Clinic_Management.HomePage
{
    partial class Homepage_Admin
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
            C_pn_header = new Panel();
            C_bt_Exit = new Button();
            C_pc_Exit = new PictureBox();
            C_pn_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)C_pc_Exit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 628);
            panel1.TabIndex = 0;
            // 
            // C_pn_header
            // 
            C_pn_header.BackColor = Color.FromArgb(8, 48, 107);
            C_pn_header.Controls.Add(C_bt_Exit);
            C_pn_header.Controls.Add(C_pc_Exit);
            C_pn_header.Location = new Point(12, 275);
            C_pn_header.Name = "C_pn_header";
            C_pn_header.Size = new Size(1111, 102);
            C_pn_header.TabIndex = 8;
            // 
            // C_bt_Exit
            // 
            C_bt_Exit.BackColor = Color.FromArgb(8, 48, 107);
            C_bt_Exit.FlatAppearance.BorderColor = Color.Navy;
            C_bt_Exit.FlatStyle = FlatStyle.Flat;
            C_bt_Exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            C_bt_Exit.ForeColor = Color.White;
            C_bt_Exit.Location = new Point(898, 19);
            C_bt_Exit.Name = "C_bt_Exit";
            C_bt_Exit.Size = new Size(133, 48);
            C_bt_Exit.TabIndex = 6;
            C_bt_Exit.TabStop = false;
            C_bt_Exit.Text = "Đăng xuất";
            C_bt_Exit.UseVisualStyleBackColor = false;
            C_bt_Exit.Click += C_bt_Exit_Click;
            // 
            // C_pc_Exit
            // 
            C_pc_Exit.Image = Properties.Resources.logout_2;
            C_pc_Exit.Location = new Point(1037, 19);
            C_pc_Exit.Name = "C_pc_Exit";
            C_pc_Exit.Size = new Size(51, 49);
            C_pc_Exit.SizeMode = PictureBoxSizeMode.Zoom;
            C_pc_Exit.TabIndex = 5;
            C_pc_Exit.TabStop = false;
            // 
            // Homepage_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1135, 652);
            ControlBox = false;
            Controls.Add(C_pn_header);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Homepage_Admin";
            C_pn_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)C_pc_Exit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel C_pn_header;
        private Button C_bt_Exit;
        private PictureBox C_pc_Exit;
    }
}