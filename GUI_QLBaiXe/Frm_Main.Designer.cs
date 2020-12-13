namespace GUI_QLBaiXe
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTX = new System.Windows.Forms.Button();
            this.iconsList = new System.Windows.Forms.ImageList(this.components);
            this.btnLX = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXeVao = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 171);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.btnTX);
            this.tabPage1.Controls.Add(this.btnLX);
            this.tabPage1.Controls.Add(this.btnNV);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1043, 142);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý danh mục";
            // 
            // btnTX
            // 
            this.btnTX.ImageKey = "bank-card-back-side.png";
            this.btnTX.ImageList = this.iconsList;
            this.btnTX.Location = new System.Drawing.Point(274, 6);
            this.btnTX.Name = "btnTX";
            this.btnTX.Size = new System.Drawing.Size(128, 130);
            this.btnTX.TabIndex = 2;
            this.btnTX.Text = "Thẻ xe";
            this.btnTX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTX.UseVisualStyleBackColor = true;
            this.btnTX.Click += new System.EventHandler(this.btnTX_Click);
            // 
            // iconsList
            // 
            this.iconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsList.ImageStream")));
            this.iconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconsList.Images.SetKeyName(0, "bank-card-back-side.png");
            this.iconsList.Images.SetKeyName(1, "motorcycle-icon-trendy-design-sticker-1577491703.849943.png");
            this.iconsList.Images.SetKeyName(2, "person-male.png");
            this.iconsList.Images.SetKeyName(3, "search-131964753234672616.png");
            this.iconsList.Images.SetKeyName(4, "file-icons-free-download-png-and-svg-file-icon-png-256_256.png");
            // 
            // btnLX
            // 
            this.btnLX.ImageIndex = 1;
            this.btnLX.ImageList = this.iconsList;
            this.btnLX.Location = new System.Drawing.Point(140, 6);
            this.btnLX.Name = "btnLX";
            this.btnLX.Size = new System.Drawing.Size(128, 130);
            this.btnLX.TabIndex = 1;
            this.btnLX.Text = "Loại xe";
            this.btnLX.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLX.UseVisualStyleBackColor = true;
            this.btnLX.Click += new System.EventHandler(this.btnLX_Click);
            // 
            // btnNV
            // 
            this.btnNV.ImageIndex = 2;
            this.btnNV.ImageList = this.iconsList;
            this.btnNV.Location = new System.Drawing.Point(6, 6);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(128, 130);
            this.btnNV.TabIndex = 0;
            this.btnNV.Text = "Nhân viên";
            this.btnNV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNV.UseVisualStyleBackColor = true;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnXeVao);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1043, 142);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý xe ra vào";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.iconsList;
            this.button1.Location = new System.Drawing.Point(140, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 130);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quản Lý Xe Ra";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXeVao
            // 
            this.btnXeVao.ImageIndex = 1;
            this.btnXeVao.ImageList = this.iconsList;
            this.btnXeVao.Location = new System.Drawing.Point(6, 6);
            this.btnXeVao.Name = "btnXeVao";
            this.btnXeVao.Size = new System.Drawing.Size(128, 130);
            this.btnXeVao.TabIndex = 1;
            this.btnXeVao.Text = "Quản Lý Xe Vào";
            this.btnXeVao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXeVao.UseVisualStyleBackColor = true;
            this.btnXeVao.Click += new System.EventHandler(this.btnXeVao_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1043, 142);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tìm kiếm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.iconsList;
            this.button2.Location = new System.Drawing.Point(8, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 130);
            this.button2.TabIndex = 2;
            this.button2.Text = "Tìm kiếm thông tin";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1043, 142);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thống kê - Báo Cáo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageIndex = 4;
            this.button3.ImageList = this.iconsList;
            this.button3.Location = new System.Drawing.Point(8, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 130);
            this.button3.TabIndex = 4;
            this.button3.Text = "Thống kê doanh thu";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 272);
            this.panel1.TabIndex = 1;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm QL bãi đỗ xe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Main_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTX;
        private System.Windows.Forms.Button btnLX;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ImageList iconsList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXeVao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

