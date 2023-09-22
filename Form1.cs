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
    public partial class frmQLSV : Form
    {
        public frmQLSV()
        {
            InitializeComponent();
            toolStriptxtSearch.TextChanged += new EventHandler(toolStriptxtSearch_TextChanged);
        }
        private int GetselectedRows(string Mssv)
        {
            dgvStudent.AllowUserToAddRows = false;
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[1].Value.ToString() == Mssv)
                {
                    return i;
                }
            }
            return -1;
        }


        void addSV()
        {
            frmThem frm2 = new frmThem();

            if (frm2.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (string.IsNullOrEmpty(frm2.Mssv) || string.IsNullOrEmpty(frm2.Tensv) ||
                string.IsNullOrEmpty(frm2.Dtb) || string.IsNullOrEmpty(frm2.Khoa))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (!float.TryParse(frm2.Dtb, out float diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ (0 - 10)", "Thông Báo", MessageBoxButtons.OK);
                return;
            }


            int selected = GetselectedRows(frm2.Mssv);
            if (selected == -1)
            {
                dgvStudent.Rows.Add(("0" + (dgvStudent.Rows.Count + 1)).ToString(), frm2.Mssv, frm2.Tensv, frm2.Khoa, frm2.Dtb);
                MessageBox.Show("Thêm Thông Tin Thành công!!!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Mã số sinh viên trùng, vui lòng nhập lại", "Thông Báo", MessageBoxButtons.OK);
            }
        }
        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            addSV();
        }

        private void toolStriptxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = toolStriptxtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                string tenSinhVien = row.Cells["colTensv"].Value.ToString().ToLower();
                if (tenSinhVien.Contains(searchText))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void thêmMớitsm_Click(object sender, EventArgs e)
        {
            addSV();
        }

        private void tìmKiếmtsm_Click(object sender, EventArgs e)
        {
            toolStriptxtSearch.Focus();
        }

        private void toolStripMenuItemThoat_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void toolStripBtnAdd_Click_1(object sender, EventArgs e)
        {
            addSV();
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {

        }
    }
}
