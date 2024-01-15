namespace Dentist_Clinic_Management.Staff
{
    partial class PatientRecord_Staff
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
            btnSearch = new Button();
            lb_Header = new Label();
            txbPhoneNum = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnAddBill = new Button();
            label3 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            lb_Name = new Label();
            textBox1 = new TextBox();
            lb_Header2 = new Label();
            lb_success = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(lb_Header);
            panel1.Controls.Add(txbPhoneNum);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 502);
            panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Navy;
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(283, 59);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 37);
            btnSearch.TabIndex = 16;
            btnSearch.TabStop = false;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // lb_Header
            // 
            lb_Header.AutoSize = true;
            lb_Header.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Header.Location = new Point(57, 17);
            lb_Header.Name = "lb_Header";
            lb_Header.Size = new Size(311, 35);
            lb_Header.TabIndex = 3;
            lb_Header.Text = "DANH SÁCH BỆNH NHÂN";
            // 
            // txbPhoneNum
            // 
            txbPhoneNum.Font = new Font("Segoe UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point);
            txbPhoneNum.Location = new Point(25, 66);
            txbPhoneNum.Name = "txbPhoneNum";
            txbPhoneNum.PlaceholderText = "Số điện thoại";
            txbPhoneNum.Size = new Size(240, 27);
            txbPhoneNum.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(391, 373);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lb_success);
            panel2.Controls.Add(btnAddBill);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(lb_Name);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lb_Header2);
            panel2.Location = new Point(453, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 502);
            panel2.TabIndex = 1;
            // 
            // btnAddBill
            // 
            btnAddBill.BackColor = Color.Navy;
            btnAddBill.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddBill.ForeColor = Color.White;
            btnAddBill.Location = new Point(110, 364);
            btnAddBill.Name = "btnAddBill";
            btnAddBill.Size = new Size(151, 37);
            btnAddBill.TabIndex = 16;
            btnAddBill.TabStop = false;
            btnAddBill.Text = "Tạo hóa đơn";
            btnAddBill.UseVisualStyleBackColor = false;
            btnAddBill.Click += btnAddBill_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(76, 288);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 12;
            label3.Text = "Thuốc:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(152, 287);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 26);
            textBox4.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 243);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 10;
            label2.Text = "Phí khám:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 242);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 26);
            textBox3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 196);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 8;
            label1.Text = "Dịch vụ khám:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 195);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 26);
            textBox2.TabIndex = 7;
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Name.Location = new Point(71, 155);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(70, 25);
            lb_Name.TabIndex = 6;
            lb_Name.Text = "Họ tên:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 26);
            textBox1.TabIndex = 5;
            // 
            // lb_Header2
            // 
            lb_Header2.AutoSize = true;
            lb_Header2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Header2.Location = new Point(27, 66);
            lb_Header2.Name = "lb_Header2";
            lb_Header2.Size = new Size(317, 35);
            lb_Header2.TabIndex = 4;
            lb_Header2.Text = "THÔNG TIN THANH TOÁN";
            // 
            // lb_success
            // 
            lb_success.AutoSize = true;
            lb_success.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point);
            lb_success.Location = new Point(115, 417);
            lb_success.Name = "lb_success";
            lb_success.Size = new Size(140, 25);
            lb_success.TabIndex = 17;
            lb_success.Text = "Tạo thành công.";
            lb_success.Visible = false;
            // 
            // PatientRecord_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(832, 506);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PatientRecord_Staff";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label lb_Header;
        private TextBox txbPhoneNum;
        private Label lb_Header2;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox2;
        private Label lb_Name;
        private Label label3;
        private TextBox textBox4;
        private Button btnSearch;
        private Button btnAddBill;
        private Label lb_success;
    }
}