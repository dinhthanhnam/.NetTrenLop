using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ktra2_ontap
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tblHangHoa;
        private void Load_DGV()
        {
            string sql;
            sql = "SELECT mahang, tenhang, mamau, soluong, thoigianbaohanh FROM tblhanghoa";
            tblHangHoa = Functions.GetDataToTable(sql);
            dgvData.DataSource = tblHangHoa;

            //do dl tu bang vao datagridview

            dgvData.Columns[0].HeaderText = "Ma hang";
            dgvData.Columns[1].HeaderText = "Ten hang";
            dgvData.Columns[2].HeaderText = "Ma mau";
            dgvData.Columns[3].HeaderText = "So luong";
            dgvData.Columns[4].HeaderText = "Thoi gian bao hanh";

            dgvData.Columns[0].Width = 100;
            dgvData.Columns[1].Width = 100;
            dgvData.Columns[2].Width = 100;
            dgvData.Columns[3].Width = 100;
            dgvData.Columns[4].Width = 100;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dgvData.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dgvData.EditMode = DataGridViewEditMode.EditProgrammatically;
            Functions.FillCombo("SELECT mamau, tenmau FROM tblmausac",comboBoxMaMau, "mamau", "tenmau");
            comboBoxMaMau.SelectedIndex = -1;
            ResetValues();


        }
        private void ResetValues()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            comboBoxMaMau.SelectedItem = null;
            txtSoLuong.Clear();
            txtTGBH.Clear();
        }

        private void ResetState()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void ResetRead()
        {
            txtMaHang.Enabled = false;
            txtTenHang.Enabled = false;
            txtSoLuong.Enabled = false;
            txtTGBH.Enabled = false;
            comboBoxMaMau.Enabled = false;
        }

        private void ResetWrite()
        {
            txtMaHang.Enabled = true;
            txtTenHang.Enabled = true;
            txtSoLuong.Enabled = true;
            txtTGBH.Enabled = true;
            comboBoxMaMau.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetRead();
            ResetState();
            Functions.Connect();
            Load_DGV();
        }
        

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Dang o che do them moi!", "Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }

            if (tblHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu!", "Thong bao", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            ResetWrite();
            txtMaHang.Enabled = false;
            txtMaHang.Text = dgvData.CurrentRow.Cells["mahang"].Value.ToString();
            txtTenHang.Text = dgvData.CurrentRow.Cells["tenhang"].Value.ToString();
            txtSoLuong.Text = dgvData.CurrentRow.Cells["soluong"].Value.ToString();
            txtTGBH.Text = dgvData.CurrentRow.Cells["thoigianbaohanh"].Value.ToString();
            comboBoxMaMau.SelectedValue = dgvData.CurrentRow.Cells["mamau"].Value;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetWrite();
            ResetValues();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            ResetState();
            ResetRead();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaHang.Text =="")
            {
                MessageBox.Show("Yeu cau nhap ma hang hoa", "Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yeu cau nhap ten hang", "Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
                return;
            }
            if (comboBoxMaMau.SelectedIndex == -1)
            {
                MessageBox.Show("Yeu cau chon mau", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxMaMau.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yeu cau nhap so luong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }
            if (txtTGBH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yeu cau nhap thoi gian bao hanh", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTGBH.Focus();
                return;
            }
                sql = "SELECT mahang FROM tblhanghoa WHERE mahang=N'" + txtMaHang.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Ma hang hoa da ton tai, yeu cau nhap lai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHang.Focus();
                txtMaHang.Text = "";
                return;
            }

            sql = "INSERT INTO tblhanghoa(mahang,tenhang,mamau,soluong,thoigianbaohanh) VALUES(N'" +txtMaHang.Text + "',N'" + txtTenHang.Text + "',N'" + comboBoxMaMau.SelectedValue.ToString() + "',N'" + Convert.ToDouble(txtSoLuong.Text) + "',N'" + Convert.ToDouble(txtTGBH.Text) +"')";
            Functions.RunSql(sql);
            Load_DGV();
            ResetValues();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu", "Thong bao", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Chua chon ban ghi nao", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0 || txtSoLuong.Text.Trim().Length == 0|| txtTGBH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Yeu cau nhap du thong tin", "Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
                return;
            }
            string sql1 = "UPDATE tblhanghoa SET tenhang=N'" + txtTenHang.Text.ToString() +"' WHERE mahang=N'" + txtMaHang.Text + "'";
            Functions.RunSql(sql1);
            string sql2 = "UPDATE tblhanghoa SET soluong=N'" + txtSoLuong.Text.ToString() + "' WHERE mahang=N'" + txtMaHang.Text + "'";
            Functions.RunSql(sql2);
            string sql3 = "UPDATE tblhanghoa SET thoigianbaohanh=N'" + txtTGBH.Text.ToString() + "' WHERE mahang=N'" + txtMaHang.Text + "'";
            Functions.RunSql(sql3);
            string sql4 = "UPDATE tblhanghoa SET mamau=N'" + comboBoxMaMau.SelectedValue.ToString() + "' WHERE mahang=N'" + txtMaHang.Text + "'";
            Functions.RunSql(sql4);
 
            Load_DGV();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHangHoa.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu", "Thong bao", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Chua chon ban ghi nao", "Thong bao",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Co chac chan muon xoa khong?", "Thong bao",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblhanghoa WHERE mahang=N'" + txtMaHang.Text + "'";
                Functions.RunSql(sql);
                Load_DGV();
                ResetValues();
            }

        }
    }
}
