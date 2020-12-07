namespace GUI_QLBaiXe
{
    partial class frm_XeRa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_XeRa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxCam = new System.Windows.Forms.PictureBox();
            this.txtGioVao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChoXeRa = new System.Windows.Forms.Button();
            this.iconsList = new System.Windows.Forms.ImageList(this.components);
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoaiXe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCam)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picboxCam);
            this.panel1.Controls.Add(this.txtGioVao);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnChoXeRa);
            this.panel1.Controls.Add(this.txtBienSo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGiaTien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLoaiXe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSoThe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbCamera);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1451, 294);
            this.panel1.TabIndex = 8;
            // 
            // picboxCam
            // 
            this.picboxCam.Location = new System.Drawing.Point(83, 42);
            this.picboxCam.Name = "picboxCam";
            this.picboxCam.Size = new System.Drawing.Size(477, 246);
            this.picboxCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxCam.TabIndex = 0;
            this.picboxCam.TabStop = false;
            // 
            // txtGioVao
            // 
            this.txtGioVao.CustomFormat = "dd/MM/yyyy HH:mm";
            this.txtGioVao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtGioVao.Location = new System.Drawing.Point(1215, 132);
            this.txtGioVao.Name = "txtGioVao";
            this.txtGioVao.Size = new System.Drawing.Size(368, 22);
            this.txtGioVao.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1125, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Giờ vào";
            // 
            // btnChoXeRa
            // 
            this.btnChoXeRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoXeRa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChoXeRa.ImageIndex = 2;
            this.btnChoXeRa.ImageList = this.iconsList;
            this.btnChoXeRa.Location = new System.Drawing.Point(782, 99);
            this.btnChoXeRa.Name = "btnChoXeRa";
            this.btnChoXeRa.Size = new System.Drawing.Size(168, 63);
            this.btnChoXeRa.TabIndex = 25;
            this.btnChoXeRa.Text = "Cho xe ra";
            this.btnChoXeRa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChoXeRa.UseVisualStyleBackColor = true;
            this.btnChoXeRa.Click += new System.EventHandler(this.btnChoXeRa_Click);
            // 
            // iconsList
            // 
            this.iconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsList.ImageStream")));
            this.iconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconsList.Images.SetKeyName(0, "46271.png");
            this.iconsList.Images.SetKeyName(1, "1375593-200.png");
            this.iconsList.Images.SetKeyName(2, "108282279_899258063911620_5053503532840909895_n.png");
            this.iconsList.Images.SetKeyName(3, "bank-card-back-side.png");
            this.iconsList.Images.SetKeyName(4, "cross+exit+remove+icon-1320161389317562876.png");
            this.iconsList.Images.SetKeyName(5, "file-icons-free-download-png-and-svg-file-icon-png-256_256.png");
            this.iconsList.Images.SetKeyName(6, "icon-customer-0.jpg");
            this.iconsList.Images.SetKeyName(7, "icons_next-512 - Copy.png");
            this.iconsList.Images.SetKeyName(8, "img_90938.png");
            this.iconsList.Images.SetKeyName(9, "img_297675.png");
            this.iconsList.Images.SetKeyName(10, "motorcycle-icon-trendy-design-sticker-1577491703.849943.png");
            this.iconsList.Images.SetKeyName(11, "next.png");
            this.iconsList.Images.SetKeyName(12, "Paomedia-Small-N-Flat-Floppy.ico");
            this.iconsList.Images.SetKeyName(13, "person-male.png");
            this.iconsList.Images.SetKeyName(14, "plus-icon-green-clip-art-clkerm-vector-clip-art-0.png");
            this.iconsList.Images.SetKeyName(15, "pre (2).png");
            this.iconsList.Images.SetKeyName(16, "pre.png");
            this.iconsList.Images.SetKeyName(17, "search-131964753234672616.png");
            this.iconsList.Images.SetKeyName(18, "signin1.png");
            this.iconsList.Images.SetKeyName(19, "unnamed.png");
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(1216, 95);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(367, 22);
            this.txtBienSo.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1108, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Biển số xe";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(1438, 56);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(145, 22);
            this.txtGiaTien.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1385, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Giá";
            // 
            // txtLoaiXe
            // 
            this.txtLoaiXe.Location = new System.Drawing.Point(1215, 56);
            this.txtLoaiXe.Name = "txtLoaiXe";
            this.txtLoaiXe.Size = new System.Drawing.Size(159, 22);
            this.txtLoaiXe.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1135, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Loại xe";
            // 
            // txtSoThe
            // 
            this.txtSoThe.Location = new System.Drawing.Point(782, 60);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(316, 22);
            this.txtSoThe.TabIndex = 18;
            this.txtSoThe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoThe_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(704, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số thẻ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "CamXeRa";
            // 
            // cbCamera
            // 
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(191, 12);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(289, 24);
            this.cbCamera.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1451, 37);
            this.panel2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1091, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ảnh Đã Lưu";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(80, 16);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(87, 18);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Ảnh Xe Ra";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 331);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1451, 298);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(728, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(720, 292);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frm_XeRa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 629);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_XeRa";
            this.Text = "frm_XeRa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_XeRa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_XeRa_FormClosed);
            this.Load += new System.EventHandler(this.frm_XeRa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCam)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList iconsList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picboxCam;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtGioVao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChoXeRa;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoaiXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}