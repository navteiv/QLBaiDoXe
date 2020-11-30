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

namespace GUI_QLBaiXe
{
    public partial class Frm_TheXe : Form
    {
        public Frm_TheXe()
        {
            InitializeComponent();
        }
        int dong;
        bool themmoi;
        DAL_QLBaiXe.DAL_TheXe dll = new DAL_TheXe();
        BUS_QLBaiXe.BUS_The ck = new BUS_The();
        DBConnect con = new DBConnect();

        public void setNull()
        {
            txtSoThe.Text = null;
            txtNgayDK.Value = DateTime.Now;
        }
        public void LockText()
        {
            txtNgayDK.Enabled = false;
            txtSoThe.Enabled = false;

            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDel.Enabled = true;
        }
        public void unLockText()
        {
            txtNgayDK.Enabled = true;

            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDel.Enabled = false;
        }
        public void display()
        {
            dgvTheXe.DataSource = dll.data();
            foreach (DataGridViewColumn col in dgvTheXe.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }
        private void Frm_TheXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }

        private void Frm_TheXe_Load(object sender, EventArgs e)
        {
            display();
            LockText();
        }

        private void dgvTheXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LockText();
                dong = e.RowIndex;
                txtSoThe.Text = dgvTheXe.Rows[dong].Cells["SoThe"].Value.ToString();
                txtNgayDK.Text = dgvTheXe.Rows[dong].Cells["NgayDK"].Value.ToString();
                txtNgayKT.Text = dgvTheXe.Rows[dong].Cells["NgayKT"].Value.ToString();
                cbbStatus.Text = dgvTheXe.Rows[dong].Cells["TinhTrang"].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            setNull();
            unLockText();
            txtSoThe.Enabled = true;
            txtSoThe.Focus();
            themmoi = true;
            
        }
        void getValues()
        {
            ck.soThe = txtSoThe.Text.ToUpper();
            ck.ngayDK = txtNgayDK.Value;
            ck.ngayKT = txtNgayKT.Value;
            ck.tinhTrang = cbbStatus.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            getValues();
            if (themmoi == true)
            {
                if (string.IsNullOrEmpty(txtSoThe.Text))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                }
                else
                {

                    if (dll.kiemtra(txtSoThe.Text) == "0")
                    {

                       try
                       {
                            dll.themThe(ck);
                            display();
                            MessageBox.Show("Lưu Thành Công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                       }
                       catch (Exception err)
                       {
                            MessageBox.Show(err.Message);
                            MessageBox.Show("Lưu Thất Bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                       }
                    }
                    else
                    {
                        MessageBox.Show("Mã Này Đã Có", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                try
                {
                    dll.suaThe(ck);
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
            unLockText();
            txtSoThe.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                getValues();
                dll.xoaThe(ck);
                display();
                MessageBox.Show("Xóa Thành Công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xóa Thất Bại", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void txtSoThe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txtNgayDK;
            }
        }

    }
}
