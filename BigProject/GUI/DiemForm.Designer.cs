
namespace BigProject.GUI
{
    partial class DiemForm
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
            this.comboBox_tenhocphan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtdiemcuoiky = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiemgiuaky = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiemchuyencan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnsua = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.txtmasinhvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_diem = new Guna.UI2.WinForms.Guna2DataGridView();
            this.masinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocphanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemchuyencanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemgiuakyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemcuoikyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangdiem10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangdiem4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangdiemchuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSinhVienDataSet = new BigProject.QLSinhVienDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.diemTableAdapter = new BigProject.QLSinhVienDataSetTableAdapters.DiemTableAdapter();
            this.btnreport = new Guna.UI2.WinForms.Guna2Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_diem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox_tenhocphan);
            this.panel3.Controls.Add(this.txtdiemcuoiky);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtdiemgiuaky);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtdiemchuyencan);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnxoa);
            this.panel3.Controls.Add(this.btnsua);
            this.panel3.Controls.Add(this.btnthem);
            this.panel3.Controls.Add(this.txtmasinhvien);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 218);
            this.panel3.TabIndex = 5;
            // 
            // comboBox_tenhocphan
            // 
            this.comboBox_tenhocphan.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_tenhocphan.BorderRadius = 5;
            this.comboBox_tenhocphan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_tenhocphan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tenhocphan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_tenhocphan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_tenhocphan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_tenhocphan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_tenhocphan.ItemHeight = 30;
            this.comboBox_tenhocphan.Location = new System.Drawing.Point(421, 19);
            this.comboBox_tenhocphan.Name = "comboBox_tenhocphan";
            this.comboBox_tenhocphan.Size = new System.Drawing.Size(213, 36);
            this.comboBox_tenhocphan.TabIndex = 37;
            // 
            // txtdiemcuoiky
            // 
            this.txtdiemcuoiky.BorderRadius = 5;
            this.txtdiemcuoiky.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiemcuoiky.DefaultText = "";
            this.txtdiemcuoiky.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiemcuoiky.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiemcuoiky.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiemcuoiky.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiemcuoiky.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiemcuoiky.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdiemcuoiky.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiemcuoiky.Location = new System.Drawing.Point(362, 139);
            this.txtdiemcuoiky.Name = "txtdiemcuoiky";
            this.txtdiemcuoiky.PasswordChar = '\0';
            this.txtdiemcuoiky.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtdiemcuoiky.PlaceholderText = "Nhập điểm cuối kỳ";
            this.txtdiemcuoiky.SelectedText = "";
            this.txtdiemcuoiky.Size = new System.Drawing.Size(145, 35);
            this.txtdiemcuoiky.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(281, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Điểm cuối kỳ:";
            // 
            // txtdiemgiuaky
            // 
            this.txtdiemgiuaky.BorderRadius = 5;
            this.txtdiemgiuaky.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiemgiuaky.DefaultText = "";
            this.txtdiemgiuaky.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiemgiuaky.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiemgiuaky.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiemgiuaky.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiemgiuaky.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiemgiuaky.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdiemgiuaky.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiemgiuaky.Location = new System.Drawing.Point(362, 101);
            this.txtdiemgiuaky.Name = "txtdiemgiuaky";
            this.txtdiemgiuaky.PasswordChar = '\0';
            this.txtdiemgiuaky.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtdiemgiuaky.PlaceholderText = "Nhập điểm giữa kỳ";
            this.txtdiemgiuaky.SelectedText = "";
            this.txtdiemgiuaky.Size = new System.Drawing.Size(145, 35);
            this.txtdiemgiuaky.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(277, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Điểm giữa kỳ:";
            // 
            // txtdiemchuyencan
            // 
            this.txtdiemchuyencan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtdiemchuyencan.BorderRadius = 5;
            this.txtdiemchuyencan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiemchuyencan.DefaultText = "";
            this.txtdiemchuyencan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiemchuyencan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiemchuyencan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiemchuyencan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiemchuyencan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiemchuyencan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdiemchuyencan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiemchuyencan.Location = new System.Drawing.Point(362, 63);
            this.txtdiemchuyencan.Name = "txtdiemchuyencan";
            this.txtdiemchuyencan.PasswordChar = '\0';
            this.txtdiemchuyencan.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtdiemchuyencan.PlaceholderText = "Nhập điểm chuyên cần";
            this.txtdiemchuyencan.SelectedText = "";
            this.txtdiemchuyencan.Size = new System.Drawing.Size(145, 35);
            this.txtdiemchuyencan.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(258, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Điểm chuyên cần:";
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
            this.btnxoa.Location = new System.Drawing.Point(722, 130);
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
            this.btnsua.Location = new System.Drawing.Point(722, 79);
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
            this.btnthem.Location = new System.Drawing.Point(722, 26);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 35);
            this.btnthem.TabIndex = 28;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmasinhvien
            // 
            this.txtmasinhvien.BorderRadius = 5;
            this.txtmasinhvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmasinhvien.DefaultText = "";
            this.txtmasinhvien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmasinhvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmasinhvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmasinhvien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmasinhvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmasinhvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmasinhvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmasinhvien.Location = new System.Drawing.Point(176, 20);
            this.txtmasinhvien.Name = "txtmasinhvien";
            this.txtmasinhvien.PasswordChar = '\0';
            this.txtmasinhvien.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtmasinhvien.PlaceholderText = "Nhập mã sinh viên";
            this.txtmasinhvien.SelectedText = "";
            this.txtmasinhvien.Size = new System.Drawing.Size(145, 35);
            this.txtmasinhvien.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(336, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên học phần:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(94, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_diem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 567);
            this.panel2.TabIndex = 4;
            // 
            // dataGridView_diem
            // 
            this.dataGridView_diem.AllowUserToAddRows = false;
            this.dataGridView_diem.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_diem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_diem.AutoGenerateColumns = false;
            this.dataGridView_diem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_diem.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView_diem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_diem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_diem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_diem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_diem.ColumnHeadersHeight = 22;
            this.dataGridView_diem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masinhvienDataGridViewTextBoxColumn,
            this.tenhocphanDataGridViewTextBoxColumn,
            this.diemchuyencanDataGridViewTextBoxColumn,
            this.diemgiuakyDataGridViewTextBoxColumn,
            this.diemcuoikyDataGridViewTextBoxColumn,
            this.thangdiem10DataGridViewTextBoxColumn,
            this.thangdiem4DataGridViewTextBoxColumn,
            this.thangdiemchuDataGridViewTextBoxColumn});
            this.dataGridView_diem.DataSource = this.diemBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_diem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_diem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_diem.EnableHeadersVisualStyles = false;
            this.dataGridView_diem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_diem.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_diem.Name = "dataGridView_diem";
            this.dataGridView_diem.RowHeadersVisible = false;
            this.dataGridView_diem.RowTemplate.Height = 40;
            this.dataGridView_diem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_diem.Size = new System.Drawing.Size(962, 567);
            this.dataGridView_diem.TabIndex = 0;
            this.dataGridView_diem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_diem.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_diem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_diem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_diem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_diem.ThemeStyle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView_diem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_diem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_diem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_diem.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_diem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_diem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_diem.ThemeStyle.HeaderStyle.Height = 22;
            this.dataGridView_diem.ThemeStyle.ReadOnly = false;
            this.dataGridView_diem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_diem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_diem.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_diem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_diem.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridView_diem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_diem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_diem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_diem_CellClick);
            // 
            // masinhvienDataGridViewTextBoxColumn
            // 
            this.masinhvienDataGridViewTextBoxColumn.DataPropertyName = "Masinhvien";
            this.masinhvienDataGridViewTextBoxColumn.FillWeight = 60F;
            this.masinhvienDataGridViewTextBoxColumn.HeaderText = "Mã SV";
            this.masinhvienDataGridViewTextBoxColumn.Name = "masinhvienDataGridViewTextBoxColumn";
            // 
            // tenhocphanDataGridViewTextBoxColumn
            // 
            this.tenhocphanDataGridViewTextBoxColumn.DataPropertyName = "Tenhocphan";
            this.tenhocphanDataGridViewTextBoxColumn.FillWeight = 120F;
            this.tenhocphanDataGridViewTextBoxColumn.HeaderText = "Tên học phần";
            this.tenhocphanDataGridViewTextBoxColumn.Name = "tenhocphanDataGridViewTextBoxColumn";
            // 
            // diemchuyencanDataGridViewTextBoxColumn
            // 
            this.diemchuyencanDataGridViewTextBoxColumn.DataPropertyName = "Diemchuyencan";
            this.diemchuyencanDataGridViewTextBoxColumn.HeaderText = "Điểm chuyên cần";
            this.diemchuyencanDataGridViewTextBoxColumn.Name = "diemchuyencanDataGridViewTextBoxColumn";
            // 
            // diemgiuakyDataGridViewTextBoxColumn
            // 
            this.diemgiuakyDataGridViewTextBoxColumn.DataPropertyName = "Diemgiuaky";
            this.diemgiuakyDataGridViewTextBoxColumn.FillWeight = 80F;
            this.diemgiuakyDataGridViewTextBoxColumn.HeaderText = "Điểm giữa kỳ";
            this.diemgiuakyDataGridViewTextBoxColumn.Name = "diemgiuakyDataGridViewTextBoxColumn";
            // 
            // diemcuoikyDataGridViewTextBoxColumn
            // 
            this.diemcuoikyDataGridViewTextBoxColumn.DataPropertyName = "Diemcuoiky";
            this.diemcuoikyDataGridViewTextBoxColumn.FillWeight = 80F;
            this.diemcuoikyDataGridViewTextBoxColumn.HeaderText = "Điểm cuối kỳ";
            this.diemcuoikyDataGridViewTextBoxColumn.Name = "diemcuoikyDataGridViewTextBoxColumn";
            // 
            // thangdiem10DataGridViewTextBoxColumn
            // 
            this.thangdiem10DataGridViewTextBoxColumn.DataPropertyName = "Thangdiem10";
            this.thangdiem10DataGridViewTextBoxColumn.FillWeight = 55F;
            this.thangdiem10DataGridViewTextBoxColumn.HeaderText = "Thang 10";
            this.thangdiem10DataGridViewTextBoxColumn.Name = "thangdiem10DataGridViewTextBoxColumn";
            // 
            // thangdiem4DataGridViewTextBoxColumn
            // 
            this.thangdiem4DataGridViewTextBoxColumn.DataPropertyName = "Thangdiem4";
            this.thangdiem4DataGridViewTextBoxColumn.FillWeight = 50F;
            this.thangdiem4DataGridViewTextBoxColumn.HeaderText = "Thang 4";
            this.thangdiem4DataGridViewTextBoxColumn.Name = "thangdiem4DataGridViewTextBoxColumn";
            // 
            // thangdiemchuDataGridViewTextBoxColumn
            // 
            this.thangdiemchuDataGridViewTextBoxColumn.DataPropertyName = "Thangdiemchu";
            this.thangdiemchuDataGridViewTextBoxColumn.FillWeight = 60F;
            this.thangdiemchuDataGridViewTextBoxColumn.HeaderText = "Thang chữ";
            this.thangdiemchuDataGridViewTextBoxColumn.Name = "thangdiemchuDataGridViewTextBoxColumn";
            // 
            // diemBindingSource
            // 
            this.diemBindingSource.DataMember = "Diem";
            this.diemBindingSource.DataSource = this.qLSinhVienDataSet;
            // 
            // qLSinhVienDataSet
            // 
            this.qLSinhVienDataSet.DataSetName = "QLSinhVienDataSet";
            this.qLSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnreport);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 35);
            this.panel1.TabIndex = 3;
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
            this.txttimkiem.Location = new System.Drawing.Point(70, 5);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.PasswordChar = '\0';
            this.txttimkiem.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txttimkiem.PlaceholderText = "Nhập mã sinh viên";
            this.txttimkiem.SelectedText = "";
            this.txttimkiem.Size = new System.Drawing.Size(200, 26);
            this.txttimkiem.TabIndex = 22;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(6, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tìm kiếm:";
            // 
            // diemTableAdapter
            // 
            this.diemTableAdapter.ClearBeforeFill = true;
            // 
            // btnreport
            // 
            this.btnreport.BorderRadius = 5;
            this.btnreport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreport.FillColor = System.Drawing.Color.Olive;
            this.btnreport.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnreport.ForeColor = System.Drawing.Color.White;
            this.btnreport.Location = new System.Drawing.Point(378, 3);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(195, 30);
            this.btnreport.TabIndex = 38;
            this.btnreport.Text = "In bảng điểm theo mã sinh viên";
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // DiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 602);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DiemForm";
            this.Text = "DiemForm";
            this.Load += new System.EventHandler(this.DiemForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_diem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2TextBox txtdiemcuoiky;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtdiemgiuaky;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtdiemchuyencan;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnxoa;
        private Guna.UI2.WinForms.Guna2Button btnsua;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private Guna.UI2.WinForms.Guna2TextBox txtmasinhvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_diem;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_tenhocphan;
        private QLSinhVienDataSet qLSinhVienDataSet;
        private System.Windows.Forms.BindingSource diemBindingSource;
        private QLSinhVienDataSetTableAdapters.DiemTableAdapter diemTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocphanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemchuyencanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemgiuakyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemcuoikyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangdiem10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangdiem4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangdiemchuDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button btnreport;
    }
}