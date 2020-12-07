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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
        }
        DAL_QLBaiXe.DAL_NhanVien dll = new DAL_QLBaiXe.DAL_NhanVien();
        BUS_QLBaiXe.BUS_NhanVien ck = new BUS_QLBaiXe.BUS_NhanVien();
        DBConnect con = new DBConnect();
        int dong;
        bool themmoi;
        public string ID { get; set; }
        public void setNull()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
            txtMatKhau.Text = "";
        }
        public void LockText()
        {
            txtMaNV.Enabled = false;
            txtHoTen.Enabled = false;
            txtDiaChi.Enabled = false;
            txtCMND.Enabled = false;
            txtSDT.Enabled = false;
            txtMatKhau.Enabled = false;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;

        }
        public void UnLockText()
        {
          //  txtMaNV.Enabled = true;
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtCMND.Enabled = true;
            txtSDT.Enabled = true;
            txtMatKhau.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }
        public void display()
        {
            dgvNhanVien.DataSource = dll.data(ID);
            foreach (DataGridViewColumn col in dgvNhanVien.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        
        private void Frm_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            display();
            LockText();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setNull();
            UnLockText();
            themmoi = true;
            txtMaNV.Text = con.taomatudong("manv", "NHANVIEN", "NV");
            txtHoTen.Focus();
        }
        void getValues()
        {
            ck.maNV = txtMaNV.Text;
            ck.hoTen = txtHoTen.Text;
            ck.CMND = txtCMND.Text;
            ck.diaChi = txtDiaChi.Text;
            ck.SDT = txtSDT.Text;
            ck.matKhau = encryption(txtMatKhau.Text);
        }
        // Mã hóa MD5
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            getValues();
            if (themmoi == true)
            {
                if (string.IsNullOrEmpty(txtMaNV.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {

                    if (dll.kiemtra(txtMaNV.Text) == "0")
                    {

                        try
                        {
                            dll.themNV(ck);
                            display();
                            MessageBox.Show("Lưu Thành Công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Lưu Thất Bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Này Đã Có", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        txtHoTen.Focus();
                    }
                }
            }
            else
            {
                try
                {
                    dll.suaNV(ck);
                    display();
                    MessageBox.Show("Sửa Thành Công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Sửa Thất Bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            LockText();
            setNull();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            themmoi = false;
            UnLockText();
            txtMatKhau.Enabled = false;
            txtMaNV.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                getValues();
                dll.xoaNV(ck);
                display();
                MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                setNull();
            }
            catch
            {
                MessageBox.Show("Xóa Thất Bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LockText();
            try
            {
                dong = e.RowIndex;
                txtMaNV.Text = dgvNhanVien.Rows[dong].Cells["manv"].Value.ToString();
                txtHoTen.Text = dgvNhanVien.Rows[dong].Cells["hoten"].Value.ToString();
                txtCMND.Text = dgvNhanVien.Rows[dong].Cells["cmnd"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[dong].Cells["diachi"].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[dong].Cells["sdt"].Value.ToString();

            }
            catch { }
        }
    }
}
