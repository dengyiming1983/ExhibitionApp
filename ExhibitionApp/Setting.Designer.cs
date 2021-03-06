﻿namespace ExhibitionApp
{
    partial class Setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_slide_path = new System.Windows.Forms.TextBox();
            this.tb_video_path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save_slide_path = new System.Windows.Forms.Button();
            this.btn_save_video_path = new System.Windows.Forms.Button();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_add_record = new System.Windows.Forms.Button();
            this.btn_change_pwd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_save_record = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_btn_name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_link = new System.Windows.Forms.TextBox();
            this.cb_start_run = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pb_popup_softkeyboard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_popup_softkeyboard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "将于每天的";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "幻灯图片文件路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "视频文件路径";
            // 
            // tb_slide_path
            // 
            this.tb_slide_path.Location = new System.Drawing.Point(79, 81);
            this.tb_slide_path.Name = "tb_slide_path";
            this.tb_slide_path.Size = new System.Drawing.Size(453, 21);
            this.tb_slide_path.TabIndex = 3;
            // 
            // tb_video_path
            // 
            this.tb_video_path.Location = new System.Drawing.Point(79, 162);
            this.tb_video_path.Name = "tb_video_path";
            this.tb_video_path.Size = new System.Drawing.Size(453, 21);
            this.tb_video_path.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "文件管理:";
            // 
            // btn_save_slide_path
            // 
            this.btn_save_slide_path.Location = new System.Drawing.Point(79, 109);
            this.btn_save_slide_path.Name = "btn_save_slide_path";
            this.btn_save_slide_path.Size = new System.Drawing.Size(75, 23);
            this.btn_save_slide_path.TabIndex = 6;
            this.btn_save_slide_path.Text = "更改目录";
            this.btn_save_slide_path.UseVisualStyleBackColor = true;
            this.btn_save_slide_path.Click += new System.EventHandler(this.btn_save_slide_path_Click);
            // 
            // btn_save_video_path
            // 
            this.btn_save_video_path.Location = new System.Drawing.Point(79, 189);
            this.btn_save_video_path.Name = "btn_save_video_path";
            this.btn_save_video_path.Size = new System.Drawing.Size(75, 23);
            this.btn_save_video_path.TabIndex = 7;
            this.btn_save_video_path.Text = "更改目录";
            this.btn_save_video_path.UseVisualStyleBackColor = true;
            this.btn_save_video_path.Click += new System.EventHandler(this.btn_save_video_path_Click);
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(141, 14);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(45, 21);
            this.numericUpDownHour.TabIndex = 8;
            this.numericUpDownHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownHour.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numericUpDownHour.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "时";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "分";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(212, 14);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(45, 21);
            this.numericUpDownMin.TabIndex = 10;
            this.numericUpDownMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMin.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownMin.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "关机";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "定时任务:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.link,
            this.del});
            this.dataGridView1.Location = new System.Drawing.Point(77, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(459, 181);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "按钮名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // link
            // 
            this.link.DataPropertyName = "link";
            this.link.HeaderText = "对应触发连接";
            this.link.Name = "link";
            this.link.ReadOnly = true;
            this.link.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.link.Width = 280;
            // 
            // del
            // 
            this.del.HeaderText = "操作";
            this.del.Name = "del";
            this.del.Text = "删除";
            this.del.UseColumnTextForButtonValue = true;
            this.del.Width = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "链接设置:";
            // 
            // btn_add_record
            // 
            this.btn_add_record.Location = new System.Drawing.Point(133, 479);
            this.btn_add_record.Name = "btn_add_record";
            this.btn_add_record.Size = new System.Drawing.Size(75, 23);
            this.btn_add_record.TabIndex = 16;
            this.btn_add_record.Text = "增加记录";
            this.btn_add_record.UseVisualStyleBackColor = true;
            this.btn_add_record.Click += new System.EventHandler(this.btn_add_new_link_Click);
            // 
            // btn_change_pwd
            // 
            this.btn_change_pwd.Location = new System.Drawing.Point(76, 535);
            this.btn_change_pwd.Name = "btn_change_pwd";
            this.btn_change_pwd.Size = new System.Drawing.Size(75, 23);
            this.btn_change_pwd.TabIndex = 17;
            this.btn_change_pwd.Text = "修改密码";
            this.btn_change_pwd.UseVisualStyleBackColor = true;
            this.btn_change_pwd.Click += new System.EventHandler(this.btn_change_pwd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 518);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "安全设置:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 517);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "为了您的程序安全, 请定期修改密码";
            // 
            // btn_save_record
            // 
            this.btn_save_record.Location = new System.Drawing.Point(214, 479);
            this.btn_save_record.Name = "btn_save_record";
            this.btn_save_record.Size = new System.Drawing.Size(75, 23);
            this.btn_save_record.TabIndex = 17;
            this.btn_save_record.Text = "保存记录";
            this.btn_save_record.UseVisualStyleBackColor = true;
            this.btn_save_record.Click += new System.EventHandler(this.btn_save_record_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 21;
            this.label12.Text = "按钮名字";
            // 
            // tb_btn_name
            // 
            this.tb_btn_name.Location = new System.Drawing.Point(133, 425);
            this.tb_btn_name.Name = "tb_btn_name";
            this.tb_btn_name.Size = new System.Drawing.Size(160, 21);
            this.tb_btn_name.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 457);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 23;
            this.label13.Text = "网络链接";
            // 
            // tb_link
            // 
            this.tb_link.Location = new System.Drawing.Point(133, 452);
            this.tb_link.Name = "tb_link";
            this.tb_link.Size = new System.Drawing.Size(402, 21);
            this.tb_link.TabIndex = 24;
            // 
            // cb_start_run
            // 
            this.cb_start_run.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_start_run.FormattingEnabled = true;
            this.cb_start_run.Items.AddRange(new object[] {
            "图片浏览",
            "视频浏览",
            "页面浏览"});
            this.cb_start_run.Location = new System.Drawing.Point(193, 40);
            this.cb_start_run.Name = "cb_start_run";
            this.cb_start_run.Size = new System.Drawing.Size(121, 20);
            this.cb_start_run.TabIndex = 25;
            this.cb_start_run.SelectedIndexChanged += new System.EventHandler(this.cb_start_run_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(77, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "程序启动时首先打开";
            // 
            // pb_popup_softkeyboard
            // 
            this.pb_popup_softkeyboard.Image = global::ExhibitionApp.Properties.Resources.keyboard_32px;
            this.pb_popup_softkeyboard.Location = new System.Drawing.Point(490, 12);
            this.pb_popup_softkeyboard.Name = "pb_popup_softkeyboard";
            this.pb_popup_softkeyboard.Size = new System.Drawing.Size(42, 31);
            this.pb_popup_softkeyboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_popup_softkeyboard.TabIndex = 27;
            this.pb_popup_softkeyboard.TabStop = false;
            this.pb_popup_softkeyboard.Click += new System.EventHandler(this.Softkeyboard_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 568);
            this.Controls.Add(this.pb_popup_softkeyboard);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cb_start_run);
            this.Controls.Add(this.btn_save_record);
            this.Controls.Add(this.btn_add_record);
            this.Controls.Add(this.tb_link);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_btn_name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_change_pwd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownHour);
            this.Controls.Add(this.btn_save_video_path);
            this.Controls.Add(this.btn_save_slide_path);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_video_path);
            this.Controls.Add(this.tb_slide_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_popup_softkeyboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_slide_path;
        private System.Windows.Forms.TextBox tb_video_path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save_slide_path;
        private System.Windows.Forms.Button btn_save_video_path;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_add_record;
        private System.Windows.Forms.Button btn_change_pwd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_save_record;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_btn_name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_link;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn link;
        private System.Windows.Forms.DataGridViewButtonColumn del;
        private System.Windows.Forms.ComboBox cb_start_run;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pb_popup_softkeyboard;
    }
}