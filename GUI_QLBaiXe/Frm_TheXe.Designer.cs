namespace GUI_QLBaiXe
{
    partial class Frm_TheXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TheXe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.txtNgayKT = new System.Windows.Forms.DateTimePicker();
            this.txtNgayDK = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.iconsList = new System.Windows.Forms.ImageList(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.dgvTheXe = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheXe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbStatus);
            this.panel1.Controls.Add(this.txtNgayKT);
            this.panel1.Controls.Add(this.txtNgayDK);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSoThe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1328, 292);
            this.panel1.TabIndex = 64;
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Đang sử dụng",
            "Đang chờ cấp",
            "Thẻ hỏng"});
            this.cbbStatus.Location = new System.Drawing.Point(782, 143);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(500, 24);
            this.cbbStatus.TabIndex = 78;
            // 
            // txtNgayKT
            // 
            this.txtNgayKT.CustomFormat = "dd/MM/yyyy HH:mm";
            this.txtNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayKT.Location = new System.Drawing.Point(782, 101);
            this.txtNgayKT.Name = "txtNgayKT";
            this.txtNgayKT.Size = new System.Drawing.Size(500, 22);
            this.txtNgayKT.TabIndex = 77;
            // 
            // txtNgayDK
            // 
            this.txtNgayDK.CustomFormat = "dd/MM/yyyy HH:mm";
            this.txtNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayDK.Location = new System.Drawing.Point(782, 60);
            this.txtNgayDK.Name = "txtNgayDK";
            this.txtNgayDK.Size = new System.Drawing.Size(500, 22);
            this.txtNgayDK.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(658, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Tình trạng";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(633, 103);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(119, 20);
            this.lbl2.TabIndex = 73;
            this.lbl2.Text = "Ngày hết hạn";
            // 
            // btnDel
            // 
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.ImageIndex = 19;
            this.btnDel.ImageList = this.iconsList;
            this.btnDel.Location = new System.Drawing.Point(1214, 201);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 56);
            this.btnDel.TabIndex = 71;
            this.btnDel.Text = "Xóa";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            // btnUpdate
            // 
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageIndex = 8;
            this.btnUpdate.ImageList = this.iconsList;
            this.btnUpdate.Location = new System.Drawing.Point(1064, 201);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 56);
            this.btnUpdate.TabIndex = 70;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageIndex = 12;
            this.btnSave.ImageList = this.iconsList;
            this.btnSave.Location = new System.Drawing.Point(917, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 56);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 14;
            this.btnAdd.ImageList = this.iconsList;
            this.btnAdd.Location = new System.Drawing.Point(764, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 56);
            this.btnAdd.TabIndex = 68;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(633, 62);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(121, 20);
            this.lbl.TabIndex = 67;
            this.lbl.Text = "Ngày đăng ký";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(691, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Số thẻ";
            // 
            // txtSoThe
            // 
            this.txtSoThe.Location = new System.Drawing.Point(782, 21);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(500, 22);
            this.txtSoThe.TabIndex = 64;
            this.txtSoThe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoThe_KeyDown);
            // 
            // dgvTheXe
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTheXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTheXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTheXe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTheXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTheXe.EnableHeadersVisualStyles = false;
            this.dgvTheXe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvTheXe.Location = new System.Drawing.Point(0, 292);
            this.dgvTheXe.Name = "dgvTheXe";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTheXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTheXe.RowHeadersVisible = false;
            this.dgvTheXe.RowHeadersWidth = 20;
            this.dgvTheXe.RowTemplate.Height = 24;
            this.dgvTheXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheXe.Size = new System.Drawing.Size(1328, 148);
            this.dgvTheXe.TabIndex = 65;
            this.dgvTheXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheXe_CellContentClick);
            // 
            // Frm_TheXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 440);
            this.Controls.Add(this.dgvTheXe);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_TheXe";
            this.Text = "Frm_TheXe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_TheXe_FormClosing);
            this.Load += new System.EventHandler(this.Frm_TheXe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.ImageList iconsList;
        private System.Windows.Forms.DataGridView dgvTheXe;
        private System.Windows.Forms.DateTimePicker txtNgayDK;
        private System.Windows.Forms.DateTimePicker txtNgayKT;
        private System.Windows.Forms.ComboBox cbbStatus;
    }
}