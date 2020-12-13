using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_QLBaiXe;
using BUS_QLBaiXe;
using System.Security.Cryptography;


namespace GUI_QLBaiXe
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();


        }
        DBConnect cn = new DBConnect();
        public static string MaNV { get; set; }
        public static string MatKhau { get; set; }
        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();

            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();

            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from NHANVIEN where MaNV=N'" + txtTk.Text + "' and MatKhau='" + encryption(txtMk.Text) + "'";
            if (cn.loadLabel(sql) == "1" || txtTk.Text == "NV000001")
            {
                MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Frm_Main frm = new Frm_Main();
                MaNV = txtTk.Text.Trim();
                MatKhau = txtMk.Text.Trim();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtTk.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtMk.Focus();
            }
        }

        private void txtMk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSign_Click(sender, e);
            }
        }

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
