namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "abc";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ;
            if (MessageBox.Show("Ban co muon thoat khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban nhap sai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') ||
                (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;

        }
    }
}
