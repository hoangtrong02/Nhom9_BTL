
namespace BigProject.GUI
{
    partial class FormSinhvien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreport = new Guna.UI2.WinForms.Guna2Button();
            this.btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox_timkiemMalop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_sinhvien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensinhvienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quequanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSinhVienDataSet1 = new BigProject.QLSinhVienDataSet();
            this.sinhvienTableAdapter1 = new BigProject.QLSinhVienDataSetTableAdapters.SinhvienTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.comboBox_malop = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_gioitinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnsua = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox_sinhvien = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnchonanh = new Guna.UI2.WinForms.Guna2Button();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsodienthoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtquequan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txthoten = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmasinhvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnreport);
            this.panel1.Controls.Add(this.btnrefresh);
            this.panel1.Controls.Add(this.comboBox_timkiemMalop);
            this.panel1.Controls.Add(this.txttimkiem);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnreport
            // 
            this.btnreport.BorderRadius = 5;
            this.btnreport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreport.FillColor = System.Drawing.Color.LimeGreen;
            this.btnreport.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnreport.ForeColor = System.Drawing.Color.White;
            this.btnreport.Location = new System.Drawing.Point(845, 3);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(101, 35);
            this.btnreport.TabIndex = 36;
            this.btnreport.Text = "In danh sách";
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
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
            this.btnrefresh.Location = new System.Drawing.Point(310, 4);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(101, 35);
            this.btnrefresh.TabIndex = 35;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // comboBox_timkiemMalop
            // 
            this.comboBox_timkiemMalop.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_timkiemMalop.BorderRadius = 7;
            this.comboBox_timkiemMalop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_timkiemMalop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_timkiemMalop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_timkiemMalop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_timkiemMalop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_timkiemMalop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_timkiemMalop.ItemHeight = 30;
            this.comboBox_timkiemMalop.Location = new System.Drawing.Point(685, 4);
            this.comboBox_timkiemMalop.Name = "comboBox_timkiemMalop";
            this.comboBox_timkiemMalop.Size = new System.Drawing.Size(154, 36);
            this.comboBox_timkiemMalop.TabIndex = 35;
            this.comboBox_timkiemMalop.SelectedIndexChanged += new System.EventHandler(this.comboBox_timkiemMalop_SelectedIndexChanged);
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
            this.txttimkiem.PlaceholderText = "Nhập họ tên hoặc mã sinh viên";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_sinhvien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 359);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView_sinhvien
            // 
            this.dataGridView_sinhvien.AllowUserToAddRows = false;
            this.dataGridView_sinhvien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_sinhvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_sinhvien.AutoGenerateColumns = false;
            this.dataGridView_sinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_sinhvien.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView_sinhvien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_sinhvien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_sinhvien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_sinhvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_sinhvien.ColumnHeadersHeight = 22;
            this.dataGridView_sinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malopDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.tensinhvienDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.gioitinhDataGridViewTextBoxColumn,
            this.quequanDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sodienthoaiDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView_sinhvien.DataSource = this.sinhvienBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_sinhvien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_sinhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_sinhvien.EnableHeadersVisualStyles = false;
            this.dataGridView_sinhvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_sinhvien.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_sinhvien.Name = "dataGridView_sinhvien";
            this.dataGridView_sinhvien.RowHeadersVisible = false;
            this.dataGridView_sinhvien.RowTemplate.Height = 40;
            this.dataGridView_sinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_sinhvien.Size = new System.Drawing.Size(962, 359);
            this.dataGridView_sinhvien.TabIndex = 0;
            this.dataGridView_sinhvien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_sinhvien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_sinhvien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_sinhvien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_sinhvien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_sinhvien.ThemeStyle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView_sinhvien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_sinhvien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_sinhvien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_sinhvien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_sinhvien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_sinhvien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_sinhvien.ThemeStyle.HeaderStyle.Height = 22;
            this.dataGridView_sinhvien.ThemeStyle.ReadOnly = false;
            this.dataGridView_sinhvien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_sinhvien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_sinhvien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_sinhvien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_sinhvien.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridView_sinhvien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_sinhvien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_sinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_sinhvien_CellClick);
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "Malop";
            this.malopDataGridViewTextBoxColumn.FillWeight = 90F;
            this.malopDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Masinhvien";
            this.dataGridViewTextBoxColumn2.FillWeight = 80F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sinh viên";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tensinhvienDataGridViewTextBoxColumn
            // 
            this.tensinhvienDataGridViewTextBoxColumn.DataPropertyName = "Tensinhvien";
            this.tensinhvienDataGridViewTextBoxColumn.FillWeight = 90F;
            this.tensinhvienDataGridViewTextBoxColumn.HeaderText = "Họ và tên";
            this.tensinhvienDataGridViewTextBoxColumn.Name = "tensinhvienDataGridViewTextBoxColumn";
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "Ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.FillWeight = 70F;
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            // 
            // gioitinhDataGridViewTextBoxColumn
            // 
            this.gioitinhDataGridViewTextBoxColumn.DataPropertyName = "Gioitinh";
            this.gioitinhDataGridViewTextBoxColumn.FillWeight = 55F;
            this.gioitinhDataGridViewTextBoxColumn.HeaderText = "Giới tính";
            this.gioitinhDataGridViewTextBoxColumn.Name = "gioitinhDataGridViewTextBoxColumn";
            // 
            // quequanDataGridViewTextBoxColumn
            // 
            this.quequanDataGridViewTextBoxColumn.DataPropertyName = "Quequan";
            this.quequanDataGridViewTextBoxColumn.FillWeight = 90F;
            this.quequanDataGridViewTextBoxColumn.HeaderText = "Quê quán";
            this.quequanDataGridViewTextBoxColumn.Name = "quequanDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 50F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // sodienthoaiDataGridViewTextBoxColumn
            // 
            this.sodienthoaiDataGridViewTextBoxColumn.DataPropertyName = "Sodienthoai";
            this.sodienthoaiDataGridViewTextBoxColumn.FillWeight = 80F;
            this.sodienthoaiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sodienthoaiDataGridViewTextBoxColumn.Name = "sodienthoaiDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.FillWeight = 40F;
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataMember = "Sinhvien";
            this.sinhvienBindingSource.DataSource = this.qLSinhVienDataSet1;
            // 
            // qLSinhVienDataSet1
            // 
            this.qLSinhVienDataSet1.DataSetName = "QLSinhVienDataSet";
            this.qLSinhVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhvienTableAdapter1
            // 
            this.sinhvienTableAdapter1.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 200);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker_ngaysinh);
            this.panel4.Controls.Add(this.comboBox_malop);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.comboBox_gioitinh);
            this.panel4.Controls.Add(this.btnxoa);
            this.panel4.Controls.Add(this.btnsua);
            this.panel4.Controls.Add(this.btnthem);
            this.panel4.Controls.Add(this.pictureBox_sinhvien);
            this.panel4.Controls.Add(this.btnchonanh);
            this.panel4.Controls.Add(this.txtemail);
            this.panel4.Controls.Add(this.txtsodienthoai);
            this.panel4.Controls.Add(this.txtquequan);
            this.panel4.Controls.Add(this.txthoten);
            this.panel4.Controls.Add(this.txtmasinhvien);
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
            this.dateTimePicker_ngaysinh.Location = new System.Drawing.Point(340, 64);
            this.dateTimePicker_ngaysinh.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_ngaysinh.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_ngaysinh.Name = "dateTimePicker_ngaysinh";
            this.dateTimePicker_ngaysinh.Size = new System.Drawing.Size(80, 21);
            this.dateTimePicker_ngaysinh.TabIndex = 35;
            this.dateTimePicker_ngaysinh.Value = new System.DateTime(2022, 4, 7, 16, 18, 57, 0);
            // 
            // comboBox_malop
            // 
            this.comboBox_malop.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_malop.BorderRadius = 7;
            this.comboBox_malop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_malop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_malop.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_malop.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_malop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_malop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_malop.ItemHeight = 30;
            this.comboBox_malop.Location = new System.Drawing.Point(88, 11);
            this.comboBox_malop.Name = "comboBox_malop";
            this.comboBox_malop.Size = new System.Drawing.Size(182, 36);
            this.comboBox_malop.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(37, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Mã lớp:";
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
            this.comboBox_gioitinh.Location = new System.Drawing.Point(492, 56);
            this.comboBox_gioitinh.Name = "comboBox_gioitinh";
            this.comboBox_gioitinh.Size = new System.Drawing.Size(106, 36);
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
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
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
            // pictureBox_sinhvien
            // 
            this.pictureBox_sinhvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_sinhvien.BorderRadius = 10;
            this.pictureBox_sinhvien.FillColor = System.Drawing.Color.Silver;
            this.pictureBox_sinhvien.ImageRotate = 0F;
            this.pictureBox_sinhvien.Location = new System.Drawing.Point(654, 21);
            this.pictureBox_sinhvien.Name = "pictureBox_sinhvien";
            this.pictureBox_sinhvien.Size = new System.Drawing.Size(100, 115);
            this.pictureBox_sinhvien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_sinhvien.TabIndex = 27;
            this.pictureBox_sinhvien.TabStop = false;
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
            // txthoten
            // 
            this.txthoten.BorderRadius = 5;
            this.txthoten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthoten.DefaultText = "";
            this.txthoten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txthoten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txthoten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthoten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthoten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthoten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txthoten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthoten.Location = new System.Drawing.Point(88, 54);
            this.txthoten.Name = "txthoten";
            this.txthoten.PasswordChar = '\0';
            this.txthoten.PlaceholderText = "Nhập họ tên sinh viên";
            this.txthoten.SelectedText = "";
            this.txthoten.Size = new System.Drawing.Size(182, 38);
            this.txthoten.TabIndex = 21;
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
            this.txtmasinhvien.Location = new System.Drawing.Point(367, 11);
            this.txtmasinhvien.Name = "txtmasinhvien";
            this.txtmasinhvien.PasswordChar = '\0';
            this.txtmasinhvien.PlaceholderText = "Nhập mã sinh viên";
            this.txtmasinhvien.SelectedText = "";
            this.txtmasinhvien.Size = new System.Drawing.Size(231, 36);
            this.txtmasinhvien.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(426, 67);
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
            this.label6.Location = new System.Drawing.Point(275, 67);
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
            this.label1.Location = new System.Drawing.Point(286, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên:";
            // 
            // FormSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 602);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSinhvien";
            this.Text = "Thongtinsinhvien";
            this.Load += new System.EventHandler(this.Thongtinsinhvien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sinhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private QLSinhVienDataSet qLSinhVienDataSet;
        private QLSinhVienDataSetTableAdapters.SinhvienTableAdapter sinhvienTableAdapter;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_sinhvien;
        private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn masinhvienDataGridViewTextBoxColumn;
        private QLSinhVienDataSet qLSinhVienDataSet2;
        private QLSinhVienDataSetTableAdapters.SinhvienTableAdapter sinhvienTableAdapter2;
        private QLSinhVienDataSet qLSinhVienDataSet1;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private QLSinhVienDataSetTableAdapters.SinhvienTableAdapter sinhvienTableAdapter1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_timkiemMalop;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensinhvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quequanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_malop;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_gioitinh;
        private Guna.UI2.WinForms.Guna2Button btnxoa;
        private Guna.UI2.WinForms.Guna2Button btnsua;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_sinhvien;
        private Guna.UI2.WinForms.Guna2Button btnchonanh;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2TextBox txtsodienthoai;
        private Guna.UI2.WinForms.Guna2TextBox txtquequan;
        private Guna.UI2.WinForms.Guna2TextBox txthoten;
        private Guna.UI2.WinForms.Guna2TextBox txtmasinhvien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysinh;
        private Guna.UI2.WinForms.Guna2Button btnreport;
    }
}