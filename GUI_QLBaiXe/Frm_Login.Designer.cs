namespace GUI_QLBaiXe
{
    partial class Frm_Login
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(540, 161);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 41);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.Yellow;
            this.btnSign.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.ForeColor = System.Drawing.Color.Black;
            this.btnSign.Location = new System.Drawing.Point(359, 161);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(92, 41);
            this.btnSign.TabIndex = 11;
            this.btnSign.Text = "Sign In";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(371, 118);
            this.txtMk.Name = "txtMk";
            this.txtMk.PasswordChar = '*';
            this.txtMk.Size = new System.Drawing.Size(273, 22);
            this.txtMk.TabIndex = 10;
            this.txtMk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMk_KeyDown);
            // 
            // txtTk
            // 
            this.txtTk.Location = new System.Drawing.Point(371, 79);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(273, 22);
            this.txtTk.TabIndex = 9;
            this.txtTk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTk_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(442, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tài Khoản ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mật Khẩu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI_QLBaiXe.Properties.Resources.img_297675;
            this.pictureBox1.Location = new System.Drawing.Point(95, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}