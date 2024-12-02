using System;
using System.Data;
using System.Windows.Forms;

namespace Responsi
{
    public partial class Form1 : Form
    {
        private Karyawan karyawan;
        private DataGridViewRow r;

        public Form1()
        {
            InitializeComponent();
            karyawan = new Karyawan("Host=localhost;Port=5432;Username=postgres;Password=admin;Database=Responsi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();       // Load the main DataGridView
            LoadDepartemen(); // Populate the combo box
        }

        private void LoadDepartemen()
        {
            DataTable dt = karyawan.LoadDepartments();
            if (dt != null)
            {
                cbDepartemen.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    // Combine id_dep and nama_dep (e.g., "HR - Human Resources")
                    cbDepartemen.Items.Add($"{row["id_dep"]} - {row["nama_dep"]}");
                }
            }
        }


        private void LoadData()
        {
            DataTable dt = karyawan.LoadData();
            if (dt != null)
            {
                dgvKaryawan.DataSource = dt;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadDepartemen();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || cbDepartemen.SelectedItem == null)
            {
                MessageBox.Show("Nama dan Departemen harus diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = cbDepartemen.SelectedItem.ToString();
            string idDep = selectedItem.Split('-')[0].Trim(); // Extract "HR" from "HR - Human Resources"

            if (karyawan.InsertData(txtName.Text, idDep))
            {
                MessageBox.Show("Data Karyawan Berhasil Diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                txtName.Text = null;
                cbDepartemen.SelectedIndex = -1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (r == null || cbDepartemen.SelectedItem == null)
            {
                MessageBox.Show("Pilih data dan Departemen!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (r.Cells["id_karyawan"].Value != null && int.TryParse(r.Cells["id_karyawan"].Value.ToString(), out int idKaryawan))
            {
                string selectedItem = cbDepartemen.SelectedItem.ToString();
                string idDep = selectedItem.Split('-')[0].Trim();

                if (karyawan.UpdateData(idKaryawan, txtName.Text, idDep))
                {
                    MessageBox.Show("Data Karyawan Berhasil Diupdate", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    txtName.Text = null;
                    cbDepartemen.SelectedIndex = -1;
                    r = null;
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih baris data dahulu!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (r.Cells["id_karyawan"].Value == null)
            {
                MessageBox.Show("Anda memilih row kosong, Data tidak valid!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Apakah Anda ingin menghapus data " + r.Cells["nama"].Value.ToString() + " ?", "Hapus data terkonfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (r.Cells["id_karyawan"].Value != null && int.TryParse(r.Cells["id_karyawan"].Value.ToString(), out int idKaryawan))
                    {
                        if (karyawan.DeleteData(idKaryawan))
                        {
                            MessageBox.Show("Data Karyawan Berhasil Dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            txtName.Text = cbDepartemen.Text = null;
                            r = null;
                        }
                    }
                }
            }
        }

        private void dgvKaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvKaryawan.Rows[e.RowIndex];
                txtName.Text = r.Cells["nama"].Value.ToString();

                // Match the id_dep to combo box item
                // If null, set to -1

                string idDep = r.Cells["id_dep"].Value.ToString();
                if (idDep == "")
                {
                    cbDepartemen.SelectedIndex = -1;
                    return;
                }
                else { 
                foreach (var item in cbDepartemen.Items)
                {
                    if (item.ToString().StartsWith(idDep))
                    {
                        cbDepartemen.SelectedItem = item;
                        break;
                    }   
                 }
                }
            }
        }

    }
}
