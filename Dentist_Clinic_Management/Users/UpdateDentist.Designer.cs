﻿namespace Dentist_Clinic_Management.Users
{
    partial class UpdateDentist
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
            tb_specilize = new TextBox();
            panel3 = new Panel();
            but_Update = new Button();
            tb_pass = new TextBox();
            lab_specilize = new Label();
            tb_name = new TextBox();
            tb_id = new TextBox();
            lab_pass = new Label();
            lab_name = new Label();
            lab_id = new Label();
            but_Seen = new Button();
            pic_Back = new PictureBox();
            data_list_dentist = new DataGridView();
            lab_main = new Label();
            main_panel.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)data_list_dentist).BeginInit();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.BackColor = Color.White;
            main_panel.Controls.Add(panel1);
            main_panel.Controls.Add(but_Seen);
            main_panel.Controls.Add(pic_Back);
            main_panel.Controls.Add(data_list_dentist);
            main_panel.Controls.Add(lab_main);
            main_panel.Location = new Point(12, 12);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1124, 643);
            main_panel.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(tb_specilize);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(tb_pass);
            panel1.Controls.Add(lab_specilize);
            panel1.Controls.Add(tb_name);
            panel1.Controls.Add(tb_id);
            panel1.Controls.Add(lab_pass);
            panel1.Controls.Add(lab_name);
            panel1.Controls.Add(lab_id);
            panel1.Location = new Point(522, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 552);
            panel1.TabIndex = 28;
            // 
            // tb_specilize
            // 
            tb_specilize.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_specilize.Location = new Point(187, 175);
            tb_specilize.Name = "tb_specilize";
            tb_specilize.Size = new Size(384, 38);
            tb_specilize.TabIndex = 8;
            tb_specilize.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(but_Update);
            panel3.Location = new Point(0, 493);
            panel3.Name = "panel3";
            panel3.Size = new Size(590, 56);
            panel3.TabIndex = 7;
            // 
            // but_Update
            // 
            but_Update.BackColor = Color.FromArgb(7, 47, 128);
            but_Update.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            but_Update.ForeColor = Color.White;
            but_Update.Location = new Point(446, 0);
            but_Update.Name = "but_Update";
            but_Update.Size = new Size(125, 53);
            but_Update.TabIndex = 5;
            but_Update.TabStop = false;
            but_Update.Text = "Cập nhật";
            but_Update.UseVisualStyleBackColor = false;
            but_Update.Click += but_Update_Click;
            // 
            // tb_pass
            // 
            tb_pass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_pass.Location = new Point(187, 124);
            tb_pass.Multiline = true;
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(384, 33);
            tb_pass.TabIndex = 14;
            tb_pass.TabStop = false;
            // 
            // lab_specilize
            // 
            lab_specilize.AutoSize = true;
            lab_specilize.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_specilize.Location = new Point(7, 182);
            lab_specilize.Name = "lab_specilize";
            lab_specilize.Size = new Size(142, 31);
            lab_specilize.TabIndex = 0;
            lab_specilize.Text = "Chuyên môn";
            // 
            // tb_name
            // 
            tb_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_name.Location = new Point(187, 70);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(384, 38);
            tb_name.TabIndex = 10;
            tb_name.TabStop = false;
            // 
            // tb_id
            // 
            tb_id.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_id.Location = new Point(187, 20);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(384, 38);
            tb_id.TabIndex = 8;
            tb_id.TabStop = false;
            // 
            // lab_pass
            // 
            lab_pass.AutoSize = true;
            lab_pass.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lab_pass.Location = new Point(7, 127);
            lab_pass.Name = "lab_pass";
            lab_pass.Size = new Size(110, 31);
            lab_pass.TabIndex = 6;
            lab_pass.Text = "Mật khẩu";
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
            // data_list_dentist
            // 
            data_list_dentist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_list_dentist.Location = new Point(17, 88);
            data_list_dentist.Name = "data_list_dentist";
            data_list_dentist.RowHeadersWidth = 51;
            data_list_dentist.RowTemplate.Height = 29;
            data_list_dentist.Size = new Size(490, 490);
            data_list_dentist.TabIndex = 26;
            // 
            // lab_main
            // 
            lab_main.AutoSize = true;
            lab_main.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lab_main.ForeColor = Color.FromArgb(7, 47, 128);
            lab_main.Location = new Point(334, 3);
            lab_main.Name = "lab_main";
            lab_main.Size = new Size(492, 38);
            lab_main.TabIndex = 6;
            lab_main.Text = "Quản lý tài khoản - Chỉnh sửa nha sĩ";
            // 
            // UpdateDentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 127);
            ClientSize = new Size(1148, 667);
            ControlBox = false;
            Controls.Add(main_panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UpdateDentist";
            StartPosition = FormStartPosition.CenterScreen;
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Back).EndInit();
            ((System.ComponentModel.ISupportInitialize)data_list_dentist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel main_panel;
        private Panel panel1;
        private TextBox tb_specilize;
        private Panel panel3;
        private Button but_Update;
        private TextBox tb_pass;
        private Label lab_specilize;
        private TextBox tb_name;
        private TextBox tb_id;
        private Label lab_pass;
        private Label lab_name;
        private Label lab_id;
        private Button but_Seen;
        private PictureBox pic_Back;
        private DataGridView data_list_dentist;
        private Label lab_main;
    }
}