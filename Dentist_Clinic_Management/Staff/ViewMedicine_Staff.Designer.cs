﻿namespace Dentist_Clinic_Management.Staff
{
    partial class ViewMedicine_Staff
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
            label1 = new Label();
            panel2 = new Panel();
            btnSearch = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(28, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 63);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.7090912F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(280, 15);
            label1.Name = "label1";
            label1.Size = new Size(237, 32);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC THUỐC";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(28, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 439);
            panel2.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Navy;
            btnSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(602, 10);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 37);
            btnSearch.TabIndex = 15;
            btnSearch.TabStop = false;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.7454548F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 12);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 3;
            label2.Text = "Tên thuốc";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 26);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(742, 375);
            dataGridView1.TabIndex = 0;
            // 
            // ViewMedicine_Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(856, 526);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ViewMedicine_Staff";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button btnSearch;
    }
}