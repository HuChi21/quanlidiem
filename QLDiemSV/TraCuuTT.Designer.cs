
namespace QLDiemSV
{
    partial class TraCuuTT
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItemSV = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel34 = new System.Windows.Forms.Panel();
            this.cbTenMon = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.cbTenLop = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbMSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dsTraCuu = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel34.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTraCuu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItemSV});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đăngXuấtToolStripMenuItemSV
            // 
            this.đăngXuấtToolStripMenuItemSV.Name = "đăngXuấtToolStripMenuItemSV";
            this.đăngXuấtToolStripMenuItemSV.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItemSV.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItemSV.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItemSV_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.panel34);
            this.panel1.Controls.Add(this.panel24);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(20, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 95);
            this.panel1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(434, 61);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 24);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.cbTenMon);
            this.panel34.Controls.Add(this.label17);
            this.panel34.Location = new System.Drawing.Point(638, 2);
            this.panel34.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(293, 38);
            this.panel34.TabIndex = 3;
            // 
            // cbTenMon
            // 
            this.cbTenMon.FormattingEnabled = true;
            this.cbTenMon.Location = new System.Drawing.Point(102, 6);
            this.cbTenMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTenMon.Name = "cbTenMon";
            this.cbTenMon.Size = new System.Drawing.Size(168, 21);
            this.cbTenMon.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.No;
            this.label17.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(2, 9);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 14);
            this.label17.TabIndex = 1;
            this.label17.Text = "Tên môn";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.cbTenLop);
            this.panel24.Controls.Add(this.label12);
            this.panel24.Location = new System.Drawing.Point(320, 2);
            this.panel24.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(293, 38);
            this.panel24.TabIndex = 2;
            // 
            // cbTenLop
            // 
            this.cbTenLop.FormattingEnabled = true;
            this.cbTenLop.Location = new System.Drawing.Point(102, 6);
            this.cbTenLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTenLop.Name = "cbTenLop";
            this.cbTenLop.Size = new System.Drawing.Size(168, 21);
            this.cbTenLop.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.No;
            this.label12.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 14);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tên lớp";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbMSV);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 38);
            this.panel2.TabIndex = 1;
            // 
            // txbMSV
            // 
            this.txbMSV.Location = new System.Drawing.Point(105, 6);
            this.txbMSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbMSV.Name = "txbMSV";
            this.txbMSV.Size = new System.Drawing.Size(168, 20);
            this.txbMSV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dsTraCuu);
            this.panel3.Location = new System.Drawing.Point(22, 136);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 323);
            this.panel3.TabIndex = 3;
            // 
            // dsTraCuu
            // 
            this.dsTraCuu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsTraCuu.Location = new System.Drawing.Point(4, 2);
            this.dsTraCuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dsTraCuu.Name = "dsTraCuu";
            this.dsTraCuu.RowHeadersWidth = 51;
            this.dsTraCuu.RowTemplate.Height = 24;
            this.dsTraCuu.Size = new System.Drawing.Size(925, 318);
            this.dsTraCuu.TabIndex = 0;
            // 
            // TraCuuTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 465);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TraCuuTT";
            this.Text = "TraCuuTT";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel34.ResumeLayout(false);
            this.panel34.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsTraCuu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItemSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbMSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.ComboBox cbTenLop;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.ComboBox cbTenMon;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dsTraCuu;
    }
}