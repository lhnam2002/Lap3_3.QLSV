namespace lap3_3
{
    partial class frmQLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSV));
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripThem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTimKiem = new System.Windows.Forms.ToolStripLabel();
            this.toolStriptxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớitsm = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmtsm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemThoat = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMSSV,
            this.colTensv,
            this.colKhoa,
            this.colDTB});
            this.dgvStudent.Location = new System.Drawing.Point(-59, 101);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.Size = new System.Drawing.Size(918, 308);
            this.dgvStudent.TabIndex = 11;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 125;
            // 
            // colMSSV
            // 
            this.colMSSV.HeaderText = "Mã Số Sinh Viên";
            this.colMSSV.MinimumWidth = 6;
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.Width = 200;
            // 
            // colTensv
            // 
            this.colTensv.HeaderText = "Tên Sinh Viên";
            this.colTensv.MinimumWidth = 6;
            this.colTensv.Name = "colTensv";
            this.colTensv.Width = 200;
            // 
            // colKhoa
            // 
            this.colKhoa.HeaderText = "Khoa";
            this.colKhoa.MinimumWidth = 6;
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.Width = 200;
            // 
            // colDTB
            // 
            this.colDTB.HeaderText = "Điểm TB";
            this.colDTB.MinimumWidth = 6;
            this.colDTB.Name = "colDTB";
            this.colDTB.Width = 125;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAdd,
            this.toolStripThem,
            this.toolStripTimKiem,
            this.toolStriptxtSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(901, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "ChucNang";
            // 
            // toolStripBtnAdd
            // 
            this.toolStripBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAdd.Image")));
            this.toolStripBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAdd.Name = "toolStripBtnAdd";
            this.toolStripBtnAdd.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnAdd.Text = "Thêm Mới Sinh Viên";
            this.toolStripBtnAdd.Click += new System.EventHandler(this.toolStripBtnAdd_Click_1);
            // 
            // toolStripThem
            // 
            this.toolStripThem.Name = "toolStripThem";
            this.toolStripThem.Size = new System.Drawing.Size(76, 24);
            this.toolStripThem.Text = "Thêm Mới";
            // 
            // toolStripTimKiem
            // 
            this.toolStripTimKiem.Name = "toolStripTimKiem";
            this.toolStripTimKiem.Size = new System.Drawing.Size(131, 24);
            this.toolStripTimKiem.Text = "Tìm Kiếm theo tên";
            // 
            // toolStriptxtSearch
            // 
            this.toolStriptxtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStriptxtSearch.Name = "toolStriptxtSearch";
            this.toolStriptxtSearch.Size = new System.Drawing.Size(399, 27);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớitsm,
            this.tìmKiếmtsm,
            this.toolStripMenuItemThoat});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // thêmMớitsm
            // 
            this.thêmMớitsm.Name = "thêmMớitsm";
            this.thêmMớitsm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.thêmMớitsm.Size = new System.Drawing.Size(212, 26);
            this.thêmMớitsm.Text = "Thêm Mới";
            this.thêmMớitsm.Click += new System.EventHandler(this.thêmMớitsm_Click);
            // 
            // tìmKiếmtsm
            // 
            this.tìmKiếmtsm.Name = "tìmKiếmtsm";
            this.tìmKiếmtsm.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tìmKiếmtsm.Size = new System.Drawing.Size(212, 26);
            this.tìmKiếmtsm.Text = "Tìm Kiếm";
            this.tìmKiếmtsm.Click += new System.EventHandler(this.tìmKiếmtsm_Click);
            // 
            // toolStripMenuItemThoat
            // 
            this.toolStripMenuItemThoat.Name = "toolStripMenuItemThoat";
            this.toolStripMenuItemThoat.Size = new System.Drawing.Size(212, 26);
            this.toolStripMenuItemThoat.Text = "Thoát";
            this.toolStripMenuItemThoat.Click += new System.EventHandler(this.toolStripMenuItemThoat_Click);
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 479);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmQLSV";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmQLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDTB;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAdd;
        private System.Windows.Forms.ToolStripLabel toolStripThem;
        private System.Windows.Forms.ToolStripLabel toolStripTimKiem;
        private System.Windows.Forms.ToolStripTextBox toolStriptxtSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớitsm;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmtsm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemThoat;
    }
}

