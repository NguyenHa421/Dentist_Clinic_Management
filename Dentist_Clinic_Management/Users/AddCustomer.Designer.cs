namespace Dentist_Clinic_Management.Users
{
    partial class AddCustomer
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
            main_panel = new Panel();
            panel1 = new Panel();
            tb_dob = new DateTimePicker();
            tb_sdt = new TextBox();
            tb_diachi = new TextBox();
            panel3 = new Panel();
            but_Add_cus = new Button();
            tb_pass_cus = new TextBox();
            lab_sdt = new Label();
            lab_diachi = new Label();
            lab_ngaysinh = new Label();
            tb_name_cus = new TextBox();
            tb_id_cus = new TextBox();
            lab_pass_cus = new Label();
            lab_name_cus = new Label();
            lab_id_cus = new Label();
            but_Seen = new Button();
            pic_Back = new PictureBox();
            data_list_customer = new DataGridView();
            lab_main = new Label();
            main_panel.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_list_customer).BeginInit();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.White;
            main_panel.Controls.Add(panel1);
            main_panel.Controls.Add(but_Seen);
            main_panel.Controls.Add(pic_Back);
            main_panel.Controls.Add(data_list_customer);
            main_panel.Controls.Add(lab_main);
            main_panel.Location = new Point(12, 12);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1124, 643);
            main_panel.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(tb_dob);
            panel1.Controls.Add(tb_sdt);
            panel1.Controls.Add(tb_diachi);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(tb_pass_cus);
            panel1.Controls.Add(lab_sdt);
            panel1.Controls.Add(lab_diachi);
            panel1.Controls.Add(lab_ngaysinh);
            panel1.Controls.Add(tb_name_cus);
            panel1.Controls.Add(tb_id_cus);
            panel1.Controls.Add(lab_pass_cus);
            panel1.Controls.Add(lab_name_cus);
            panel1.Controls.Add(lab_id_cus);
            panel1.Location = new Point(522, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 552);
            panel1.TabIndex = 28;
            // 
            // tb_dob
            // 
            tb_dob.CustomFormat = "HH:mm MM/dd/yyyy";
            tb_dob.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_dob.Format = DateTimePickerFormat.Custom;
            tb_dob.Location = new Point(187, 178);
            tb_dob.MaxDate = new DateTime(2024, 1, 13, 0, 0, 0, 0);
            tb_dob.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            tb_dob.Name = "tb_dob";
            tb_dob.Size = new Size(387, 38);
            tb_dob.TabIndex = 20;
            tb_dob.TabStop = false;
            tb_dob.Value = new DateTime(2024, 1, 13, 0, 0, 0, 0);
            // 
            // tb_sdt
            // 
            tb_sdt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_sdt.Location = new Point(187, 304);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new Size(384, 38);
            tb_sdt.TabIndex = 8;
            tb_sdt.TabStop = false;
            // 
            // tb_diachi
            // 
            tb_diachi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_diachi.Location = new Point(187, 240);
            tb_diachi.Name = "tb_diachi";
            tb_diachi.Size = new Size(384, 38);
            tb_diachi.TabIndex = 8;
            tb_diachi.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(but_Add_cus);
            panel3.Location = new Point(0, 493);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 56);
            panel3.TabIndex = 7;
            // 
            // but_Add_cus
            // 
            but_Add_cus.BackColor = Color.FromArgb(7, 47, 128);
            but_Add_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Add_cus.ForeColor = Color.White;
            but_Add_cus.Location = new Point(446, 0);
            but_Add_cus.Name = "but_Add_cus";
            but_Add_cus.Size = new Size(125, 53);
            but_Add_cus.TabIndex = 5;
            but_Add_cus.TabStop = false;
            but_Add_cus.Text = "Thêm";
            but_Add_cus.UseVisualStyleBackColor = false;
            but_Add_cus.Click += but_Add_cus_Click;
            // 
            // tb_pass_cus
            // 
            tb_pass_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_pass_cus.Location = new Point(187, 124);
            tb_pass_cus.Multiline = true;
            tb_pass_cus.Name = "tb_pass_cus";
            tb_pass_cus.Size = new Size(384, 33);
            tb_pass_cus.TabIndex = 14;
            tb_pass_cus.TabStop = false;
            // 
            // lab_sdt
            // 
            lab_sdt.AutoSize = true;
            lab_sdt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_sdt.Location = new Point(7, 311);
            lab_sdt.Name = "lab_sdt";
            lab_sdt.Size = new Size(53, 31);
            lab_sdt.TabIndex = 0;
            lab_sdt.Text = "SDT";
            // 
            // lab_diachi
            // 
            lab_diachi.AutoSize = true;
            lab_diachi.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_diachi.Location = new Point(7, 247);
            lab_diachi.Name = "lab_diachi";
            lab_diachi.Size = new Size(84, 31);
            lab_diachi.TabIndex = 0;
            lab_diachi.Text = "Địa chỉ";
            // 
            // lab_ngaysinh
            // 
            lab_ngaysinh.AutoSize = true;
            lab_ngaysinh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_ngaysinh.Location = new Point(7, 184);
            lab_ngaysinh.Name = "lab_ngaysinh";
            lab_ngaysinh.Size = new Size(116, 31);
            lab_ngaysinh.TabIndex = 0;
            lab_ngaysinh.Text = "Ngày sinh";
            // 
            // tb_name_cus
            // 
            tb_name_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_name_cus.Location = new Point(187, 70);
            tb_name_cus.Name = "tb_name_cus";
            tb_name_cus.Size = new Size(384, 38);
            tb_name_cus.TabIndex = 10;
            tb_name_cus.TabStop = false;
            // 
            // tb_id_cus
            // 
            tb_id_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_id_cus.Location = new Point(187, 20);
            tb_id_cus.Name = "tb_id_cus";
            tb_id_cus.Size = new Size(384, 38);
            tb_id_cus.TabIndex = 8;
            tb_id_cus.TabStop = false;
            // 
            // lab_pass_cus
            // 
            lab_pass_cus.AutoSize = true;
            lab_pass_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_pass_cus.Location = new Point(7, 127);
            lab_pass_cus.Name = "lab_pass_cus";
            lab_pass_cus.Size = new Size(110, 31);
            lab_pass_cus.TabIndex = 6;
            lab_pass_cus.Text = "Mật khẩu";
            // 
            // lab_name_cus
            // 
            lab_name_cus.AutoSize = true;
            lab_name_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_name_cus.Location = new Point(7, 73);
            lab_name_cus.Name = "lab_name_cus";
            lab_name_cus.Size = new Size(176, 31);
            lab_name_cus.TabIndex = 1;
            lab_name_cus.Text = "Tên người dùng";
            // 
            // lab_id_cus
            // 
            lab_id_cus.AutoSize = true;
            lab_id_cus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_id_cus.Location = new Point(7, 23);
            lab_id_cus.Name = "lab_id_cus";
            lab_id_cus.Size = new Size(174, 31);
            lab_id_cus.TabIndex = 0;
            lab_id_cus.Text = "Mã người dùng";
            // 
            // but_Seen
            // 
            but_Seen.BackColor = Color.FromArgb(7, 47, 128);
            but_Seen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Seen.ForeColor = Color.White;
            but_Seen.Location = new Point(334, 584);
            but_Seen.Name = "but_Seen";
            but_Seen.Size = new Size(173, 53);
            but_Seen.TabIndex = 27;
            but_Seen.TabStop = false;
            but_Seen.Text = "Xem tất cả";
            but_Seen.UseVisualStyleBackColor = false;
            but_Seen.Click += but_Seen_Click;
            // 
            // pic_Back
            // 
            pic_Back.Image = Properties.Resources.previous;
            pic_Back.Location = new Point(17, 3);
            pic_Back.Name = "pic_Back";
            pic_Back.Size = new Size(50, 48);
            pic_Back.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Back.TabIndex = 10;
            pic_Back.TabStop = false;
            pic_Back.Click += pic_Back_Click;
            // 
            // data_list_customer
            // 
            data_list_customer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_list_customer.Location = new Point(17, 88);
            data_list_customer.Name = "data_list_customer";
            data_list_customer.RowHeadersWidth = 51;
            data_list_customer.RowTemplate.Height = 29;
            data_list_customer.Size = new Size(490, 490);
            data_list_customer.TabIndex = 26;
            // 
            // lab_main
            // 
            lab_main.AutoSize = true;
            lab_main.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lab_main.ForeColor = Color.FromArgb(7, 47, 128);
            lab_main.Location = new Point(334, 3);
            lab_main.Name = "lab_main";
            lab_main.Size = new Size(511, 38);
            lab_main.TabIndex = 6;
            lab_main.Text = "Quản lý tài khoản - Thêm khách hàng";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 127);
            ClientSize = new Size(1148, 667);
            ControlBox = false;
            Controls.Add(main_panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Back).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_list_customer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel main_panel;
        private Button but_Seen;
        private PictureBox pic_Back;
        private DataGridView data_list_customer;
        private Label lab_main;
        private Panel panel1;
        private TextBox tb_sdt;
        private TextBox tb_diachi;
        private Panel panel3;
        private Button but_Add_cus;
        private TextBox tb_pass_cus;
        private Label lab_sdt;
        private Label lab_diachi;
        private Label lab_ngaysinh;
        private TextBox tb_name_cus;
        private TextBox tb_id_cus;
        private Label lab_pass_cus;
        private Label lab_name_cus;
        private Label lab_id_cus;
        private DateTimePicker tb_dob;
    }
}