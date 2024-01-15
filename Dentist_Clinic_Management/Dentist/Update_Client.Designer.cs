namespace Dentist_Clinic_Management.Dentist
{
    partial class Update_Client
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
            textBox5 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            tb_Use = new ComboBox();
            tb_Dentist = new ComboBox();
            tb_Date = new DateTimePicker();
            label3 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            lb_Success = new Label();
            label1 = new Label();
            lb_rg_phone = new Label();
            label2 = new Label();
            lb_rg_datebirth = new Label();
            pn_rg_Name = new Panel();
            tb_Name = new TextBox();
            pc_rg_name = new PictureBox();
            button1 = new Button();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pn_rg_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_rg_name).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(tb_Use);
            panel1.Controls.Add(tb_Dentist);
            panel1.Controls.Add(tb_Date);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(lb_Success);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lb_rg_phone);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lb_rg_datebirth);
            panel1.Controls.Add(pn_rg_Name);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1272, 843);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(895, 316);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(258, 38);
            textBox5.TabIndex = 71;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(1167, 317);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(63, 38);
            numericUpDown1.TabIndex = 64;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // tb_Use
            // 
            tb_Use.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Use.FormattingEnabled = true;
            tb_Use.Items.AddRange(new object[] { "Chụp X-Quang", "Trám răng", "Cạo vôi" });
            tb_Use.Location = new Point(895, 240);
            tb_Use.Name = "tb_Use";
            tb_Use.Size = new Size(335, 39);
            tb_Use.TabIndex = 11;
            // 
            // tb_Dentist
            // 
            tb_Dentist.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Dentist.FormattingEnabled = true;
            tb_Dentist.Items.AddRange(new object[] { "Nguyễn Quang" });
            tb_Dentist.Location = new Point(895, 179);
            tb_Dentist.Name = "tb_Dentist";
            tb_Dentist.Size = new Size(335, 39);
            tb_Dentist.TabIndex = 10;
            tb_Dentist.SelectedIndexChanged += tb_Dentist_SelectedIndexChanged;
            // 
            // tb_Date
            // 
            tb_Date.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Date.CustomFormat = "dd/MM/yyyy";
            tb_Date.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Date.Format = DateTimePickerFormat.Custom;
            tb_Date.Location = new Point(895, 120);
            tb_Date.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            tb_Date.MinDate = new DateTime(2024, 1, 3, 0, 0, 0, 0);
            tb_Date.Name = "tb_Date";
            tb_Date.Size = new Size(335, 38);
            tb_Date.TabIndex = 10;
            tb_Date.Value = new DateTime(2024, 1, 3, 12, 19, 52, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(726, 319);
            label3.Name = "label3";
            label3.Size = new Size(76, 31);
            label3.TabIndex = 62;
            label3.Text = "Thuốc";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(8, 48, 107);
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(527, 113);
            button2.Name = "button2";
            button2.Size = new Size(134, 45);
            button2.TabIndex = 61;
            button2.Text = "Tìm kiếm";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 179);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(634, 512);
            dataGridView1.TabIndex = 60;
            // 
            // lb_Success
            // 
            lb_Success.AutoSize = true;
            lb_Success.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Success.Location = new Point(873, 728);
            lb_Success.Name = "lb_Success";
            lb_Success.Size = new Size(235, 31);
            lb_Success.TabIndex = 59;
            lb_Success.Text = "Cập nhật thành công!";
            lb_Success.Visible = false;
            lb_Success.Click += lb_Success_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(397, 35);
            label1.Name = "label1";
            label1.Size = new Size(362, 38);
            label1.TabIndex = 58;
            label1.Text = "Cập nhật hồ sơ bệnh nhân";
            // 
            // lb_rg_phone
            // 
            lb_rg_phone.AutoSize = true;
            lb_rg_phone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_phone.Location = new Point(721, 248);
            lb_rg_phone.Name = "lb_rg_phone";
            lb_rg_phone.Size = new Size(150, 31);
            lb_rg_phone.TabIndex = 56;
            lb_rg_phone.Text = "Dịch vụ dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(721, 187);
            label2.Name = "label2";
            label2.Size = new Size(78, 31);
            label2.TabIndex = 54;
            label2.Text = "Nha sĩ";
            // 
            // lb_rg_datebirth
            // 
            lb_rg_datebirth.AutoSize = true;
            lb_rg_datebirth.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rg_datebirth.Location = new Point(721, 127);
            lb_rg_datebirth.Name = "lb_rg_datebirth";
            lb_rg_datebirth.Size = new Size(130, 31);
            lb_rg_datebirth.TabIndex = 52;
            lb_rg_datebirth.Text = "Ngày khám";
            // 
            // pn_rg_Name
            // 
            pn_rg_Name.BorderStyle = BorderStyle.FixedSingle;
            pn_rg_Name.Controls.Add(tb_Name);
            pn_rg_Name.Controls.Add(pc_rg_name);
            pn_rg_Name.Location = new Point(27, 113);
            pn_rg_Name.Name = "pn_rg_Name";
            pn_rg_Name.Size = new Size(399, 45);
            pn_rg_Name.TabIndex = 51;
            // 
            // tb_Name
            // 
            tb_Name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Name.Location = new Point(54, 3);
            tb_Name.Name = "tb_Name";
            tb_Name.PlaceholderText = "Nhập họ tên bệnh nhân";
            tb_Name.RightToLeft = RightToLeft.No;
            tb_Name.Size = new Size(331, 38);
            tb_Name.TabIndex = 14;
            tb_Name.TabStop = false;
            // 
            // pc_rg_name
            // 
            pc_rg_name.Image = Properties.Resources.user;
            pc_rg_name.Location = new Point(5, 3);
            pc_rg_name.Name = "pc_rg_name";
            pc_rg_name.Size = new Size(46, 36);
            pc_rg_name.SizeMode = PictureBoxSizeMode.Zoom;
            pc_rg_name.TabIndex = 9;
            pc_rg_name.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 48, 107);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1051, 631);
            button1.Name = "button1";
            button1.Size = new Size(178, 60);
            button1.TabIndex = 49;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(8, 48, 107);
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(736, 631);
            button3.Name = "button3";
            button3.Size = new Size(178, 60);
            button3.TabIndex = 48;
            button3.Text = "Quay lại";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(895, 432);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(335, 169);
            dataGridView2.TabIndex = 72;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(8, 48, 107);
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1096, 374);
            button4.Name = "button4";
            button4.Size = new Size(134, 45);
            button4.TabIndex = 73;
            button4.Text = "Thêm";
            button4.UseVisualStyleBackColor = false;
            // 
            // Update_Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(1297, 869);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Update_Client";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pn_rg_Name.ResumeLayout(false);
            pn_rg_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_rg_name).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lb_Success;
        private Label label1;
        private Label lb_rg_phone;
        private Label label2;
        private Label lb_rg_datebirth;
        private DateTimePicker tb_Date;
        private Panel pn_rg_Name;
        private TextBox tb_Name;
        private PictureBox pc_rg_name;
        private Button button1;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label3;
        private ComboBox tb_Dentist;
        private ComboBox tb_Use;
        private NumericUpDown numericUpDown1;
        private TextBox textBox5;
        private Button button4;
        private DataGridView dataGridView2;
    }
}