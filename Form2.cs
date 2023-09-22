using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap3_3
{
    public partial class frmThem : Form
    {
        public string Mssv { get; set; }
        public string Tensv { get; set; }

        public string Khoa { get; set; }
        public string Dtb { get; set; }


        public frmThem()
        {
            InitializeComponent();
            cmbKhoa.Items.Add("Quản trị kinh doanh");
            cmbKhoa.Items.Add("Công nghệ thông tin");
            cmbKhoa.Items.Add("Ngôn ngữ anh");
        }

        private void frmThem_Load(object sender, EventArgs e)
        {
            cmbKhoa.SelectedItem = "Công nghệ thông tin";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Mssv = txtMSSV.Text;
            Tensv = txtName.Text;
            if (cmbKhoa.SelectedItem != null)
            {
                Khoa = cmbKhoa.SelectedItem.ToString();
            }
            else
            {

                MessageBox.Show("Vui lòng chọn khoa.");
            }
            Dtb = txtDTB.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQLSV f = new frmQLSV();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
