namespace Dentist_Clinic_Management.Medicine
{
    partial class AddMedicine
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
            but_Seen = new Button();
            pic_Back = new PictureBox();
            data_list_patient = new DataGridView();
            lab_main = new Label();
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new DateTimePicker();
            lab_dateend = new Label();
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
            main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_list_patient).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.White;
            main_panel.Controls.Add(but_Seen);
            main_panel.Controls.Add(pic_Back);
            main_panel.Controls.Add(data_list_patient);
            main_panel.Controls.Add(lab_main);
            main_panel.Controls.Add(panel1);
            main_panel.Location = new Point(12, 12);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1124, 643);
            main_panel.TabIndex = 11;
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
            // data_list_patient
            // 
            data_list_patient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_list_patient.Location = new Point(17, 115);
            data_list_patient.Name = "data_list_patient";
            data_list_patient.RowHeadersWidth = 51;
            data_list_patient.RowTemplate.Height = 29;
            data_list_patient.Size = new Size(490, 463);
            data_list_patient.TabIndex = 26;
            // 
            // lab_main
            // 
            lab_main.AutoSize = true;
            lab_main.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lab_main.ForeColor = Color.FromArgb(7, 47, 128);
            lab_main.Location = new Point(334, 3);
            lab_main.Name = "lab_main";
            lab_main.Size = new Size(441, 38);
            lab_main.TabIndex = 6;
            lab_main.Text = "Quản lý danh sách thuốc - Thêm";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(lab_dateend);
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
            panel1.Location = new Point(530, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 522);
            panel1.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(115, 484);
            label1.Name = "label1";
            label1.Size = new Size(394, 31);
            label1.TabIndex = 20;
            label1.Text = "Lỗi thêm thuốc. Vui lòng kiểm tra lại.";
            label1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.CustomFormat = "HH:mm dd/MM/yyyy";
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Format = DateTimePickerFormat.Custom;
            textBox1.Location = new Point(176, 358);
            textBox1.MinDate = new DateTime(2024, 1, 11, 0, 0, 0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(387, 38);
            textBox1.TabIndex = 19;
            textBox1.TabStop = false;
            // 
            // lab_dateend
            // 
            lab_dateend.AutoSize = true;
            lab_dateend.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_dateend.Location = new Point(13, 364);
            lab_dateend.Name = "lab_dateend";
            lab_dateend.Size = new Size(151, 31);
            lab_dateend.TabIndex = 16;
            lab_dateend.Text = "Ngày hết hạn";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(176, 303);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(387, 38);
            textBox5.TabIndex = 15;
            textBox5.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(176, 188);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(387, 96);
            textBox4.TabIndex = 14;
            textBox4.TabStop = false;
            // 
            // but_Add
            // 
            but_Add.BackColor = Color.FromArgb(7, 47, 128);
            but_Add.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Add.ForeColor = Color.White;
            but_Add.Location = new Point(438, 428);
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
            textBox3.Location = new Point(176, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(387, 38);
            textBox3.TabIndex = 13;
            textBox3.TabStop = false;
            // 
            // tb_age
            // 
            tb_age.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_age.Location = new Point(176, 75);
            tb_age.Name = "tb_age";
            tb_age.Size = new Size(387, 38);
            tb_age.TabIndex = 10;
            tb_age.TabStop = false;
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_name.Location = new Point(176, 20);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(387, 38);
            tb_name.TabIndex = 8;
            tb_name.TabStop = false;
            // 
            // lab_unit
            // 
            lab_unit.AutoSize = true;
            lab_unit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_unit.Location = new Point(13, 304);
            lab_unit.Name = "lab_unit";
            lab_unit.Size = new Size(126, 31);
            lab_unit.TabIndex = 7;
            lab_unit.Text = "Đơn vị tính";
            // 
            // label_desc
            // 
            label_desc.AutoSize = true;
            label_desc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_desc.Location = new Point(11, 191);
            label_desc.Name = "label_desc";
            label_desc.Size = new Size(74, 31);
            label_desc.TabIndex = 6;
            label_desc.Text = "Mô tả";
            // 
            // lab_type
            // 
            lab_type.AutoSize = true;
            lab_type.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_type.Location = new Point(13, 134);
            lab_type.Name = "lab_type";
            lab_type.Size = new Size(120, 31);
            lab_type.TabIndex = 5;
            lab_type.Text = "Loại thuốc";
            // 
            // lab_name
            // 
            lab_name.AutoSize = true;
            lab_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_name.Location = new Point(13, 78);
            lab_name.Name = "lab_name";
            lab_name.Size = new Size(113, 31);
            lab_name.TabIndex = 1;
            lab_name.Text = "Tên thuốc";
            // 
            // lab_id
            // 
            lab_id.AutoSize = true;
            lab_id.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_id.Location = new Point(13, 23);
            lab_id.Name = "lab_id";
            lab_id.Size = new Size(111, 31);
            lab_id.TabIndex = 0;
            lab_id.Text = "Mã thuốc";
            // 
            // AddMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 127);
            ClientSize = new Size(1148, 667);
            ControlBox = false;
            Controls.Add(main_panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddMedicine";
            StartPosition = FormStartPosition.CenterScreen;
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Back).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_list_patient).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel main_panel;
        private Button but_Seen;
        private PictureBox pic_Back;
        private DataGridView data_list_patient;
        private Label lab_main;
        private Panel panel1;
        private Label label1;
        private DateTimePicker textBox1;
        private Label lab_dateend;
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
    }
}