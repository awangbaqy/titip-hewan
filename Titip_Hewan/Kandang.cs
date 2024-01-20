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
    public partial class Kandang : Form
    {
        SqlConnection CON = new SqlConnection(@"Data Source=DESKTOP-NSDDQ70;Initial Catalog=titip_hewan;Integrated Security=True");
        private string rba, rbs;

        public Kandang()
        { InitializeComponent(); this.MaximizeBox = false; }

        private void Kandang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'titip_hewanDataSet.kandang' table. You can move, or remove it, as needed.
            this.kandangTableAdapter.Fill(this.titip_hewanDataSet.kandang);
            // TODO: This line of code loads data into the 'titip_hewanDataSet.kandang' table. You can move, or remove it, as needed.
            this.kandangTableAdapter.Fill(this.titip_hewanDataSet.kandang);
            load_data();
            loadCBCari();
            gbKandang.Enabled = false;
        }

        private void load_data()
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kandang";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvKandang.DataSource = dt;

            CON.Close();
        }

        private void loadCBCari()
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name from sys.columns where object_id = object_id('kandang')";
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
            gbKandang.Enabled = true; pStatus.Enabled = true; txtIDKandang.Visible = true;

            lblIDKandang.Text = "KA";
            rbAnjing.Checked = true;
            rbAnjing.Enabled = true; rbKucing.Enabled = true;
            rbKosong.Checked = true;
            txtCari.Clear();
            txtCari.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rbAnjing.Checked) { rba = "Anjing"; } else { rba = "Kucing"; }
            if (rbKosong.Checked) { rbs = "Kosong"; } else { rbs = "Terisi"; }

            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("insert into kandang values ('" + lblIDKandang.Text+txtIDKandang.Text + "','" + rba + "','" + rbs + "')");
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Kandang Tersimpan");
            gbKandang.Enabled = false; txtIDKandang.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbAnjing.Checked) { rba = "Anjing"; } else { rba = "Kucing"; }
            if (rbKosong.Checked) { rbs = "Kosong"; } else { rbs = "Terisi"; }

            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("update kandang set [Jenis Kandang] = '" + rba + "', [Status] = '" + rbs + "' where [ID Kandang] = '" + lblIDKandang.Text + "'");
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Kandang Ter-Update");
            gbKandang.Enabled = false; rbAnjing.Enabled = true; rbKucing.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("delete from kandang where [ID Kandang] = '" + lblIDKandang.Text + "'");
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Kandang Terhapus");
            gbKandang.Enabled = false; rbAnjing.Enabled = true; rbKucing.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void rbAnjing_Click(object sender, EventArgs e)
        {
            if (txtIDKandang.Visible == true)
            {
                lblIDKandang.Text = "KA";
                CON.Open();
                SqlCommand cmd = CON.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("select * from kandang where [ID Kandang] like '" + lblIDKandang.Text + "%' order by [ID Kandang]");
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvKandang.DataSource = dt;
                CON.Close();
            }
        }

        private void rbKucing_Click(object sender, EventArgs e)
        {
            if (txtIDKandang.Visible == true)
            { 
                lblIDKandang.Text = "KB";
                CON.Open();
                SqlCommand cmd = CON.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("select * from kandang where [ID Kandang] like '" + lblIDKandang.Text + "%' order by [ID Kandang]");
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvKandang.DataSource = dt;
                CON.Close();
            }
        }

        private void kandangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kandangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.titip_hewanDataSet);

        }

        private void dgvKandang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gbKandang.Enabled = true; txtIDKandang.Visible = false;

            lblIDKandang.Text = dgvKandang.SelectedRows[0].Cells[0].Value.ToString();
            rba = dgvKandang.SelectedRows[0].Cells[1].Value.ToString();
            if (rba == "Anjing")
            { rbAnjing.Checked = true; rbAnjing.Enabled = true; rbKucing.Enabled = false; }
            else
            { rbKucing.Checked = true; rbAnjing.Enabled = false; rbKucing.Enabled = true; }

            rbs = dgvKandang.SelectedRows[0].Cells[2].Value.ToString();
            if (rbs == "Kosong") { rbKosong.Checked = true; } else { rbTerisi.Checked = true; }
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
                cmd.CommandText = ("select * from kandang where [" + cbKolom.Text + "] = '" + txtCari.Text + "'");
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvKandang.DataSource = dt;
                CON.Close();
            }
        }
    }
}