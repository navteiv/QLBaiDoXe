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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Search));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.iconsList = new System.Windows.Forms.ImageList(this.components);
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlRdiobtn = new System.Windows.Forms.Panel();
            this.op2 = new System.Windows.Forms.RadioButton();
            this.op1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnlRdiobtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnlRdiobtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 166);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.ImageIndex = 17;
            this.btnSearch.ImageList = this.iconsList;
            this.btnSearch.Location = new System.Drawing.Point(1239, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 43);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(890, 40);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(316, 22);
            this.txtTim.TabIndex = 7;
            this.txtTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTim_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(698, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thông tin tìm kiếm";
            // 
            // pnlRdiobtn
            // 
            this.pnlRdiobtn.Controls.Add(this.op2);
            this.pnlRdiobtn.Controls.Add(this.op1);
            this.pnlRdiobtn.Location = new System.Drawing.Point(890, 54);
            this.pnlRdiobtn.Name = "pnlRdiobtn";
            this.pnlRdiobtn.Size = new System.Drawing.Size(316, 45);
            this.pnlRdiobtn.TabIndex = 10;
            // 
            // op2
            // 
            this.op2.AutoSize = true;
            this.op2.Location = new System.Drawing.Point(154, 12);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(134, 21);
            this.op2.TabIndex = 9;
            this.op2.Text = "Tìm theo biển số";
            this.op2.UseVisualStyleBackColor = true;
            // 
            // op1
            // 
            this.op1.AutoSize = true;
            this.op1.Checked = true;
            this.op1.Location = new System.Drawing.Point(7, 12);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(127, 21);
            this.op1.TabIndex = 9;
            this.op1.TabStop = true;
            this.op1.Text = "Tìm theo số thẻ";
            this.op1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 166);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1387, 320);
            this.dataGridView1.TabIndex = 66;
            // 
            // Frm_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Search";
            this.Text = "Frm_TimKiem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Search_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Search_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRdiobtn.ResumeLayout(false);
            this.pnlRdiobtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ImageList iconsList;
        private System.Windows.Forms.Panel pnlRdiobtn;
        private System.Windows.Forms.RadioButton op2;
        private System.Windows.Forms.RadioButton op1;
    }
}