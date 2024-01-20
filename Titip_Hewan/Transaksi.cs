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
    public partial class Transaksi : Form
    {
        SqlConnection CON = new SqlConnection(@"Data Source=DESKTOP-NSDDQ70;Initial Catalog=titip_hewan;Integrated Security=True");
        private int biayaPer, totalBiaya, bedaHari;
        private string jenis;

        public Transaksi()
        { InitializeComponent(); this.MaximizeBox = false; }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'titip_hewanDataSet.transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.titip_hewanDataSet.transaksi);
            load_data();
            loadCBCari();
            gbTransaksi.Enabled = false;
            dtpKeluar.Value = dtpMasuk.Value.AddDays(1);
        }

        private void load_data()
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from transaksi";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvTransaksi.DataSource = dt;

            CON.Close();
        }

        private void loadCBCari()
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name from sys.columns where object_id = object_id('transaksi')";
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
            gbTransaksi.Enabled = true;
            cbIdAnggota.Enabled = true; cbIdHewan.Enabled = false; cbIdKandang.Enabled = true; cbIdLayanan.Enabled = true;
            cbIdAnggota.Items.Clear(); cbIdHewan.Items.Clear(); cbIdKandang.Items.Clear(); cbIdLayanan.Items.Clear();
            cbIdAnggota.ResetText(); cbIdHewan.ResetText(); cbIdKandang.ResetText(); cbIdLayanan.ResetText();
            lblNamaAnggota.Text = "Nama Anggota"; lblNamaHewan.Text = "Nama Hewan";

            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [ID Member] from member";
            cmd.ExecuteNonQuery();
            
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            { cbIdAnggota.Items.Add(sdr["ID Member"].ToString()); }

            CON.Close();
            CON.Open();

            SqlCommand cmddd = CON.CreateCommand();
            cmddd.CommandType = CommandType.Text;
            cmddd.CommandText = "select [ID Layanan] from layanan";
            cmddd.ExecuteNonQuery();

            SqlDataReader sdrrr = cmddd.ExecuteReader();
            while (sdrrr.Read())
            { cbIdLayanan.Items.Add(sdrrr["ID Layanan"].ToString()); }

            CON.Close();
        }
        
        private void cbIdAnggota_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIdHewan.Enabled = true; cbIdHewan.Items.Clear(); cbIdHewan.ResetText();
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from member, hewan where member.[ID Member]= hewan.[ID Member] and hewan.[ID Member] = '" + cbIdAnggota.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                lblNamaAnggota.Text = sdr["Nama Member"] as string;
                cbIdHewan.Items.Add(sdr["ID Hewan"].ToString());
            }
            CON.Close();
            hitung();
        }

        private void cbIdHewan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbIdKandang.Items.Clear(); cbIdKandang.ResetText();
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Nama Hewan],[Jenis Hewan] from hewan where [ID Hewan] = '" + cbIdHewan.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                lblNamaHewan.Text = sdr["Nama Hewan"] as string;
                jenis = sdr["Jenis Hewan"] as string;
            }

            CON.Close();
            CON.Open();

            SqlCommand cmdd = CON.CreateCommand();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select [ID Kandang] from kandang where [Jenis Kandang] = '" + jenis + "'";
            cmdd.ExecuteNonQuery();
            SqlDataReader sdrr = cmdd.ExecuteReader();
            while (sdrr.Read())
            { cbIdKandang.Items.Add(sdrr["ID Kandang"].ToString()); }

            CON.Close();
        }

        private void cbIdLayanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Biaya Per Hari] from layanan where [ID Layanan] = '" + cbIdLayanan.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                biayaPer = Convert.ToInt32(sdr["Biaya Per Hari"]);
                lblBiaya.Text = "Rp. " + biayaPer + ",-";
            }

            CON.Close();
        }

        private void dtpMasuk_ValueChanged(object sender, EventArgs e)
        {
            bedaHari = Convert.ToInt32((DateTime.Parse(dtpKeluar.Text) - DateTime.Parse(dtpMasuk.Text)).TotalDays);
            if (bedaHari <= 0) { dtpKeluar.Value = dtpMasuk.Value.AddDays(1); bedaHari = 1; }
            hitung();
        }

        private void dtpKeluar_ValueChanged(object sender, EventArgs e)
        {
            bedaHari = Convert.ToInt32((DateTime.Parse(dtpKeluar.Text) - DateTime.Parse(dtpMasuk.Text)).TotalDays);
            if (bedaHari <= 0) { dtpKeluar.Value = dtpMasuk.Value.AddDays(1); bedaHari = 1; }
            hitung();
        }

        private void hitung()
        {
            totalBiaya = biayaPer * bedaHari;
            lblTotal.Text = "Rp. " + totalBiaya + ",-";
        }

        private void dgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbTransaksi.Enabled = true;
            lblIdTransaksi.Text = dgvTransaksi.SelectedRows[0].Cells[0].Value.ToString();
            dtpMasuk.Value = DateTime.Parse(dgvTransaksi.SelectedRows[0].Cells[1].Value.ToString());

            if(String.IsNullOrEmpty(dgvTransaksi.SelectedRows[0].Cells[2].Value.ToString()))
            { dtpKeluar.Value = dtpMasuk.Value.AddDays(1); }
            else
            { dtpKeluar.Value = DateTime.Parse(dgvTransaksi.SelectedRows[0].Cells[2].Value.ToString()); }

            if(String.IsNullOrEmpty(dgvTransaksi.SelectedRows[0].Cells[3].Value.ToString()))
            { totalBiaya = 0; }
            else
            { totalBiaya = Convert.ToInt32(dgvTransaksi.SelectedRows[0].Cells[3].Value.ToString()); }
            
            cbIdAnggota.Text = dgvTransaksi.SelectedRows[0].Cells[4].Value.ToString();
            cbIdHewan.Text = dgvTransaksi.SelectedRows[0].Cells[5].Value.ToString();
            cbIdKandang.Text = dgvTransaksi.SelectedRows[0].Cells[6].Value.ToString();
            cbIdLayanan.Text = dgvTransaksi.SelectedRows[0].Cells[7].Value.ToString();

            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("select [Biaya Per Hari] from layanan where [ID Layanan] = '" + cbIdLayanan.Text + "'");
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                biayaPer = Convert.ToInt32(sdr["Biaya Per Hari"]);
                lblBiaya.Text = "Rp. " + biayaPer + ",-";
            }

            CON.Close();

            hitung();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("delete from transaksi where [ID Transaksi] = '" + lblIdTransaksi.Text + "'");
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Transaksi Terhapus");
            gbTransaksi.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("insert into transaksi ([Tanggal Masuk],[Tanggal Keluar],[Total Biaya],[ID Member],[ID Hewan],[ID Kandang],[ID Layanan]) values (@dtpMasuk,@dtpKeluar,'" + totalBiaya + "','" + cbIdAnggota.Text + "','" + cbIdHewan.Text + "','" + cbIdKandang.Text + "','" + cbIdLayanan.Text + "')");
            cmd.Parameters.Add("@dtpMasuk", SqlDbType.Date).Value = dtpMasuk.Value.Date;
            cmd.Parameters.Add("@dtpKeluar", SqlDbType.Date).Value = dtpKeluar.Value.Date;
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Transaksi Tersimpan");
            gbTransaksi.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("update transaksi set [Tanggal Masuk] = @dtpMasuk, [Tanggal Keluar] = @dtpKeluar, [Total Biaya] = '" + totalBiaya + "', [ID Member] = '" + cbIdAnggota.Text + "', [ID Hewan] = '" + cbIdHewan.Text + "', [ID Kandang] = '" + cbIdKandang.Text + "', [ID Layanan] = '" + cbIdLayanan.Text + "' where [ID Transaksi] = '" + lblIdTransaksi.Text + "'");
            cmd.Parameters.Add("@dtpMasuk", SqlDbType.Date).Value = dtpMasuk.Value.Date;
            cmd.Parameters.Add("@dtpKeluar", SqlDbType.Date).Value = dtpKeluar.Value.Date;
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Tansaksi Ter-Update");
            gbTransaksi.Enabled = false;
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
                cmd.CommandText = ("select * from transaksi where [" + cbKolom.Text + "] = '" + txtCari.Text + "'");
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvTransaksi.DataSource = dt;
                CON.Close();
            }
        }
    }
}