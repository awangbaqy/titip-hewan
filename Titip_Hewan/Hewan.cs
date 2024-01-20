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
    public partial class Hewan : Form
    {
        SqlConnection CON = new SqlConnection(@"Data Source=DESKTOP-NSDDQ70;Initial Catalog=titip_hewan;Integrated Security=True");
        private string rba, rbb;

        public Hewan()
        { InitializeComponent(); this.MaximizeBox = false; }

        private void Hewan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'titip_hewanDataSet.hewan' table. You can move, or remove it, as needed.
            this.hewanTableAdapter.Fill(this.titip_hewanDataSet.hewan);
            // TODO: This line of code loads data into the 'titip_hewanDataSet.hewan' table. You can move, or remove it, as needed.
            this.hewanTableAdapter.Fill(this.titip_hewanDataSet.hewan);
            // TODO: This line of code loads data into the 'titip_hewanDataSet.hewan' table. You can move, or remove it, as needed.
            this.hewanTableAdapter.Fill(this.titip_hewanDataSet.hewan);

            load_data();
            loadCBCari();
            loadCBAnggota();
            gbHewan.Enabled = false;
            pJenis.Enabled = false;
        }

        private void load_data()
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from hewan";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvHewan.DataSource = dt;

            CON.Close();
        }

        private void loadCBAnggota()
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [ID Member] from member";
            cmd.ExecuteNonQuery();

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            { cbID.Items.Add(sdr["ID Member"].ToString()); }

            CON.Close();
        }

        private void loadCBCari()
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name from sys.columns where object_id = object_id('hewan')";
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
            gbHewan.Enabled = true; pJenis.Enabled = true;

            lblNamaAnggota.Text = "Nama Anggota";
            lblID.Text = "ID Hewan";

            txtNama.Clear();
            txtUmur.Clear();

            txtNama.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rbAnjing.Checked) { rba = "Anjing"; } else { rba = "Kucing"; }
            if (rbJantan.Checked) { rbb = "Jantan"; } else { rbb = "Betina"; }

            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("insert into hewan([Nama Hewan],[Jenis Hewan],[Sex Hewan],[Umur Hewan],[ID Member]) values ('" + txtNama.Text + "','" + rba + "','" + rbb + "','" + txtUmur.Text + "','" + cbID.Text + "')");
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Hewan Tersimpan");
            gbHewan.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbAnjing.Checked) { rba = "Anjing"; } else { rba = "Kucing"; }
            if (rbJantan.Checked) { rbb = "Jantan"; } else { rbb = "Betina"; }

            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("update hewan set [Nama Hewan] = '" + txtNama.Text + "', [Jenis Hewan] = '" + rba + "', [Sex hewan] = '" + rbb + "', [Umur Hewan] = '" + txtUmur.Text + "' where [ID Hewan] = '" + lblID.Text + "'");
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Hewan Ter-Update");
            gbHewan.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("delete from hewan where [ID Hewan] = '" + lblID.Text + "'");
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Hewan Terhapus");
            gbHewan.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void dgvHewan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbHewan.Enabled = true; pJenis.Enabled = true;

            lblID.Text = dgvHewan.SelectedRows[0].Cells[0].Value.ToString();
            txtNama.Text = dgvHewan.SelectedRows[0].Cells[1].Value.ToString();

            rba = dgvHewan.SelectedRows[0].Cells[2].Value.ToString();
            if (rba == "Anjing") { rbAnjing.Checked = true; } else { rbKucing.Checked = true; }

            rbb = dgvHewan.SelectedRows[0].Cells[3].Value.ToString();
            if (rbb == "Jantan") { rbJantan.Checked = true; } else { rbBetina.Checked = true; }

            txtUmur.Text = dgvHewan.SelectedRows[0].Cells[4].Value.ToString();
            cbID.Text = dgvHewan.SelectedRows[0].Cells[5].Value.ToString();

            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Nama Member] from member where [ID Member] = '" + cbID.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            { lblNamaAnggota.Text = sdr[0] as string; }

            CON.Close();
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Nama Member] from member where [ID Member] = '" + cbID.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            { lblNamaAnggota.Text = sdr[0] as string; }

            CON.Close();
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
                cmd.CommandText = ("select * from hewan where [" + cbKolom.Text + "] = '" + txtCari.Text + "'");
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvHewan.DataSource = dt;
                CON.Close();
            }
        }
    }
}