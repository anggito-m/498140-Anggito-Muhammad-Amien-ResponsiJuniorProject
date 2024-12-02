using System;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace Responsi
{
    public class Karyawan
    {
        private NpgsqlConnection conn;
        private string connstring;

        public Karyawan(string connstring)
        {
            this.connstring = connstring;
            conn = new NpgsqlConnection(connstring);
        }

        public DataTable LoadData()
        {
            try
            {
                string sql = "select * from select_all()";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataTable dt = new DataTable();
                conn.Open();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable LoadDepartments()
        {
            try
            {
                string sql = "SELECT id_dep, nama_dep FROM departemen";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                DataTable dt = new DataTable();
                conn.Open();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load Departments FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public bool InsertData(string nama, string idDep)
        {
            try
            {
                string sql = @"select * from insert_data(:_nama, :_id_dep)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", nama);
                cmd.Parameters.AddWithValue("_id_dep", idDep);
                conn.Open();
                bool result = (int)cmd.ExecuteScalar() == 1;
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateData(int idKaryawan, string nama, string idDep)
        {
            try
            {
                string sql = @"select * from update_data(:_id_karyawan, :_nama, :_id_dep)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", idKaryawan);
                cmd.Parameters.AddWithValue("_nama", nama);
                cmd.Parameters.AddWithValue("_id_dep", idDep);
                conn.Open();
                bool result = (int)cmd.ExecuteScalar() == 1;
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteData(int idKaryawan)
        {
            try
            {
                string sql = @"select * from delete_by_id(:_id_karyawan)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", idKaryawan);
                conn.Open();
                bool result = (int)cmd.ExecuteScalar() == 1;
                conn.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete FAIL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
