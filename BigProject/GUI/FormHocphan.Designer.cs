
namespace BigProject.GUI
{
    partial class FormHocphan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_sotinchi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnsua = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.txttenhocphan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmahocphan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_hocphan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mahocphanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhocphanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotinchiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSinhVienDataSet = new BigProject.QLSinhVienDataSet();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hocphan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox_sotinchi);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnsua);
            this.panel3.Controls.Add(this.btnthem);
            this.panel3.Controls.Add(this.txttenhocphan);
            this.panel3.Controls.Add(this.txtmahocphan);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 422);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 180);
            this.panel3.TabIndex = 7;
            // 
            // comboBox_sotinchi
            // 
            this.comboBox_sotinchi.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_sotinchi.BorderRadius = 5;
            this.comboBox_sotinchi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_sotinchi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sotinchi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_sotinchi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_sotinchi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_sotinchi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_sotinchi.ItemHeight = 30;
            this.comboBox_sotinchi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_sotinchi.Location = new System.Drawing.Point(332, 115);
            this.comboBox_sotinchi.Name = "comboBox_sotinchi";
            this.comboBox_sotinchi.Size = new System.Drawing.Size(200, 36);
            this.comboBox_sotinchi.StartIndex = 0;
            this.comboBox_sotinchi.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(251, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Mã học phần:";
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
            this.btnsua.Location = new System.Drawing.Point(617, 94);
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
            this.btnthem.Location = new System.Drawing.Point(617, 41);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 35);
            this.btnthem.TabIndex = 28;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttenhocphan
            // 
            this.txttenhocphan.BorderRadius = 5;
            this.txttenhocphan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenhocphan.DefaultText = "";
            this.txttenhocphan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttenhocphan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttenhocphan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenhocphan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenhocphan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenhocphan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttenhocphan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenhocphan.Location = new System.Drawing.Point(332, 66);
            this.txttenhocphan.Name = "txttenhocphan";
            this.txttenhocphan.PasswordChar = '\0';
            this.txttenhocphan.PlaceholderText = "Nhập tên học phần";
            this.txttenhocphan.SelectedText = "";
            this.txttenhocphan.Size = new System.Drawing.Size(200, 40);
            this.txttenhocphan.TabIndex = 21;
            // 
            // txtmahocphan
            // 
            this.txtmahocphan.BorderRadius = 5;
            this.txtmahocphan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmahocphan.DefaultText = "";
            this.txtmahocphan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmahocphan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmahocphan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmahocphan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmahocphan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmahocphan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmahocphan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmahocphan.Location = new System.Drawing.Point(332, 20);
            this.txtmahocphan.Name = "txtmahocphan";
            this.txtmahocphan.PasswordChar = '\0';
            this.txtmahocphan.PlaceholderText = "Nhập mã học phần";
            this.txtmahocphan.SelectedText = "";
            this.txtmahocphan.Size = new System.Drawing.Size(200, 40);
            this.txtmahocphan.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(267, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số tín chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(248, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên học phần:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_hocphan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 602);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView_hocphan
            // 
            this.dataGridView_hocphan.AllowUserToAddRows = false;
            this.dataGridView_hocphan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView_hocphan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_hocphan.AutoGenerateColumns = false;
            this.dataGridView_hocphan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_hocphan.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView_hocphan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_hocphan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_hocphan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_hocphan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_hocphan.ColumnHeadersHeight = 22;
            this.dataGridView_hocphan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahocphanDataGridViewTextBoxColumn,
            this.tenhocphanDataGridViewTextBoxColumn,
            this.sotinchiDataGridViewTextBoxColumn});
            this.dataGridView_hocphan.DataSource = this.monhocBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_hocphan.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_hocphan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_hocphan.EnableHeadersVisualStyles = false;
            this.dataGridView_hocphan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_hocphan.Location = new System.Drawing.Point(0, 12);
            this.dataGridView_hocphan.Name = "dataGridView_hocphan";
            this.dataGridView_hocphan.RowHeadersVisible = false;
            this.dataGridView_hocphan.RowTemplate.Height = 40;
            this.dataGridView_hocphan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_hocphan.Size = new System.Drawing.Size(962, 590);
            this.dataGridView_hocphan.TabIndex = 0;
            this.dataGridView_hocphan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_hocphan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_hocphan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_hocphan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_hocphan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_hocphan.ThemeStyle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView_hocphan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_hocphan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_hocphan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_hocphan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_hocphan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_hocphan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_hocphan.ThemeStyle.HeaderStyle.Height = 22;
            this.dataGridView_hocphan.ThemeStyle.ReadOnly = false;
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.Height = 40;
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_hocphan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_hocphan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_hocphan_CellClick);
            // 
            // mahocphanDataGridViewTextBoxColumn
            // 
            this.mahocphanDataGridViewTextBoxColumn.DataPropertyName = "Mahocphan";
            this.mahocphanDataGridViewTextBoxColumn.HeaderText = "Mã học phần";
            this.mahocphanDataGridViewTextBoxColumn.Name = "mahocphanDataGridViewTextBoxColumn";
            // 
            // tenhocphanDataGridViewTextBoxColumn
            // 
            this.tenhocphanDataGridViewTextBoxColumn.DataPropertyName = "Tenhocphan";
            this.tenhocphanDataGridViewTextBoxColumn.HeaderText = "Tên học phần";
            this.tenhocphanDataGridViewTextBoxColumn.Name = "tenhocphanDataGridViewTextBoxColumn";
            // 
            // sotinchiDataGridViewTextBoxColumn
            // 
            this.sotinchiDataGridViewTextBoxColumn.DataPropertyName = "Sotinchi";
            this.sotinchiDataGridViewTextBoxColumn.HeaderText = "Số tín chỉ";
            this.sotinchiDataGridViewTextBoxColumn.Name = "sotinchiDataGridViewTextBoxColumn";
            // 
            // monhocBindingSource
            // 
            this.monhocBindingSource.DataMember = "Monhoc";
            this.monhocBindingSource.DataSource = this.qLSinhVienDataSet;
            // 
            // qLSinhVienDataSet
            // 
            this.qLSinhVienDataSet.DataSetName = "QLSinhVienDataSet";
            this.qLSinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormHocphan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 602);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormHocphan";
            this.Text = "FormMonhoc";
            this.Load += new System.EventHandler(this.FormHocphan_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_hocphan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSinhVienDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnsua;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private Guna.UI2.WinForms.Guna2TextBox txttenhocphan;
        private Guna.UI2.WinForms.Guna2TextBox txtmahocphan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_hocphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahocphanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhocphanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotinchiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource monhocBindingSource;
        private QLSinhVienDataSet qLSinhVienDataSet;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_sotinchi;
    }
}