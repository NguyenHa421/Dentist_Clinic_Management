namespace Dentist_Clinic_Management.Staff
{
    partial class Payment
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
            lb_Success2 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            tb_Choose = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            tb_NameClient = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lb_Success2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(tb_Choose);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tb_NameClient);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1111, 628);
            panel1.TabIndex = 0;
            // 
            // lb_Success2
            // 
            lb_Success2.AutoSize = true;
            lb_Success2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Success2.Location = new Point(719, 440);
            lb_Success2.Name = "lb_Success2";
            lb_Success2.Size = new Size(336, 25);
            lb_Success2.TabIndex = 119;
            lb_Success2.Text = "Hiện thông tin thanh toán thành công!";
            lb_Success2.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(8, 48, 107);
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(904, 374);
            button2.Name = "button2";
            button2.Size = new Size(178, 60);
            button2.TabIndex = 118;
            button2.Text = "Thanh toán";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(474, 428);
            dataGridView1.TabIndex = 115;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.CustomFormat = "mm:HH";
            dateTimePicker1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(754, 210);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(328, 32);
            dateTimePicker1.TabIndex = 106;
            dateTimePicker1.Value = new DateTime(2024, 1, 4, 0, 0, 0, 0);
            // 
            // tb_Choose
            // 
            tb_Choose.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Choose.CustomFormat = "dd/MM/yyyy";
            tb_Choose.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Choose.Format = DateTimePickerFormat.Custom;
            tb_Choose.Location = new Point(754, 150);
            tb_Choose.Name = "tb_Choose";
            tb_Choose.Size = new Size(328, 32);
            tb_Choose.TabIndex = 106;
            tb_Choose.Value = new DateTime(2024, 1, 4, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(580, 217);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 110;
            label5.Text = "Giờ hẹn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(580, 156);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 108;
            label4.Text = "Ngày hẹn";
            // 
            // tb_NameClient
            // 
            tb_NameClient.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_NameClient.Location = new Point(754, 276);
            tb_NameClient.Name = "tb_NameClient";
            tb_NameClient.Size = new Size(328, 32);
            tb_NameClient.TabIndex = 107;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 48, 107);
            label1.Location = new Point(504, 9);
            label1.Name = "label1";
            label1.Size = new Size(130, 30);
            label1.TabIndex = 89;
            label1.Text = "Thanh toán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(580, 283);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 87;
            label2.Text = "Tên bệnh nhân";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(8, 48, 107);
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(613, 374);
            button3.Name = "button3";
            button3.Size = new Size(178, 60);
            button3.TabIndex = 83;
            button3.Text = "Quay lại";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 48, 107);
            ClientSize = new Size(1135, 652);
            ControlBox = false;
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "Payment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button button3;
        private Label label4;
        private TextBox tb_NameClient;
        private DateTimePicker tb_Choose;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private DataGridView dataGridView1;
        private Label lb_Success2;
        private Button button2;
    }
}