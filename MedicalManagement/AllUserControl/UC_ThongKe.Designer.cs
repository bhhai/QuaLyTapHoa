
namespace MedicalManagement.AllUserControl
{
    partial class UC_ThongKe
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

        #region Component Designer generated code

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.hoaDonBanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.thongKeDataSet = new MedicalManagement.ThongKeDataSet();
            this.hoaDonBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonBanTableAdapter = new MedicalManagement.ThongKeDataSetTableAdapters.HoaDonBanTableAdapter();
            this.btnExcel = new Guna.UI2.WinForms.Guna2Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvThongKe = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcelNhap = new Guna.UI2.WinForms.Guna2Button();
            this.dgvHoaDonNhap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maHoaDonNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonNhapDataSet = new MedicalManagement.HoaDonNhapDataSet();
            this.dateTo2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFrom2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKeNhap = new Guna.UI2.WinForms.Guna2Button();
            this.hoaDonNhapTableAdapter = new MedicalManagement.HoaDonNhapDataSetTableAdapters.HoaDonNhapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBanBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(453, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(330, 40);
            this.label11.TabIndex = 62;
            this.label11.Text = "THỐNG KÊ, BÁO CÁO";
            // 
            // hoaDonBanBindingSource1
            // 
            this.hoaDonBanBindingSource1.DataMember = "HoaDonBan";
            this.hoaDonBanBindingSource1.DataSource = this.thongKeDataSet;
            // 
            // thongKeDataSet
            // 
            this.thongKeDataSet.DataSetName = "ThongKeDataSet";
            this.thongKeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBanBindingSource
            // 
            this.hoaDonBanBindingSource.DataMember = "HoaDonBan";
            // 
            // hoaDonBanTableAdapter
            // 
            this.hoaDonBanTableAdapter.ClearBeforeFill = true;
            // 
            // btnExcel
            // 
            this.btnExcel.BorderColor = System.Drawing.Color.Transparent;
            this.btnExcel.BorderRadius = 20;
            this.btnExcel.BorderThickness = 1;
            this.btnExcel.CheckedState.Parent = this.btnExcel;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.CustomImages.Parent = this.btnExcel;
            this.btnExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcel.DisabledState.Parent = this.btnExcel;
            this.btnExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExcel.HoverState.FillColor = System.Drawing.Color.White;
            this.btnExcel.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExcel.HoverState.Parent = this.btnExcel;
            this.btnExcel.Location = new System.Drawing.Point(934, 594);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ShadowDecoration.Parent = this.btnExcel;
            this.btnExcel.Size = new System.Drawing.Size(155, 54);
            this.btnExcel.TabIndex = 67;
            this.btnExcel.Text = "Xuất Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(38, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1127, 711);
            this.tabControl1.TabIndex = 68;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvThongKe);
            this.tabPage1.Controls.Add(this.dateTo);
            this.tabPage1.Controls.Add(this.btnExcel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateFrom);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnThongKe);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1119, 678);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê hóa đơn bán";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AllowUserToAddRows = false;
            this.dgvThongKe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongKe.AutoGenerateColumns = false;
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongKe.ColumnHeadersHeight = 27;
            this.dgvThongKe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvThongKe.DataSource = this.hoaDonBanBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongKe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongKe.EnableHeadersVisualStyles = false;
            this.dgvThongKe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongKe.Location = new System.Drawing.Point(13, 163);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.ReadOnly = true;
            this.dgvThongKe.RowHeadersVisible = false;
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongKe.Size = new System.Drawing.Size(1085, 411);
            this.dgvThongKe.TabIndex = 68;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongKe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongKe.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongKe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThongKe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongKe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongKe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongKe.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvThongKe.ThemeStyle.ReadOnly = true;
            this.dgvThongKe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongKe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongKe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongKe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongKe.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThongKe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongKe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "maHoaDonBan";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã hóa đơn bán";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tenNV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhân viên bán";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "maKH";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã khách hàng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tongTien";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tổng hóa đơn";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ngayBan";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày bán";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dateTo
            // 
            this.dateTo.BackColor = System.Drawing.Color.Transparent;
            this.dateTo.CheckedState.Parent = this.dateTo;
            this.dateTo.FillColor = System.Drawing.Color.RoyalBlue;
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.dateTo.ForeColor = System.Drawing.Color.White;
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.HoverState.Parent = this.dateTo;
            this.dateTo.Location = new System.Drawing.Point(303, 102);
            this.dateTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTo.Name = "dateTo";
            this.dateTo.ShadowDecoration.Parent = this.dateTo;
            this.dateTo.Size = new System.Drawing.Size(242, 46);
            this.dateTo.TabIndex = 40;
            this.dateTo.Value = new System.DateTime(2021, 9, 10, 19, 53, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(299, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Đến ngày:";
            // 
            // dateFrom
            // 
            this.dateFrom.BackColor = System.Drawing.Color.Transparent;
            this.dateFrom.CheckedState.Parent = this.dateFrom;
            this.dateFrom.FillColor = System.Drawing.Color.RoyalBlue;
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.dateFrom.ForeColor = System.Drawing.Color.White;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.HoverState.Parent = this.dateFrom;
            this.dateFrom.Location = new System.Drawing.Point(13, 102);
            this.dateFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.ShadowDecoration.Parent = this.dateFrom;
            this.dateFrom.Size = new System.Drawing.Size(242, 46);
            this.dateFrom.TabIndex = 38;
            this.dateFrom.Value = new System.DateTime(2021, 9, 10, 19, 53, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(9, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "Từ ngày:";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThongKe.BorderRadius = 14;
            this.btnThongKe.BorderThickness = 1;
            this.btnThongKe.CheckedState.Parent = this.btnThongKe;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.CustomImages.Parent = this.btnThongKe;
            this.btnThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKe.DisabledState.Parent = this.btnThongKe;
            this.btnThongKe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThongKe.HoverState.FillColor = System.Drawing.Color.White;
            this.btnThongKe.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThongKe.HoverState.Parent = this.btnThongKe;
            this.btnThongKe.Location = new System.Drawing.Point(955, 102);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.ShadowDecoration.Parent = this.btnThongKe;
            this.btnThongKe.Size = new System.Drawing.Size(134, 45);
            this.btnThongKe.TabIndex = 37;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcelNhap);
            this.tabPage2.Controls.Add(this.dgvHoaDonNhap);
            this.tabPage2.Controls.Add(this.dateTo2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dateFrom2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnThongKeNhap);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1119, 678);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê hóa đơn nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcelNhap
            // 
            this.btnExcelNhap.BorderColor = System.Drawing.Color.Transparent;
            this.btnExcelNhap.BorderRadius = 20;
            this.btnExcelNhap.BorderThickness = 1;
            this.btnExcelNhap.CheckedState.Parent = this.btnExcelNhap;
            this.btnExcelNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelNhap.CustomImages.Parent = this.btnExcelNhap;
            this.btnExcelNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcelNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcelNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcelNhap.DisabledState.Parent = this.btnExcelNhap;
            this.btnExcelNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExcelNhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelNhap.ForeColor = System.Drawing.Color.White;
            this.btnExcelNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExcelNhap.HoverState.FillColor = System.Drawing.Color.White;
            this.btnExcelNhap.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnExcelNhap.HoverState.Parent = this.btnExcelNhap;
            this.btnExcelNhap.Location = new System.Drawing.Point(947, 591);
            this.btnExcelNhap.Name = "btnExcelNhap";
            this.btnExcelNhap.ShadowDecoration.Parent = this.btnExcelNhap;
            this.btnExcelNhap.Size = new System.Drawing.Size(155, 54);
            this.btnExcelNhap.TabIndex = 70;
            this.btnExcelNhap.Text = "Xuất Excel";
            this.btnExcelNhap.Click += new System.EventHandler(this.btnExcelNhap_Click);
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.AllowUserToAddRows = false;
            this.dgvHoaDonNhap.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvHoaDonNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHoaDonNhap.AutoGenerateColumns = false;
            this.dgvHoaDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDonNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDonNhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDonNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDonNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHoaDonNhap.ColumnHeadersHeight = 27;
            this.dgvHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonNhapDataGridViewTextBoxColumn,
            this.nguoiNhapDataGridViewTextBoxColumn,
            this.maNCCDataGridViewTextBoxColumn,
            this.ngayNhapDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6});
            this.dgvHoaDonNhap.DataSource = this.hoaDonNhapBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDonNhap.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvHoaDonNhap.EnableHeadersVisualStyles = false;
            this.dgvHoaDonNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(17, 151);
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.ReadOnly = true;
            this.dgvHoaDonNhap.RowHeadersVisible = false;
            this.dgvHoaDonNhap.RowHeadersWidth = 51;
            this.dgvHoaDonNhap.RowTemplate.Height = 24;
            this.dgvHoaDonNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(1085, 421);
            this.dgvHoaDonNhap.TabIndex = 69;
            this.dgvHoaDonNhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDonNhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHoaDonNhap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDonNhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHoaDonNhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHoaDonNhap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDonNhap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDonNhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvHoaDonNhap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDonNhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHoaDonNhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHoaDonNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvHoaDonNhap.ThemeStyle.HeaderStyle.Height = 27;
            this.dgvHoaDonNhap.ThemeStyle.ReadOnly = true;
            this.dgvHoaDonNhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvHoaDonNhap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDonNhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvHoaDonNhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvHoaDonNhap.ThemeStyle.RowsStyle.Height = 24;
            this.dgvHoaDonNhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvHoaDonNhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // maHoaDonNhapDataGridViewTextBoxColumn
            // 
            this.maHoaDonNhapDataGridViewTextBoxColumn.DataPropertyName = "maHoaDonNhap";
            this.maHoaDonNhapDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn nhập";
            this.maHoaDonNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHoaDonNhapDataGridViewTextBoxColumn.Name = "maHoaDonNhapDataGridViewTextBoxColumn";
            this.maHoaDonNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nguoiNhapDataGridViewTextBoxColumn
            // 
            this.nguoiNhapDataGridViewTextBoxColumn.DataPropertyName = "nguoiNhap";
            this.nguoiNhapDataGridViewTextBoxColumn.HeaderText = "Người nhập";
            this.nguoiNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nguoiNhapDataGridViewTextBoxColumn.Name = "nguoiNhapDataGridViewTextBoxColumn";
            this.nguoiNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maNCCDataGridViewTextBoxColumn
            // 
            this.maNCCDataGridViewTextBoxColumn.DataPropertyName = "maNCC";
            this.maNCCDataGridViewTextBoxColumn.HeaderText = "Mã nhà cung cấp";
            this.maNCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNCCDataGridViewTextBoxColumn.Name = "maNCCDataGridViewTextBoxColumn";
            this.maNCCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "ngayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.ngayNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            this.ngayNhapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "tongTien";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // hoaDonNhapBindingSource
            // 
            this.hoaDonNhapBindingSource.DataMember = "HoaDonNhap";
            this.hoaDonNhapBindingSource.DataSource = this.hoaDonNhapDataSet;
            // 
            // hoaDonNhapDataSet
            // 
            this.hoaDonNhapDataSet.DataSetName = "HoaDonNhapDataSet";
            this.hoaDonNhapDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTo2
            // 
            this.dateTo2.BackColor = System.Drawing.Color.Transparent;
            this.dateTo2.CheckedState.Parent = this.dateTo2;
            this.dateTo2.FillColor = System.Drawing.Color.RoyalBlue;
            this.dateTo2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.dateTo2.ForeColor = System.Drawing.Color.White;
            this.dateTo2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo2.HoverState.Parent = this.dateTo2;
            this.dateTo2.Location = new System.Drawing.Point(323, 90);
            this.dateTo2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTo2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTo2.Name = "dateTo2";
            this.dateTo2.ShadowDecoration.Parent = this.dateTo2;
            this.dateTo2.Size = new System.Drawing.Size(242, 46);
            this.dateTo2.TabIndex = 45;
            this.dateTo2.Value = new System.DateTime(2021, 9, 10, 19, 53, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(319, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Đến ngày:";
            // 
            // dateFrom2
            // 
            this.dateFrom2.BackColor = System.Drawing.Color.Transparent;
            this.dateFrom2.CheckedState.Parent = this.dateFrom2;
            this.dateFrom2.FillColor = System.Drawing.Color.RoyalBlue;
            this.dateFrom2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.dateFrom2.ForeColor = System.Drawing.Color.White;
            this.dateFrom2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom2.HoverState.Parent = this.dateFrom2;
            this.dateFrom2.Location = new System.Drawing.Point(19, 90);
            this.dateFrom2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateFrom2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateFrom2.Name = "dateFrom2";
            this.dateFrom2.ShadowDecoration.Parent = this.dateFrom2;
            this.dateFrom2.Size = new System.Drawing.Size(242, 46);
            this.dateFrom2.TabIndex = 43;
            this.dateFrom2.Value = new System.DateTime(2021, 9, 10, 19, 53, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Từ ngày:";
            // 
            // btnThongKeNhap
            // 
            this.btnThongKeNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThongKeNhap.BorderRadius = 14;
            this.btnThongKeNhap.BorderThickness = 1;
            this.btnThongKeNhap.CheckedState.Parent = this.btnThongKeNhap;
            this.btnThongKeNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKeNhap.CustomImages.Parent = this.btnThongKeNhap;
            this.btnThongKeNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKeNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKeNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKeNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKeNhap.DisabledState.Parent = this.btnThongKeNhap;
            this.btnThongKeNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThongKeNhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeNhap.ForeColor = System.Drawing.Color.White;
            this.btnThongKeNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThongKeNhap.HoverState.FillColor = System.Drawing.Color.White;
            this.btnThongKeNhap.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThongKeNhap.HoverState.Parent = this.btnThongKeNhap;
            this.btnThongKeNhap.Location = new System.Drawing.Point(947, 91);
            this.btnThongKeNhap.Name = "btnThongKeNhap";
            this.btnThongKeNhap.ShadowDecoration.Parent = this.btnThongKeNhap;
            this.btnThongKeNhap.Size = new System.Drawing.Size(134, 45);
            this.btnThongKeNhap.TabIndex = 42;
            this.btnThongKeNhap.Text = "Thống kê";
            this.btnThongKeNhap.Click += new System.EventHandler(this.btnThongKeNhap_Click);
            // 
            // hoaDonNhapTableAdapter
            // 
            this.hoaDonNhapTableAdapter.ClearBeforeFill = true;
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label11);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1360, 908);
            this.Load += new System.EventHandler(this.UC_ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBanBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonNhapDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hoaDonBanBindingSource;
        private System.Windows.Forms.BindingSource hoaDonBanBindingSource1;
        private ThongKeDataSet thongKeDataSet;
        private ThongKeDataSetTableAdapters.HoaDonBanTableAdapter hoaDonBanTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnExcel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateFrom;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTo2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateFrom2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnThongKeNhap;
        private Guna.UI2.WinForms.Guna2Button btnExcelNhap;
        private Guna.UI2.WinForms.Guna2DataGridView dgvHoaDonNhap;
        private System.Windows.Forms.BindingSource hoaDonNhapBindingSource;
        private HoaDonNhapDataSet hoaDonNhapDataSet;
        private HoaDonNhapDataSetTableAdapters.HoaDonNhapTableAdapter hoaDonNhapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguoiNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
