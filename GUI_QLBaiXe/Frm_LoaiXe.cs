using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLBaiXe;
using DAL_QLBaiXe;

namespace GUI_QLBaiXe
{
    public partial class Frm_LoaiXe : Form
    {
        public Frm_LoaiXe()
        {
            InitializeComponent();
        }
        int dong;
        bool themmoi;
        DAL_QLBaiXe.DAL_LoaiXe dll = new DAL_QLBaiXe.DAL_LoaiXe();
        BUS_QLBaiXe.BUS_LoaiXe ck = new BUS_QLBaiXe.BUS_LoaiXe();
        DBConnect cn = new DBConnect();
        public void setNull()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtGiaTien.Text = "0";
        }
        public void LockText()
        {
            txtMaLoai.Enabled = false;
            txtTenLoai.Enabled = false;
            txtGiaTien.Enabled = false;

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
        }
        public void UnlockText()
        {
            txtTenLoai.Enabled = true;
            txtGiaTien.Enabled = true;

            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
        }
        public void display()
        {
            dgvLoaiXe.DataSource = dll.data();
            foreach (DataGridViewColumn col in dgvLoaiXe.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void Frm_LoaiXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void dgvLoaiXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LockText();
                dong = e.RowIndex;
                txtMaLoai.Text = dgvLoaiXe.Rows[dong].Cells["MaLoai"].Value.ToString();
                txtTenLoai.Text = dgvLoaiXe.Rows[dong].Cells["LoaiXe"].Value.ToString();
                txtGiaTien.Text = dgvLoaiXe.Rows[dong].Cells["GiaTien"].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setNull();
            UnlockText();
            themmoi = true;
            txtMaLoai.Text = cn.taomatudong("MaLoai", "LoaiXe", "LX");
            txtTenLoai.Focus();
        }
        void getValues()
        {
            ck.maLoai = txtMaLoai.Text;
            ck.loaiXe = txtTenLoai.Text;
            ck.giaTien = txtGiaTien.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            getValues();
            if (themmoi)
            {
                if (string.IsNullOrEmpty(txtMaLoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else
                {

                    if (dll.kiemtra(txtMaLoai.Text) == "0")
                    {

                        try
                        {
                            dll.themmoiloaixe(ck);
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
                        txtTenLoai.Focus();
                    }
                }
            }
            else
            {
                try
                {
                    dll.sualoaixe(ck);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            themmoi = false;
            UnlockText();
            txtMaLoai.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                getValues();
                dll.xoaloaixe(ck);
                display();
                MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xóa Thất Bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void Frm_LoaiXe_Load(object sender, EventArgs e)
        {
            display();
            LockText();
        }
    }
}
