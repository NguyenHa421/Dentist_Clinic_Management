namespace Dentist_Clinic_Management.Medicine
{
    partial class MedList_Admin
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
            label1 = new Label();
            but_del = new Button();
            textBox1 = new TextBox();
            lab_dateend = new Label();
            but_Update = new Button();
            textBox5 = new TextBox();
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
            data_list_medi = new DataGridView();
            but_find = new Button();
            text_name_cli = new TextBox();
            main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Back).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_list_medi).BeginInit();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.White;
            main_panel.Controls.Add(pic_Back);
            main_panel.Controls.Add(panel1);
            main_panel.Controls.Add(lab_main);
            main_panel.Controls.Add(but_Seen);
            main_panel.Controls.Add(data_list_medi);
            main_panel.Controls.Add(but_find);
            main_panel.Controls.Add(text_name_cli);
            main_panel.Location = new Point(12, 12);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1124, 643);
            main_panel.TabIndex = 10;
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(but_del);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lab_dateend);
            panel1.Controls.Add(but_Update);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(but_Add);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(96, 480);
            label1.Name = "label1";
            label1.Size = new Size(379, 31);
            label1.TabIndex = 21;
            label1.Text = "Lỗi xóa thuốc. Vui lòng kiểm tra lại.";
            label1.Visible = false;
            // 
            // but_del
            // 
            but_del.BackColor = Color.FromArgb(7, 47, 128);
            but_del.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_del.ForeColor = Color.White;
            but_del.Location = new Point(413, 410);
            but_del.Name = "but_del";
            but_del.Size = new Size(125, 53);
            but_del.TabIndex = 19;
            but_del.TabStop = false;
            but_del.Text = "Xóa";
            but_del.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(161, 355);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(410, 38);
            textBox1.TabIndex = 18;
            textBox1.TabStop = false;
            // 
            // lab_dateend
            // 
            lab_dateend.AutoSize = true;
            lab_dateend.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_dateend.Location = new Point(7, 358);
            lab_dateend.Name = "lab_dateend";
            lab_dateend.Size = new Size(151, 31);
            lab_dateend.TabIndex = 16;
            lab_dateend.Text = "Ngày hết hạn";
            // 
            // but_Update
            // 
            but_Update.BackColor = Color.FromArgb(7, 47, 128);
            but_Update.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Update.ForeColor = Color.White;
            but_Update.Location = new Point(236, 410);
            but_Update.Name = "but_Update";
            but_Update.Size = new Size(125, 53);
            but_Update.TabIndex = 6;
            but_Update.TabStop = false;
            but_Update.Text = "Cập nhật";
            but_Update.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(161, 297);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(410, 38);
            textBox5.TabIndex = 15;
            textBox5.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(161, 175);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(410, 107);
            textBox4.TabIndex = 14;
            textBox4.TabStop = false;
            // 
            // but_Add
            // 
            but_Add.BackColor = Color.FromArgb(7, 47, 128);
            but_Add.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Add.ForeColor = Color.White;
            but_Add.Location = new Point(61, 410);
            but_Add.Name = "but_Add";
            but_Add.Size = new Size(125, 53);
            but_Add.TabIndex = 5;
            but_Add.TabStop = false;
            but_Add.Text = "Thêm";
            but_Add.UseVisualStyleBackColor = false;
            but_Add.Click += but_Add_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(161, 124);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(410, 38);
            textBox3.TabIndex = 13;
            textBox3.TabStop = false;
            // 
            // tb_age
            // 
            tb_age.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_age.Location = new Point(161, 70);
            tb_age.Name = "tb_age";
            tb_age.ReadOnly = true;
            tb_age.Size = new Size(410, 38);
            tb_age.TabIndex = 10;
            tb_age.TabStop = false;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_name.Location = new Point(161, 20);
            tb_name.Name = "tb_name";
            tb_name.ReadOnly = true;
            tb_name.Size = new Size(410, 38);
            tb_name.TabIndex = 8;
            tb_name.TabStop = false;
            // 
            // lab_unit
            // 
            lab_unit.AutoSize = true;
            lab_unit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_unit.Location = new Point(7, 298);
            lab_unit.Name = "lab_unit";
            lab_unit.Size = new Size(126, 31);
            lab_unit.TabIndex = 7;
            lab_unit.Text = "Đơn vị tính";
            // 
            // label_desc
            // 
            label_desc.AutoSize = true;
            label_desc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_desc.Location = new Point(5, 177);
            label_desc.Name = "label_desc";
            label_desc.Size = new Size(74, 31);
            label_desc.TabIndex = 6;
            label_desc.Text = "Mô tả";
            // 
            // lab_type
            // 
            lab_type.AutoSize = true;
            lab_type.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_type.Location = new Point(7, 127);
            lab_type.Name = "lab_type";
            lab_type.Size = new Size(120, 31);
            lab_type.TabIndex = 5;
            lab_type.Text = "Loại thuốc";
            // 
            // lab_name
            // 
            lab_name.AutoSize = true;
            lab_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_name.Location = new Point(7, 73);
            lab_name.Name = "lab_name";
            lab_name.Size = new Size(113, 31);
            lab_name.TabIndex = 1;
            lab_name.Text = "Tên thuốc";
            // 
            // lab_id
            // 
            lab_id.AutoSize = true;
            lab_id.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_id.Location = new Point(7, 23);
            lab_id.Name = "lab_id";
            lab_id.Size = new Size(111, 31);
            lab_id.TabIndex = 0;
            lab_id.Text = "Mã thuốc";
            // 
            // lab_main
            // 
            lab_main.AutoSize = true;
            lab_main.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lab_main.ForeColor = Color.FromArgb(7, 47, 128);
            lab_main.Location = new Point(374, 2);
            lab_main.Name = "lab_main";
            lab_main.Size = new Size(340, 38);
            lab_main.TabIndex = 6;
            lab_main.Text = "Quản lý danh sách thuốc";
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
            // data_list_medi
            // 
            data_list_medi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_list_medi.Location = new Point(17, 119);
            data_list_medi.Name = "data_list_medi";
            data_list_medi.RowHeadersWidth = 51;
            data_list_medi.RowTemplate.Height = 29;
            data_list_medi.Size = new Size(492, 462);
            data_list_medi.TabIndex = 2;
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
            but_find.Click += but_find_Click_1;
            // 
            // text_name_cli
            // 
            text_name_cli.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_name_cli.Location = new Point(17, 68);
            text_name_cli.Name = "text_name_cli";
            text_name_cli.PlaceholderText = "Nhập tên thuốc";
            text_name_cli.Size = new Size(290, 38);
            text_name_cli.TabIndex = 0;
            text_name_cli.TabStop = false;
            // 
            // MedList_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1148, 667);
            ControlBox = false;
            Controls.Add(main_panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MedList_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Back).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_list_medi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel main_panel;
        private PictureBox pic_Back;
        private Panel panel1;
        private Label label1;
        private Button but_del;
        private TextBox textBox1;
        private Label lab_dateend;
        private Button but_Update;
        private TextBox textBox5;
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
        private DataGridView data_list_medi;
        private Button but_find;
        private TextBox text_name_cli;
    }
}