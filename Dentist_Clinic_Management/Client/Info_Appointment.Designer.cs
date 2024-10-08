﻿namespace Dentist_Clinic_Management.Client
{
    partial class Info_Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info_Appointment));
            main_panel = new Panel();
            ln_Success = new Label();
            data_list_patient = new DataGridView();
            bt_Beck = new Button();
            bt_Ok = new Button();
            label50 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            tb_Date = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            tb_Dentist = new TextBox();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            tb_Clock = new TextBox();
            pictureBox4 = new PictureBox();
            lb_rg_phone = new Label();
            label2 = new Label();
            lb_rg_datebirth = new Label();
            lb_rg_Name = new Label();
            panel3 = new Panel();
            tb_Birth = new TextBox();
            pictureBox2 = new PictureBox();
            pn_rg_Addr = new Panel();
            tb_Address = new TextBox();
            pc_Lg_Un = new PictureBox();
            pn_rg_Name = new Panel();
            tb_Name = new TextBox();
            pc_rg_name = new PictureBox();
            pn_rg_Phone = new Panel();
            tb_Phone = new TextBox();
            pc_Hp_Login_Un = new PictureBox();
            label1 = new Label();
            main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_list_patient).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pn_rg_Addr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_Lg_Un).BeginInit();
            pn_rg_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_rg_name).BeginInit();
            pn_rg_Phone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_Hp_Login_Un).BeginInit();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.White;
            main_panel.Controls.Add(ln_Success);
            main_panel.Controls.Add(data_list_patient);
            main_panel.Controls.Add(bt_Beck);
            main_panel.Controls.Add(bt_Ok);
            main_panel.Controls.Add(label50);
            main_panel.Controls.Add(label3);
            main_panel.Controls.Add(label4);
            main_panel.Controls.Add(panel4);
            main_panel.Controls.Add(panel2);
            main_panel.Controls.Add(panel5);
            main_panel.Controls.Add(lb_rg_phone);
            main_panel.Controls.Add(label2);
            main_panel.Controls.Add(lb_rg_datebirth);
            main_panel.Controls.Add(lb_rg_Name);
            main_panel.Controls.Add(panel3);
            main_panel.Controls.Add(pn_rg_Addr);
            main_panel.Controls.Add(pn_rg_Name);
            main_panel.Controls.Add(pn_rg_Phone);
            main_panel.Controls.Add(label1);
            main_panel.Location = new Point(12, 11);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1111, 597);
            main_panel.TabIndex = 0;
            main_panel.Paint += main_panel_Paint;
            // 
            // ln_Success
            // 
            ln_Success.AutoSize = true;
            ln_Success.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ln_Success.Location = new Point(704, 554);
            ln_Success.Name = "ln_Success";
            ln_Success.Size = new Size(213, 30);
            ln_Success.TabIndex = 45;
            ln_Success.Text = "Hủy hẹn thành công.";
            ln_Success.Visible = false;
            // 
            // data_list_patient
            // 
            data_list_patient.BackgroundColor = SystemColors.Control;
            data_list_patient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_list_patient.Location = new Point(36, 77);
            data_list_patient.Name = "data_list_patient";
            data_list_patient.RowHeadersWidth = 51;
            data_list_patient.RowTemplate.Height = 29;
            data_list_patient.Size = new Size(444, 392);
            data_list_patient.TabIndex = 44;
            // 
            // bt_Beck
            // 
            bt_Beck.BackColor = Color.FromArgb(8, 48, 107);
            bt_Beck.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Beck.ForeColor = Color.White;
            bt_Beck.Location = new Point(596, 494);
            bt_Beck.Name = "bt_Beck";
            bt_Beck.Size = new Size(151, 57);
            bt_Beck.TabIndex = 43;
            bt_Beck.TabStop = false;
            bt_Beck.Text = "Quay lại";
            bt_Beck.UseVisualStyleBackColor = false;
            bt_Beck.Click += bt_Beck_Click;
            // 
            // bt_Ok
            // 
            bt_Ok.BackColor = Color.FromArgb(8, 48, 107);
            bt_Ok.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Ok.ForeColor = Color.White;
            bt_Ok.Location = new Point(883, 494);
            bt_Ok.Name = "bt_Ok";
            bt_Ok.Size = new Size(151, 57);
            bt_Ok.TabIndex = 42;
            bt_Ok.TabStop = false;
            bt_Ok.Text = "Hủy lịch hẹn";
            bt_Ok.UseVisualStyleBackColor = false;
            bt_Ok.Click += bt_Ok_Click;
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label50.Location = new Point(537, 380);
            label50.Name = "label50";
            label50.Size = new Size(72, 30);
            label50.TabIndex = 41;
            label50.Text = "Nha sĩ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(537, 259);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 40;
            label3.Text = "Ngày khám";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(537, 319);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 39;
            label4.Text = "Giờ khám";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(tb_Date);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(687, 250);
            panel4.Name = "panel4";
            panel4.Size = new Size(391, 43);
            panel4.TabIndex = 36;
            // 
            // tb_Date
            // 
            tb_Date.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Date.Location = new Point(54, 2);
            tb_Date.Name = "tb_Date";
            tb_Date.ReadOnly = true;
            tb_Date.Size = new Size(331, 36);
            tb_Date.TabIndex = 10;
            tb_Date.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calendar__2_;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tb_Dentist);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(687, 370);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 43);
            panel2.TabIndex = 38;
            // 
            // tb_Dentist
            // 
            tb_Dentist.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Dentist.Location = new Point(54, 2);
            tb_Dentist.Name = "tb_Dentist";
            tb_Dentist.ReadOnly = true;
            tb_Dentist.Size = new Size(331, 36);
            tb_Dentist.TabIndex = 12;
            tb_Dentist.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.doctor;
            pictureBox3.Location = new Point(4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(tb_Clock);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(687, 310);
            panel5.Name = "panel5";
            panel5.Size = new Size(391, 43);
            panel5.TabIndex = 37;
            // 
            // tb_Clock
            // 
            tb_Clock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Clock.Location = new Point(54, 2);
            tb_Clock.Name = "tb_Clock";
            tb_Clock.ReadOnly = true;
            tb_Clock.Size = new Size(331, 36);
            tb_Clock.TabIndex = 11;
            tb_Clock.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.clock__1_;
            pictureBox4.Location = new Point(4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // lb_rg_phone
            // 
            lb_rg_phone.AutoSize = true;
            lb_rg_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_phone.Location = new Point(537, 200);
            lb_rg_phone.Name = "lb_rg_phone";
            lb_rg_phone.Size = new Size(140, 30);
            lb_rg_phone.TabIndex = 34;
            lb_rg_phone.Text = "Số điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(537, 142);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 32;
            label2.Text = "Địa chỉ";
            // 
            // lb_rg_datebirth
            // 
            lb_rg_datebirth.AutoSize = true;
            lb_rg_datebirth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_datebirth.Location = new Point(537, 85);
            lb_rg_datebirth.Name = "lb_rg_datebirth";
            lb_rg_datebirth.Size = new Size(108, 30);
            lb_rg_datebirth.TabIndex = 30;
            lb_rg_datebirth.Text = "Ngày sinh";
            // 
            // lb_rg_Name
            // 
            lb_rg_Name.AutoSize = true;
            lb_rg_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_Name.Location = new Point(537, 442);
            lb_rg_Name.Name = "lb_rg_Name";
            lb_rg_Name.Size = new Size(108, 30);
            lb_rg_Name.TabIndex = 28;
            lb_rg_Name.Text = "Trạng thái";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(tb_Birth);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(687, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(391, 43);
            panel3.TabIndex = 31;
            // 
            // tb_Birth
            // 
            tb_Birth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Birth.Location = new Point(54, 2);
            tb_Birth.Name = "tb_Birth";
            tb_Birth.ReadOnly = true;
            tb_Birth.Size = new Size(331, 36);
            tb_Birth.TabIndex = 13;
            tb_Birth.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pn_rg_Addr
            // 
            pn_rg_Addr.BorderStyle = BorderStyle.FixedSingle;
            pn_rg_Addr.Controls.Add(tb_Address);
            pn_rg_Addr.Controls.Add(pc_Lg_Un);
            pn_rg_Addr.Location = new Point(687, 132);
            pn_rg_Addr.Name = "pn_rg_Addr";
            pn_rg_Addr.Size = new Size(391, 43);
            pn_rg_Addr.TabIndex = 33;
            // 
            // tb_Address
            // 
            tb_Address.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Address.Location = new Point(54, 2);
            tb_Address.Name = "tb_Address";
            tb_Address.ReadOnly = true;
            tb_Address.Size = new Size(331, 36);
            tb_Address.TabIndex = 12;
            tb_Address.TabStop = false;
            // 
            // pc_Lg_Un
            // 
            pc_Lg_Un.Image = (Image)resources.GetObject("pc_Lg_Un.Image");
            pc_Lg_Un.Location = new Point(4, 3);
            pc_Lg_Un.Name = "pc_Lg_Un";
            pc_Lg_Un.Size = new Size(46, 34);
            pc_Lg_Un.SizeMode = PictureBoxSizeMode.Zoom;
            pc_Lg_Un.TabIndex = 9;
            pc_Lg_Un.TabStop = false;
            // 
            // pn_rg_Name
            // 
            pn_rg_Name.BorderStyle = BorderStyle.FixedSingle;
            pn_rg_Name.Controls.Add(tb_Name);
            pn_rg_Name.Controls.Add(pc_rg_name);
            pn_rg_Name.Location = new Point(687, 432);
            pn_rg_Name.Name = "pn_rg_Name";
            pn_rg_Name.Size = new Size(391, 43);
            pn_rg_Name.TabIndex = 29;
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Name.Location = new Point(54, 2);
            tb_Name.Name = "tb_Name";
            tb_Name.ReadOnly = true;
            tb_Name.RightToLeft = RightToLeft.No;
            tb_Name.Size = new Size(331, 36);
            tb_Name.TabIndex = 14;
            tb_Name.TabStop = false;
            // 
            // pc_rg_name
            // 
            pc_rg_name.Image = Properties.Resources.user;
            pc_rg_name.Location = new Point(4, 3);
            pc_rg_name.Name = "pc_rg_name";
            pc_rg_name.Size = new Size(46, 34);
            pc_rg_name.SizeMode = PictureBoxSizeMode.Zoom;
            pc_rg_name.TabIndex = 9;
            pc_rg_name.TabStop = false;
            // 
            // pn_rg_Phone
            // 
            pn_rg_Phone.BorderStyle = BorderStyle.FixedSingle;
            pn_rg_Phone.Controls.Add(tb_Phone);
            pn_rg_Phone.Controls.Add(pc_Hp_Login_Un);
            pn_rg_Phone.Location = new Point(687, 190);
            pn_rg_Phone.Name = "pn_rg_Phone";
            pn_rg_Phone.Size = new Size(391, 43);
            pn_rg_Phone.TabIndex = 35;
            // 
            // tb_Phone
            // 
            tb_Phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Phone.Location = new Point(54, 2);
            tb_Phone.Name = "tb_Phone";
            tb_Phone.ReadOnly = true;
            tb_Phone.Size = new Size(331, 36);
            tb_Phone.TabIndex = 11;
            tb_Phone.TabStop = false;
            // 
            // pc_Hp_Login_Un
            // 
            pc_Hp_Login_Un.Image = (Image)resources.GetObject("pc_Hp_Login_Un.Image");
            pc_Hp_Login_Un.Location = new Point(4, 3);
            pc_Hp_Login_Un.Name = "pc_Hp_Login_Un";
            pc_Hp_Login_Un.Size = new Size(46, 34);
            pc_Hp_Login_Un.SizeMode = PictureBoxSizeMode.Zoom;
            pc_Hp_Login_Un.TabIndex = 9;
            pc_Hp_Login_Un.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(689, 22);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 27;
            label1.Text = "Thông tin lịch hẹn";
            // 
            // Info_Appointment
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(1135, 619);
            ControlBox = false;
            Controls.Add(main_panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Info_Appointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_list_patient).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pn_rg_Addr.ResumeLayout(false);
            pn_rg_Addr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_Lg_Un).EndInit();
            pn_rg_Name.ResumeLayout(false);
            pn_rg_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_rg_name).EndInit();
            pn_rg_Phone.ResumeLayout(false);
            pn_rg_Phone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_Hp_Login_Un).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel main_panel;
        private Button bt_Beck;
        private Button bt_Ok;
        private Label label50;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private TextBox tb_Date;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox tb_Dentist;
        private PictureBox pictureBox3;
        private Panel panel5;
        private TextBox tb_Clock;
        private PictureBox pictureBox4;
        private Label lb_rg_phone;
        private Label label2;
        private Label lb_rg_datebirth;
        private Label lb_rg_Name;
        private Panel panel3;
        private TextBox tb_Birth;
        private PictureBox pictureBox2;
        private Panel pn_rg_Addr;
        private TextBox tb_Address;
        private PictureBox pc_Lg_Un;
        private Panel pn_rg_Name;
        private TextBox tb_Name;
        private PictureBox pc_rg_name;
        private Panel pn_rg_Phone;
        private TextBox tb_Phone;
        private PictureBox pc_Hp_Login_Un;
        private Label label1;
        private DataGridView data_list_patient;
        private Label ln_Success;
    }
}