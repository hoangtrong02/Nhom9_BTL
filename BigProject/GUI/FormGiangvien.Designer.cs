
namespace BigProject.GUI
{
    partial class FormGiangvien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.comboBox_hocphan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_gioitinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnsua = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox_giangvien = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnchonanh = new Guna.UI2.WinForms.Guna2Button();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsodienthoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtquequan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txthotengv = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmagiangvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_giangvien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.qLSinhVienDataSet = new BigProject.QLSinhVienDataSet();
            this.giangvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.giangvienTableAdapter = new BigProject.QLSinhVienDataSetTableAdapters.GiangvienTableAdapter();
            this.tenhocphanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.magiangvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tengiangvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_giangvien)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_giangvien)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangvienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 200);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker_ngaysinh);
            this.panel4.Controls.Add(this.comboBox_hocphan);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.comboBox_gioitinh);
            this.panel4.Controls.Add(this.btnxoa);
            this.panel4.Controls.Add(this.btnsua);
            this.panel4.Controls.Add(this.btnthem);
            this.panel4.Controls.Add(this.pictureBox_giangvien);
            this.panel4.Controls.Add(this.btnchonanh);
            this.panel4.Controls.Add(this.txtemail);
            this.panel4.Controls.Add(this.txtsodienthoai);
            this.panel4.Controls.Add(this.txtquequan);
            this.panel4.Controls.Add(this.txthotengv);
            this.panel4.Controls.Add(this.txtmagiangvien);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(962, 200);
            this.panel4.TabIndex = 3;
            // 
            // dateTimePicker_ngaysinh
            // 
            this.dateTimePicker_ngaysinh.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker_ngaysinh.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dateTimePicker_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngaysinh.Location = new System.Drawing.Point(351, 64);
            this.dateTimePicker_ngaysinh.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_ngaysinh.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_ngaysinh.Name = "dateTimePicker_ngaysinh";
            this.dateTimePicker_ngaysinh.Size = new System.Drawing.Size(80, 21);
            this.dateTimePicker_ngaysinh.TabIndex = 35;
            this.dateTimePicker_ngaysinh.Value = new System.DateTime(2022, 4, 7, 16, 18, 57, 0);
            // 
            // comboBox_hocphan
            // 
            this.comboBox_hocphan.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_hocphan.BorderRadius = 7;
            this.comboBox_hocphan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_hocphan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hocphan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_hocphan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_hocphan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_hocphan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_hocphan.ItemHeight = 30;
            this.comboBox_hocphan.Location = new System.Drawing.Point(88, 11);
            this.comboBox_hocphan.Name = "comboBox_hocphan";
            this.comboBox_hocphan.Size = new System.Drawing.Size(223, 36);
            this.comboBox_hocphan.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(3, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Tên học phần:";
            // 
            // comboBox_gioitinh
            // 
            this.comboBox_gioitinh.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_gioitinh.BorderRadius = 7;
            this.comboBox_gioitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gioitinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_gioitinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_gioitinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_gioitinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_gioitinh.ItemHeight = 30;
            this.comboBox_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Unknow"});
            this.comboBox_gioitinh.Location = new System.Drawing.Point(503, 56);
            this.comboBox_gioitinh.Name = "comboBox_gioitinh";
            this.comboBox_gioitinh.Size = new System.Drawing.Size(95, 36);
            this.comboBox_gioitinh.StartIndex = 0;
            this.comboBox_gioitinh.TabIndex = 31;
            // 
            // btnxoa
            // 
            this.btnxoa.BorderRadius = 5;
            this.btnxoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(819, 131);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(101, 34);
            this.btnxoa.TabIndex = 30;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BorderRadius = 5;
            this.btnsua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsua.FillColor = System.Drawing.Color.Olive;
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsua.ForeColor = System.Drawing.Color.White;
            this.btnsua.Location = new System.Drawing.Point(819, 80);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(101, 33);
            this.btnsua.TabIndex = 29;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BorderRadius = 5;
            this.btnthem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(819, 27);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 35);
            this.btnthem.TabIndex = 28;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // pictureBox_giangvien
            // 
            this.pictureBox_giangvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_giangvien.BorderRadius = 10;
            this.pictureBox_giangvien.FillColor = System.Drawing.Color.Silver;
            this.pictureBox_giangvien.ImageRotate = 0F;
            this.pictureBox_giangvien.Location = new System.Drawing.Point(654, 21);
            this.pictureBox_giangvien.Name = "pictureBox_giangvien";
            this.pictureBox_giangvien.Size = new System.Drawing.Size(100, 115);
            this.pictureBox_giangvien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_giangvien.TabIndex = 27;
            this.pictureBox_giangvien.TabStop = false;
            // 
            // btnchonanh
            // 
            this.btnchonanh.BorderRadius = 10;
            this.btnchonanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnchonanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnchonanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnchonanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnchonanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnchonanh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchonanh.ForeColor = System.Drawing.Color.White;
            this.btnchonanh.Location = new System.Drawing.Point(654, 145);
            this.btnchonanh.Name = "btnchonanh";
            this.btnchonanh.Size = new System.Drawing.Size(101, 32);
            this.btnchonanh.TabIndex = 26;
            this.btnchonanh.Text = "Chọn ảnh";
            this.btnchonanh.Click += new System.EventHandler(this.btnchonanh_Click);
            // 
            // txtemail
            // 
            this.txtemail.BorderRadius = 10;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Location = new System.Drawing.Point(340, 153);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "Nhập địa chỉ email";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(258, 36);
            this.txtemail.TabIndex = 24;
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.BorderRadius = 10;
            this.txtsodienthoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsodienthoai.DefaultText = "";
            this.txtsodienthoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsodienthoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsodienthoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsodienthoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsodienthoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsodienthoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsodienthoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsodienthoai.Location = new System.Drawing.Point(88, 153);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.PasswordChar = '\0';
            this.txtsodienthoai.PlaceholderText = "Nhập số điện thoại";
            this.txtsodienthoai.SelectedText = "";
            this.txtsodienthoai.Size = new System.Drawing.Size(182, 36);
            this.txtsodienthoai.TabIndex = 23;
            // 
            // txtquequan
            // 
            this.txtquequan.BorderRadius = 10;
            this.txtquequan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtquequan.DefaultText = "";
            this.txtquequan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtquequan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtquequan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtquequan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtquequan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtquequan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtquequan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtquequan.Location = new System.Drawing.Point(88, 100);
            this.txtquequan.Name = "txtquequan";
            this.txtquequan.PasswordChar = '\0';
            this.txtquequan.PlaceholderText = "Nhập quê quán";
            this.txtquequan.SelectedText = "";
            this.txtquequan.Size = new System.Drawing.Size(510, 48);
            this.txtquequan.TabIndex = 22;
            // 
            // txthotengv
            // 
            this.txthotengv.BorderRadius = 5;
            this.txthotengv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthotengv.DefaultText = "";
            this.txthotengv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txthotengv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txthotengv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthotengv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthotengv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthotengv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txthotengv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthotengv.Location = new System.Drawing.Point(88, 54);
            this.txthotengv.Name = "txthotengv";
            this.txthotengv.PasswordChar = '\0';
            this.txthotengv.PlaceholderText = "Nhập họ tên giảng viên";
            this.txthotengv.SelectedText = "";
            this.txthotengv.Size = new System.Drawing.Size(182, 38);
            this.txthotengv.TabIndex = 21;
            // 
            // txtmagiangvien
            // 
            this.txtmagiangvien.BorderRadius = 5;
            this.txtmagiangvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmagiangvien.DefaultText = "";
            this.txtmagiangvien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmagiangvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmagiangvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmagiangvien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmagiangvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmagiangvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmagiangvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmagiangvien.Location = new System.Drawing.Point(405, 11);
            this.txtmagiangvien.Name = "txtmagiangvien";
            this.txtmagiangvien.PasswordChar = '\0';
            this.txtmagiangvien.PlaceholderText = "Nhập mã giảng viên";
            this.txtmagiangvien.SelectedText = "";
            this.txtmagiangvien.Size = new System.Drawing.Size(193, 36);
            this.txtmagiangvien.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(439, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(280, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(4, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(297, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quê quán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(317, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã giảng viên:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_giangvien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 359);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView_giangvien
            // 
            this.dataGridView_giangvien.AllowUserToAddRows = false;
            this.dataGridView_giangvien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_giangvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_giangvien.AutoGenerateColumns = false;
            this.dataGridView_giangvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_giangvien.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView_giangvien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_giangvien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_giangvien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_giangvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_giangvien.ColumnHeadersHeight = 22;
            this.dataGridView_giangvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenhocphanDataGridViewTextBoxColumn,
            this.magiangvienDataGridViewTextBoxColumn,
            this.tengiangvienDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.quequanDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sodienthoaiDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView_giangvien.DataSource = this.giangvienBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_giangvien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_giangvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_giangvien.EnableHeadersVisualStyles = false;
            this.dataGridView_giangvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_giangvien.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_giangvien.Name = "dataGridView_giangvien";
            this.dataGridView_giangvien.RowHeadersVisible = false;
            this.dataGridView_giangvien.RowTemplate.Height = 40;
            this.dataGridView_giangvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_giangvien.Size = new System.Drawing.Size(962, 359);
            this.dataGridView_giangvien.TabIndex = 0;
            this.dataGridView_giangvien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_giangvien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_giangvien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_giangvien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_giangvien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_giangvien.ThemeStyle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView_giangvien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_giangvien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_giangvien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_giangvien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_giangvien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_giangvien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_giangvien.ThemeStyle.HeaderStyle.Height = 22;
            this.dataGridView_giangvien.ThemeStyle.ReadOnly = false;
            this.dataGridView_giangvien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_giangvien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_giangvien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_giangvien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_giangvien.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridView_giangvien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_giangvien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_giangvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_giangvien_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnrefresh);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 43);
            this.panel1.TabIndex = 3;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BorderRadius = 5;
            this.btnrefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnrefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnrefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnrefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnrefresh.FillColor = System.Drawing.Color.LimeGreen;
            this.btnrefresh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnrefresh.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.Location = new System.Drawing.Point(442, 3);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(101, 35);
            this.btnrefresh.TabIndex = 35;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.BorderRadius = 10;
            this.txttimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttimkiem.DefaultText = "";
            this.txttimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkiem.Location = new System.Drawing.Point(70, 7);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.PasswordChar = '\0';
            this.txttimkiem.PlaceholderText = "Nhập họ tên hoặc mã giảng viên";
            this.txttimkiem.SelectedText = "";
            this.txttimkiem.Size = new System.Drawing.Size(200, 29);
            this.txttimkiem.TabIndex = 22;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(4, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tìm kiếm:";
            // 
            // qLSinhVienDataSet
            // 
            this.qLSinhVienDataSet.DataSetName = "QLSinhVienDataSet";
            this.qLSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giangvienBindingSource
            // 
            this.giangvienBindingSource.DataMember = "Giangvien";
            this.giangvienBindingSource.DataSource = this.qLSinhVienDataSet;
            // 
            // giangvienTableAdapter
            // 
            this.giangvienTableAdapter.ClearBeforeFill = true;
            // 
            // tenhocphanDataGridViewTextBoxColumn
            // 
            this.tenhocphanDataGridViewTextBoxColumn.DataPropertyName = "Tenhocphan";
            this.tenhocphanDataGridViewTextBoxColumn.FillWeight = 130F;
            this.tenhocphanDataGridViewTextBoxColumn.HeaderText = "Tên học phần";
            this.tenhocphanDataGridViewTextBoxColumn.Name = "tenhocphanDataGridViewTextBoxColumn";
            // 
            // magiangvienDataGridViewTextBoxColumn
            // 
            this.magiangvienDataGridViewTextBoxColumn.DataPropertyName = "Magiangvien";
            this.magiangvienDataGridViewTextBoxColumn.FillWeight = 75F;
            this.magiangvienDataGridViewTextBoxColumn.HeaderText = "Mã giảng viên";
            this.magiangvienDataGridViewTextBoxColumn.Name = "magiangvienDataGridViewTextBoxColumn";
            // 
            // tengiangvienDataGridViewTextBoxColumn
            // 
            this.tengiangvienDataGridViewTextBoxColumn.DataPropertyName = "Tengiangvien";
            this.tengiangvienDataGridViewTextBoxColumn.FillWeight = 90F;
            this.tengiangvienDataGridViewTextBoxColumn.HeaderText = "Tên giảng viên";
            this.tengiangvienDataGridViewTextBoxColumn.Name = "tengiangvienDataGridViewTextBoxColumn";
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "Ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.FillWeight = 55F;
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            // 
            // gioitinhDataGridViewTextBoxColumn
            // 
            this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "Gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.FillWeight = 50F;
            this.gioitinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
            // 
            // quequanDataGridViewTextBoxColumn
            // 
            this.quequanDataGridViewTextBoxColumn.DataPropertyName = "Quequan";
            this.quequanDataGridViewTextBoxColumn.HeaderText = "Quê quán";
            this.quequanDataGridViewTextBoxColumn.Name = "quequanDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 80F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // sodienthoaiDataGridViewTextBoxColumn
            // 
            this.sodienthoaiDataGridViewTextBoxColumn.DataPropertyName = "Sodienthoai";
            this.sodienthoaiDataGridViewTextBoxColumn.FillWeight = 70F;
            this.sodienthoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sodienthoaiDataGridViewTextBoxColumn.Name = "sodienthoaiDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.FillWeight = 50F;
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // FormGiangvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 602);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormGiangvien";
            this.Text = "FormGiangvien";
            this.Load += new System.EventHandler(this.FormGiangvien_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_giangvien)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_giangvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangvienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysinh;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_hocphan;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_gioitinh;
        private Guna.UI2.WinForms.Guna2Button btnxoa;
        private Guna.UI2.WinForms.Guna2Button btnsua;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_giangvien;
        private Guna.UI2.WinForms.Guna2Button btnchonanh;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2TextBox txtsodienthoai;
        private Guna.UI2.WinForms.Guna2TextBox txtquequan;
        private Guna.UI2.WinForms.Guna2TextBox txthotengv;
        private Guna.UI2.WinForms.Guna2TextBox txtmagiangvien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_giangvien;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
        private System.Windows.Forms.Label label8;
        private QLSinhVienDataSet qLSinhVienDataSet;
        private System.Windows.Forms.BindingSource giangvienBindingSource;
        private QLSinhVienDataSetTableAdapters.GiangvienTableAdapter giangvienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocphanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiangvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tengiangvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
    }
}