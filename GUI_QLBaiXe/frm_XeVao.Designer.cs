namespace GUI_QLBaiXe
{
    partial class frm_XeVao
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
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbCamera = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBoxCam = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCam)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Items.AddRange(new object[] {
            "Xe máy"});
            this.cbLoaiXe.Location = new System.Drawing.Point(478, 33);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(219, 24);
            this.cbLoaiXe.TabIndex = 0;
            this.cbLoaiXe.Text = "Xe máy";
            this.cbLoaiXe.SelectedIndexChanged += new System.EventHandler(this.cbLoaiXe_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbCamera);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnTiepNhan);
            this.panel1.Controls.Add(this.txtBienSo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSoThe);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbLoaiXe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 162);
            this.panel1.TabIndex = 1;
            // 
            // cbbCamera
            // 
            this.cbbCamera.FormattingEnabled = true;
            this.cbbCamera.Location = new System.Drawing.Point(478, 119);
            this.cbbCamera.Name = "cbbCamera";
            this.cbbCamera.Size = new System.Drawing.Size(568, 24);
            this.cbbCamera.TabIndex = 11;
            this.cbbCamera.SelectedIndexChanged += new System.EventHandler(this.cbbCamera_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chọn Camera";
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepNhan.Location = new System.Drawing.Point(1088, 33);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(124, 67);
            this.btnTiepNhan.TabIndex = 8;
            this.btnTiepNhan.Text = "Tiếp nhận";
            this.btnTiepNhan.UseVisualStyleBackColor = true;
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(820, 78);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(226, 22);
            this.txtBienSo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(730, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Biển số";
            // 
            // txtSoThe
            // 
            this.txtSoThe.Location = new System.Drawing.Point(478, 78);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(219, 22);
            this.txtSoThe.TabIndex = 3;
            this.txtSoThe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số thẻ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại xe";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1286, 37);
            this.panel2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1027, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ảnh chụp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Camera";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.23328F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.76672F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.picBoxCam, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 199);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1286, 270);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(648, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(635, 264);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // picBoxCam
            // 
            this.picBoxCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxCam.Location = new System.Drawing.Point(3, 3);
            this.picBoxCam.Name = "picBoxCam";
            this.picBoxCam.Size = new System.Drawing.Size(639, 264);
            this.picBoxCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCam.TabIndex = 0;
            this.picBoxCam.TabStop = false;
            // 
            // frm_XeVao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 469);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_XeVao";
            this.Text = "frm_XeVao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_XeVao_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_XeVao_FormClosed);
            this.Load += new System.EventHandler(this.frm_XeVao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTiepNhan;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picBoxCam;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbCamera;
    }
}