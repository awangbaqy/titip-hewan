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
    public partial class Anggota : Form
    {
        SqlConnection CON = new SqlConnection(@"Data Source=DESKTOP-NSDDQ70;Initial Catalog=titip_hewan;Integrated Security=True");
        private string rb;

        public Anggota()
        { InitializeComponent(); this.MaximizeBox = false; }

        private void Anggota_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'titip_hewanDataSet.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.titip_hewanDataSet.member);
            // TODO: This line of code loads data into the 'titip_hewanDataSet.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.titip_hewanDataSet.member);

            load_data();
            loadCBCari();
            gb_Anggota.Enabled = false;
        }

        private void load_data()
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from member";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_Anggota.DataSource = dt;
            CON.Close();
        }

        private void loadCBCari()
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name from sys.columns where object_id = object_id('member')";
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            cb_Kolom.DisplayMember = "name";
            cb_Kolom.ValueMember = "name";
            cb_Kolom.DataSource = ds.Tables[0];

            CON.Close();
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            gb_Anggota.Enabled = true;
            lbl_Id.Text = "ID Anggota";
            
            txt_Nama.Clear();
            txt_HP.Clear();
            txt_Alamat.Clear();

            txt_Nama.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(rb_L.Checked)
            { rb = "Laki-laki"; } else { rb = "Perempuan"; }

            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("insert into member([Nama Member],[No. HP],[Alamat Member],[Sex Member]) values ('" + txt_Nama.Text + "','" + txt_HP.Text + "','" + txt_Alamat.Text + "','" + rb + "')");
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Anggota Tersimpan");
            gb_Anggota.Enabled = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (rb_L.Checked)
            { rb = "Laki-laki"; }
            else { rb = "Perempuan"; }

            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("update member set [Nama Member] = '" + txt_Nama.Text + "', [No. HP] = '" + txt_HP.Text + "', [Alamat Member] = '" + txt_Alamat.Text + "', [Sex Member] = '" + rb + "' where [ID Member] = '" + lbl_Id.Text + "'");
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Anggota Ter-Update");
            gb_Anggota.Enabled = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("delete from member where [ID Member] = '" + lbl_Id.Text + "'");
            cmd.ExecuteNonQuery();
            CON.Close();
            load_data();
            MessageBox.Show("Data Anggota Terhapus");
            gb_Anggota.Enabled = false;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btn_Cari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Cari.Text))
            { load_data(); }
            else
            {
                CON.Open();
                SqlCommand cmd = CON.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("select * from member where [" + cb_Kolom.Text + "] = '" + txt_Cari.Text + "'");
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_Anggota.DataSource = dt;
                CON.Close();
            }
        }

        private void dgv_Anggota_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            gb_Anggota.Enabled = true;

            lbl_Id.Text = dgv_Anggota.SelectedRows[0].Cells[0].Value.ToString();
            txt_Nama.Text = dgv_Anggota.SelectedRows[0].Cells[1].Value.ToString();
            txt_HP.Text = dgv_Anggota.SelectedRows[0].Cells[2].Value.ToString();
            txt_Alamat.Text = dgv_Anggota.SelectedRows[0].Cells[3].Value.ToString();
            rb = dgv_Anggota.SelectedRows[0].Cells[4].Value.ToString();
            if (rb == "Perempuan")
            { rb_P.Checked = true; rb_L.Checked = false; }
            else
            { rb_L.Checked = true; rb_P.Checked = false; }
        }
    }
}