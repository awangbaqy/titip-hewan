using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Titip_Hewan
{
    public partial class Layanan : Form
    {
        SqlConnection CON = new SqlConnection(@"Data Source=DESKTOP-NSDDQ70;Initial Catalog=titip_hewan;Integrated Security=True");
        private string rba, rbb;

        public Layanan()
        { InitializeComponent(); this.MaximizeBox = false; }

        private void Layanan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'titip_hewanDataSet.layanan' table. You can move, or remove it, as needed.
            this.layananTableAdapter.Fill(this.titip_hewanDataSet.layanan);
            // TODO: This line of code loads data into the 'titip_hewanDataSet.layanan' table. You can move, or remove it, as needed.
            this.layananTableAdapter.Fill(this.titip_hewanDataSet.layanan);
            load_data();
            loadCBCari();
            gbLayanan.Enabled = false;
        }

        private void load_data()
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from layanan";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvLayanan.DataSource = dt;

            CON.Close();
        }

        private void loadCBCari()
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name from sys.columns where object_id = object_id('layanan')";
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            cbKolom.DisplayMember = "name";
            cbKolom.ValueMember = "name";
            cbKolom.DataSource = ds.Tables[0];

            CON.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            gbLayanan.Enabled = true;
            lblIDLayanan.Text = "ID Layanan";
            txtLayanan.Clear();
            txtLayanan.Focus();
            txtBiaya.Clear();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            int biaya;
            if (rbYaMM.Checked) { rba = "Ya"; } else { rba = "Tidak"; }
            if (rbYaRawat.Checked) { rbb = "Ya"; biaya = 250000; } else { rbb = "Tidak"; biaya = 0; }
            if (string.IsNullOrEmpty(txtLayanan.Text)) { txtLayanan.Text = "-"; }
            if (string.IsNullOrEmpty(txtBiaya.Text)) { txtBiaya.Text = "0"; }

            biaya = biaya + Convert.ToInt32(txtBiaya.Text);
            
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("insert into layanan([Makan & Minum],[Perawatan],[Lainnya],[Biaya Per Hari]) values ('" + rba + "','" + rbb + "','" + txtLayanan.Text + "','" + biaya + "')");
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Layanan Tersimpan");
            gbLayanan.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int biaya;
            if (rbYaMM.Checked) { rba = "Ya"; } else { rba = "Tidak"; }
            if (rbYaRawat.Checked) { rbb = "Ya"; biaya = 250000; } else { rbb = "Tidak"; biaya = 0; }
            if (string.IsNullOrEmpty(txtLayanan.Text)) { txtLayanan.Text = "-"; }
            if (string.IsNullOrEmpty(txtBiaya.Text)) { txtBiaya.Text = "-"; }

            biaya = biaya + Convert.ToInt32(txtBiaya.Text);

            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("update layanan set [Makan & Minum] = '" + rba + "', [Perawatan] = '" + rbb + "', [Lainnya] = '" + txtLayanan.Text + "', [Biaya Per Hari] = '" + biaya + "' where [ID Layanan] = '" + lblIDLayanan.Text + "'");
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Layanan Ter-Update");
            gbLayanan.Enabled = false;
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("delete from layanan where [ID Layanan] = '" + lblIDLayanan.Text + "'");
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Layanan Terhapus");
            gbLayanan.Enabled = false;
        }
        
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void layananBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.layananBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.titip_hewanDataSet);

        }

        private void dgvLayanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbLayanan.Enabled = true;

            lblIDLayanan.Text = dgvLayanan.SelectedRows[0].Cells[0].Value.ToString();
            rba = dgvLayanan.SelectedRows[0].Cells[1].Value.ToString();
            if (rba == "Ya") { rbYaMM.Checked = true; } else { rbTidakMM.Checked = true; }
            rbb = dgvLayanan.SelectedRows[0].Cells[2].Value.ToString();
            if (rbb == "Ya") { rbYaRawat.Checked = true; } else { rbTidakRawat.Checked = true; }
            txtLayanan.Text = dgvLayanan.SelectedRows[0].Cells[3].Value.ToString();
            txtBiaya.Text = dgvLayanan.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void rbYaRawat_Click(object sender, EventArgs e)
        {
            lblHarga.Visible = true;
        }

        private void rbTidakRawat_Click(object sender, EventArgs e)
        {
            lblHarga.Visible = false;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCari.Text))
            { load_data(); }
            else
            {
                CON.Open();
                SqlCommand cmd = CON.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("select * from layanan where [" + cbKolom.Text + "] = '" + txtCari.Text + "'");
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvLayanan.DataSource = dt;
                CON.Close();
            }
        }
    }
}