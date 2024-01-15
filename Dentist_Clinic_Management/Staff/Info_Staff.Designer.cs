namespace Dentist_Clinic_Management.Staff
{
    partial class Info_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_Staff));
            panel1 = new Panel();
            bt_Beck = new Button();
            label1 = new Label();
            lb_rg_phone = new Label();
            lb_rg_datebirth = new Label();
            lb_rg_Name = new Label();
            panel3 = new Panel();
            tb_Birth = new TextBox();
            pictureBox2 = new PictureBox();
            pn_rg_Name = new Panel();
            tb_Name = new TextBox();
            pc_rg_name = new PictureBox();
            pn_rg_Phone = new Panel();
            tb_Phone = new TextBox();
            pc_Hp_Login_Un = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pn_rg_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_rg_name).BeginInit();
            pn_rg_Phone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_Hp_Login_Un).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(bt_Beck);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lb_rg_phone);
            panel1.Controls.Add(lb_rg_datebirth);
            panel1.Controls.Add(lb_rg_Name);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pn_rg_Name);
            panel1.Controls.Add(pn_rg_Phone);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(972, 471);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // bt_Beck
            // 
            bt_Beck.BackColor = Color.FromArgb(8, 48, 107);
            bt_Beck.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Beck.ForeColor = Color.White;
            bt_Beck.Location = new Point(782, 354);
            bt_Beck.Margin = new Padding(3, 2, 3, 2);
            bt_Beck.Name = "bt_Beck";
            bt_Beck.Size = new Size(132, 45);
            bt_Beck.TabIndex = 39;
            bt_Beck.TabStop = false;
            bt_Beck.Text = "Quay lại";
            bt_Beck.UseVisualStyleBackColor = false;
            bt_Beck.Click += bt_Beck_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(556, 148);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 37;
            label1.Text = "Thông tin cá nhân";
            // 
            // lb_rg_phone
            // 
            lb_rg_phone.AutoSize = true;
            lb_rg_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_phone.Location = new Point(441, 301);
            lb_rg_phone.Name = "lb_rg_phone";
            lb_rg_phone.Size = new Size(123, 25);
            lb_rg_phone.TabIndex = 35;
            lb_rg_phone.Text = "Số điện thoại";
            // 
            // lb_rg_datebirth
            // 
            lb_rg_datebirth.AutoSize = true;
            lb_rg_datebirth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_datebirth.Location = new Point(441, 247);
            lb_rg_datebirth.Name = "lb_rg_datebirth";
            lb_rg_datebirth.Size = new Size(68, 25);
            lb_rg_datebirth.TabIndex = 31;
            lb_rg_datebirth.Text = "Họ tên";
            // 
            // lb_rg_Name
            // 
            lb_rg_Name.AutoSize = true;
            lb_rg_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_Name.Location = new Point(441, 204);
            lb_rg_Name.Name = "lb_rg_Name";
            lb_rg_Name.Size = new Size(94, 25);
            lb_rg_Name.TabIndex = 29;
            lb_rg_Name.Text = "Mã nha sĩ";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tb_Birth);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(572, 239);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(342, 34);
            panel3.TabIndex = 32;
            // 
            // tb_Birth
            // 
            tb_Birth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Birth.Location = new Point(47, 2);
            tb_Birth.Margin = new Padding(3, 2, 3, 2);
            tb_Birth.Name = "tb_Birth";
            tb_Birth.ReadOnly = true;
            tb_Birth.Size = new Size(290, 32);
            tb_Birth.TabIndex = 13;
            tb_Birth.TabStop = false;
            tb_Birth.Text = "Username";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.doctor;
            pictureBox2.Location = new Point(4, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pn_rg_Name
            // 
            pn_rg_Name.BorderStyle = BorderStyle.FixedSingle;
            pn_rg_Name.Controls.Add(tb_Name);
            pn_rg_Name.Controls.Add(pc_rg_name);
            pn_rg_Name.Location = new Point(572, 196);
            pn_rg_Name.Margin = new Padding(3, 2, 3, 2);
            pn_rg_Name.Name = "pn_rg_Name";
            pn_rg_Name.Size = new Size(342, 34);
            pn_rg_Name.TabIndex = 30;
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Name.Location = new Point(47, 2);
            tb_Name.Margin = new Padding(3, 2, 3, 2);
            tb_Name.Name = "tb_Name";
            tb_Name.ReadOnly = true;
            tb_Name.RightToLeft = RightToLeft.No;
            tb_Name.Size = new Size(290, 32);
            tb_Name.TabIndex = 14;
            tb_Name.TabStop = false;
            tb_Name.Text = "123";
            // 
            // pc_rg_name
            // 
            pc_rg_name.Image = Properties.Resources.user;
            pc_rg_name.Location = new Point(4, 2);
            pc_rg_name.Margin = new Padding(3, 2, 3, 2);
            pc_rg_name.Name = "pc_rg_name";
            pc_rg_name.Size = new Size(40, 27);
            pc_rg_name.SizeMode = PictureBoxSizeMode.Zoom;
            pc_rg_name.TabIndex = 9;
            pc_rg_name.TabStop = false;
            // 
            // pn_rg_Phone
            // 
            pn_rg_Phone.BorderStyle = BorderStyle.FixedSingle;
            pn_rg_Phone.Controls.Add(tb_Phone);
            pn_rg_Phone.Controls.Add(pc_Hp_Login_Un);
            pn_rg_Phone.Location = new Point(572, 293);
            pn_rg_Phone.Margin = new Padding(3, 2, 3, 2);
            pn_rg_Phone.Name = "pn_rg_Phone";
            pn_rg_Phone.Size = new Size(342, 34);
            pn_rg_Phone.TabIndex = 36;
            // 
            // tb_Phone
            // 
            tb_Phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Phone.Location = new Point(47, 2);
            tb_Phone.Margin = new Padding(3, 2, 3, 2);
            tb_Phone.Name = "tb_Phone";
            tb_Phone.ReadOnly = true;
            tb_Phone.Size = new Size(290, 32);
            tb_Phone.TabIndex = 11;
            tb_Phone.TabStop = false;
            tb_Phone.Text = "0917171783";
            // 
            // pc_Hp_Login_Un
            // 
            pc_Hp_Login_Un.Image = (Image)resources.GetObject("pc_Hp_Login_Un.Image");
            pc_Hp_Login_Un.Location = new Point(4, 2);
            pc_Hp_Login_Un.Margin = new Padding(3, 2, 3, 2);
            pc_Hp_Login_Un.Name = "pc_Hp_Login_Un";
            pc_Hp_Login_Un.Size = new Size(40, 27);
            pc_Hp_Login_Un.SizeMode = PictureBoxSizeMode.Zoom;
            pc_Hp_Login_Un.TabIndex = 9;
            pc_Hp_Login_Un.TabStop = false;
            // 
            // Info_Staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(993, 489);
            ControlBox = false;
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Info_Staff";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pn_rg_Name.ResumeLayout(false);
            pn_rg_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_rg_name).EndInit();
            pn_rg_Phone.ResumeLayout(false);
            pn_rg_Phone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_Hp_Login_Un).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bt_Beck;
        private Label label1;
        private Label lb_rg_phone;
        private Label lb_rg_datebirth;
        private Label lb_rg_Name;
        private Panel panel3;
        private TextBox tb_Birth;
        private PictureBox pictureBox2;
        private Panel pn_rg_Name;
        private TextBox tb_Name;
        private PictureBox pc_rg_name;
        private Panel pn_rg_Phone;
        private TextBox tb_Phone;
        private PictureBox pc_Hp_Login_Un;
    }
}