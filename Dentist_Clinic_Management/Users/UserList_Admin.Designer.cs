namespace Dentist_Clinic_Management.Users
{
    partial class UserList_Admin
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
            pic_Back = new PictureBox();
            panel1 = new Panel();
            but_del = new Button();
            but_Update = new Button();
            textBox4 = new TextBox();
            but_Add = new Button();
            textBox3 = new TextBox();
            tb_age = new TextBox();
            tb_name = new TextBox();
            lab_unit = new Label();
            label_desc = new Label();
            lab_type = new Label();
            lab_name = new Label();
            lab_id = new Label();
            lab_main = new Label();
            but_Seen = new Button();
            data_list_acc = new DataGridView();
            but_find = new Button();
            text_name_cli = new TextBox();
            textBox2 = new TextBox();
            panel2 = new Panel();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Back).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_list_acc).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.White;
            main_panel.Controls.Add(panel3);
            main_panel.Controls.Add(pic_Back);
            main_panel.Controls.Add(panel1);
            main_panel.Controls.Add(lab_main);
            main_panel.Controls.Add(but_Seen);
            main_panel.Controls.Add(data_list_acc);
            main_panel.Controls.Add(but_find);
            main_panel.Controls.Add(text_name_cli);
            main_panel.Location = new Point(12, 12);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1124, 643);
            main_panel.TabIndex = 11;
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
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(tb_age);
            panel1.Controls.Add(tb_name);
            panel1.Controls.Add(lab_unit);
            panel1.Controls.Add(label_desc);
            panel1.Controls.Add(lab_type);
            panel1.Controls.Add(lab_name);
            panel1.Controls.Add(lab_id);
            panel1.Location = new Point(528, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 522);
            panel1.TabIndex = 7;
            // 
            // but_del
            // 
            but_del.BackColor = Color.FromArgb(7, 47, 128);
            but_del.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_del.ForeColor = Color.White;
            but_del.Location = new Point(462, 0);
            but_del.Name = "but_del";
            but_del.Size = new Size(125, 53);
            but_del.TabIndex = 19;
            but_del.TabStop = false;
            but_del.Text = "Xóa";
            but_del.UseVisualStyleBackColor = false;
            // 
            // but_Update
            // 
            but_Update.BackColor = Color.FromArgb(7, 47, 128);
            but_Update.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Update.ForeColor = Color.White;
            but_Update.Location = new Point(225, 0);
            but_Update.Name = "but_Update";
            but_Update.Size = new Size(125, 53);
            but_Update.TabIndex = 6;
            but_Update.TabStop = false;
            but_Update.Text = "Cập nhật";
            but_Update.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(187, 175);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(384, 33);
            textBox4.TabIndex = 14;
            textBox4.TabStop = false;
            // 
            // but_Add
            // 
            but_Add.BackColor = Color.FromArgb(7, 47, 128);
            but_Add.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Add.ForeColor = Color.White;
            but_Add.Location = new Point(3, 0);
            but_Add.Name = "but_Add";
            but_Add.Size = new Size(125, 53);
            but_Add.TabIndex = 5;
            but_Add.TabStop = false;
            but_Add.Text = "Thêm";
            but_Add.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(187, 124);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(384, 38);
            textBox3.TabIndex = 13;
            textBox3.TabStop = false;
            // 
            // tb_age
            // 
            tb_age.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_age.Location = new Point(187, 70);
            tb_age.Name = "tb_age";
            tb_age.ReadOnly = true;
            tb_age.Size = new Size(384, 38);
            tb_age.TabIndex = 10;
            tb_age.TabStop = false;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_name.Location = new Point(187, 20);
            tb_name.Name = "tb_name";
            tb_name.ReadOnly = true;
            tb_name.Size = new Size(384, 38);
            tb_name.TabIndex = 8;
            tb_name.TabStop = false;
            // 
            // lab_unit
            // 
            lab_unit.AutoSize = true;
            lab_unit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_unit.Location = new Point(7, 232);
            lab_unit.Name = "lab_unit";
            lab_unit.Size = new Size(79, 31);
            lab_unit.TabIndex = 7;
            lab_unit.Text = "Vai trò";
            // 
            // label_desc
            // 
            label_desc.AutoSize = true;
            label_desc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_desc.Location = new Point(5, 177);
            label_desc.Name = "label_desc";
            label_desc.Size = new Size(110, 31);
            label_desc.TabIndex = 6;
            label_desc.Text = "Mật khẩu";
            // 
            // lab_type
            // 
            lab_type.AutoSize = true;
            lab_type.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_type.Location = new Point(7, 127);
            lab_type.Name = "lab_type";
            lab_type.Size = new Size(166, 31);
            lab_type.TabIndex = 5;
            lab_type.Text = "Tên đăng nhập";
            // 
            // lab_name
            // 
            lab_name.AutoSize = true;
            lab_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_name.Location = new Point(7, 73);
            lab_name.Name = "lab_name";
            lab_name.Size = new Size(176, 31);
            lab_name.TabIndex = 1;
            lab_name.Text = "Tên người dùng";
            // 
            // lab_id
            // 
            lab_id.AutoSize = true;
            lab_id.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_id.Location = new Point(7, 23);
            lab_id.Name = "lab_id";
            lab_id.Size = new Size(174, 31);
            lab_id.TabIndex = 0;
            lab_id.Text = "Mã người dùng";
            // 
            // lab_main
            // 
            lab_main.AutoSize = true;
            lab_main.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lab_main.ForeColor = Color.FromArgb(7, 47, 128);
            lab_main.Location = new Point(464, 3);
            lab_main.Name = "lab_main";
            lab_main.Size = new Size(250, 38);
            lab_main.TabIndex = 6;
            lab_main.Text = "Quản lý tài khoản";
            // 
            // but_Seen
            // 
            but_Seen.BackColor = Color.FromArgb(7, 47, 128);
            but_Seen.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Seen.ForeColor = Color.White;
            but_Seen.Location = new Point(336, 587);
            but_Seen.Name = "but_Seen";
            but_Seen.Size = new Size(173, 53);
            but_Seen.TabIndex = 4;
            but_Seen.TabStop = false;
            but_Seen.Text = "Xem tất cả";
            but_Seen.UseVisualStyleBackColor = false;
            // 
            // data_list_acc
            // 
            data_list_acc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_list_acc.Location = new Point(17, 119);
            data_list_acc.Name = "data_list_acc";
            data_list_acc.RowHeadersWidth = 51;
            data_list_acc.RowTemplate.Height = 29;
            data_list_acc.Size = new Size(492, 462);
            data_list_acc.TabIndex = 2;
            // 
            // but_find
            // 
            but_find.BackColor = Color.FromArgb(7, 47, 128);
            but_find.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_find.ForeColor = Color.White;
            but_find.Location = new Point(336, 60);
            but_find.Name = "but_find";
            but_find.Size = new Size(173, 53);
            but_find.TabIndex = 1;
            but_find.TabStop = false;
            but_find.Text = "Tìm kiếm";
            but_find.UseVisualStyleBackColor = false;
            // 
            // text_name_cli
            // 
            text_name_cli.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_name_cli.Location = new Point(17, 68);
            text_name_cli.Name = "text_name_cli";
            text_name_cli.PlaceholderText = "Nhập tên tài khoản";
            text_name_cli.Size = new Size(290, 38);
            text_name_cli.TabIndex = 0;
            text_name_cli.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(187, 232);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(384, 33);
            textBox2.TabIndex = 14;
            textBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(1, 272);
            panel2.Name = "panel2";
            panel2.Size = new Size(590, 135);
            panel2.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(187, 70);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(384, 38);
            textBox7.TabIndex = 10;
            textBox7.TabStop = false;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(187, 10);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(384, 38);
            textBox8.TabIndex = 8;
            textBox8.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 73);
            label6.Name = "label6";
            label6.Size = new Size(170, 31);
            label6.TabIndex = 1;
            label6.Text = "ExtendedProp2";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(7, 17);
            label7.Name = "label7";
            label7.Size = new Size(170, 31);
            label7.TabIndex = 0;
            label7.Text = "ExtendedProp1";
            label7.Click += label7_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(but_Add);
            panel3.Controls.Add(but_del);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(but_Update);
            panel3.Location = new Point(528, 531);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 56);
            panel3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, -4);
            label1.Name = "label1";
            label1.Size = new Size(170, 31);
            label1.TabIndex = 1;
            label1.Text = "ExtendedProp2";
            label1.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(187, -7);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(384, 38);
            textBox1.TabIndex = 10;
            textBox1.TabStop = false;
            // 
            // UserList_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1148, 667);
            ControlBox = false;
            Controls.Add(main_panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserList_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Back).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_list_acc).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel main_panel;
        private PictureBox pic_Back;
        private Panel panel1;
        private Button but_del;
        private Button but_Update;
        private TextBox textBox4;
        private Button but_Add;
        private TextBox textBox3;
        private TextBox tb_age;
        private TextBox tb_name;
        private Label lab_unit;
        private Label label_desc;
        private Label lab_type;
        private Label lab_name;
        private Label lab_id;
        private Label lab_main;
        private Button but_Seen;
        private DataGridView data_list_acc;
        private Button but_find;
        private TextBox text_name_cli;
        private Panel panel2;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private Panel panel3;
        private TextBox textBox1;
        private Label label1;
    }
}