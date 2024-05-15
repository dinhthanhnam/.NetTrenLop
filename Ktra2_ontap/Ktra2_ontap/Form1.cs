using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
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
        private void Load_DGV()
        {
            string sql;
            sql = "SELECT mahang, tenhang, mamau, soluong, thoigianbaohanh FROM tblhanghoa";
            var tblHangHoa = Ktra2_ontap.Functions.GetDataToTable(sql);
            dgvData.DataSource = tblHangHoa;

            //do dl tu bang vao datagridview

            dgvData.Columns[0].HeaderText = "Ma hang";
            dgvData.Columns[1].HeaderText = "Ten hang";
            dgvData.Columns[2].HeaderText = "Ma mau";
            dgvData.Columns[3].HeaderText = "So luong";
            dgvData.Columns[4].HeaderText = "Thoi gian bao hanh";

            dgvData.Columns[0].Width = 200;
            dgvData.Columns[1].Width = 200;
            dgvData.Columns[2].Width = 200;
            dgvData.Columns[3].Width = 200;
            dgvData.Columns[4].Width = 200;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dgvData.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dgvData.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMaHang.Enabled = false;
            Functions.Connect();
            Load_DGV();
            Functions.Disconnect();
        }
        

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
        private void ResetValues()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtMaMau.Text = "";
            txtSoLuong.Text = "";
            txtTGBH.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
        }
    }
}
