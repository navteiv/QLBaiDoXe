namespace GUI_QLBaiXe
{
    partial class Frm_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Search));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ngaygiovao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaygiora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sothe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bienso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.iconsList = new System.Windows.Forms.ImageList(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pnlRdiobtn = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlRdiobtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnlRdiobtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 166);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(890, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(705, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thông tin tìm kiếm";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ngaygiovao,
            this.ngaygiora,
            this.sothe,
            this.bienso,
            this.giatien});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 166);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1387, 320);
            this.dataGridView1.TabIndex = 66;
            // 
            // ngaygiovao
            // 
            this.ngaygiovao.HeaderText = "Giờ vào";
            this.ngaygiovao.Name = "ngaygiovao";
            // 
            // ngaygiora
            // 
            this.ngaygiora.HeaderText = "Giờ ra";
            this.ngaygiora.Name = "ngaygiora";
            // 
            // sothe
            // 
            this.sothe.HeaderText = "Số thẻ";
            this.sothe.Name = "sothe";
            // 
            // bienso
            // 
            this.bienso.HeaderText = "Biển Số";
            this.bienso.Name = "bienso";
            // 
            // giatien
            // 
            this.giatien.HeaderText = "Giá";
            this.giatien.Name = "giatien";
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 17;
            this.button1.ImageList = this.iconsList;
            this.button1.Location = new System.Drawing.Point(1239, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tìm kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(127, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tìm theo số thẻ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(154, 12);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(134, 21);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Tìm theo biển số";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // pnlRdiobtn
            // 
            this.pnlRdiobtn.Controls.Add(this.radioButton2);
            this.pnlRdiobtn.Controls.Add(this.radioButton1);
            this.pnlRdiobtn.Location = new System.Drawing.Point(890, 54);
            this.pnlRdiobtn.Name = "pnlRdiobtn";
            this.pnlRdiobtn.Size = new System.Drawing.Size(281, 45);
            this.pnlRdiobtn.TabIndex = 10;
            // 
            // Frm_TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_TimKiem";
            this.Text = "Frm_TimKiem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlRdiobtn.ResumeLayout(false);
            this.pnlRdiobtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaygiovao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaygiora;
        private System.Windows.Forms.DataGridViewTextBoxColumn sothe;
        private System.Windows.Forms.DataGridViewTextBoxColumn bienso;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList iconsList;
        private System.Windows.Forms.Panel pnlRdiobtn;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}