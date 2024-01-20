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
    public partial class Beranda : Form
    {
        SqlConnection CON = new SqlConnection(@"Data Source=DESKTOP-NSDDQ70;Initial Catalog=titip_hewan;Integrated Security=True");
        private string idhewan, jenisHewan, mm, rawat, layanan, amm, arawat, alayanan;
        private int tbiayaTotal, aBiaya, aTotalBiaya;
        private DateTime atglMasuk, atglKeluar;

        public Beranda()
        {
            //Splash sp = new Splash(); sp.ShowDialog();
            InitializeComponent();
            this.MaximizeBox = false;
            loadCBIdAnggota(); loadCBTransaksi();
        }

        private void mExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Anda Yakin?", "Keluar Aplikasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            { this.Close(); }
        }

        private void mAnggota_Click(object sender, EventArgs e)
        {
            Anggota ang = new Anggota();
            ang.Show();
        }

        private void mHewan_Click(object sender, EventArgs e)
        {
            Hewan hewan = new Hewan();
            hewan.Show();
        }

        private void mKandang_Click(object sender, EventArgs e)
        {
            Kandang kan = new Kandang();
            kan.Show();
        }

        private void mLayanan_Click(object sender, EventArgs e)
        {
            Layanan lay = new Layanan();
            lay.Show();
        }

        private void mTransaksi_Click(object sender, EventArgs e)
        {
            Transaksi trans = new Transaksi();
            trans.Show();
        }

        private void mAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplikasi ini dibuat oleh :"
                +Environment.NewLine+ Environment.NewLine + "- Riza Awwalul Baqy (1741723004)"
                +Environment.NewLine+"- Triska Intania Sulistiyowati (1641723004)"
                ,"About");
        }

        private void rtbToolStripMenuItem_Click(object sender, EventArgs e)
        { Cetak prt = new Cetak(); prt.Show(); }

        private void loadCBIdAnggota()
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from member";
            cmd.ExecuteNonQuery();

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                tcbIdAnggota.Items.Add(sdr["ID Member"].ToString());
            }

            CON.Close();
        }

        private void tcbIdAnggota_SelectedIndexChanged(object sender, EventArgs e)
        {
            tcbNamaHewan.Enabled = true; tcbNamaHewan.Items.Clear(); tcbNamaHewan.ResetText();
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from member, hewan where member.[ID Member] = hewan.[ID Member] and hewan.[ID Member] = '" + tcbIdAnggota.Text + "' order by member.[ID Member],[Nama Hewan]";
            cmd.ExecuteNonQuery();

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                tlblNamaAnggota.Text = (sdr["Nama Member"].ToString());
                tcbNamaHewan.Items.Add(sdr["Nama Hewan"].ToString());
                jenisHewan = (sdr["Jenis Hewan"].ToString());
                idhewan = (sdr["ID Hewan"].ToString());
            }

            CON.Close();
        }
        
        private void tcbNamaHewan_SelectedIndexChanged(object sender, EventArgs e)
        {
            tcbKandang.Items.Clear(); tcbKandang.ResetText();
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kandang where [Status] like 'Kosong' and [Jenis Kandang] like '" + jenisHewan + "'";
            cmd.ExecuteNonQuery();

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            { tcbKandang.Items.Add(sdr["ID Kandang"].ToString()); }

            CON.Close();
        }

        private void refreshTitip()
        {
            idhewan = jenisHewan = mm = rawat = layanan = amm = arawat = alayanan = null;
            tbiayaTotal = aBiaya = aTotalBiaya = 0;

            tcbIdAnggota.Items.Clear(); tcbIdAnggota.ResetText(); loadCBIdAnggota();
            tcbNamaHewan.Items.Clear(); tcbNamaHewan.ResetText();
            tcbKandang.Items.Clear(); tcbKandang.ResetText();
            tcekMM.Checked = false; tcekRawat.Checked = false;
            ttxtBiaya.Clear(); ttxtLayanan.Clear();
            tlblNamaAnggota.Text = "Nama Anggota";
        }

        private void tbtnRefresh_Click(object sender, EventArgs e)
        { refreshTitip(); }

        //Tombol titip
        private void tbtnTitip_Click(object sender, EventArgs e)
        {
            int tbiaya, tbiayaRawat;
            if (tcekMM.Checked == true) { mm = "Ya"; } else { mm = "Tidak"; }
            if (tcekRawat.Checked == true) { rawat = "Ya"; tbiayaRawat = 250000; } else { rawat = "Tidak"; tbiayaRawat = 0; }
            if (string.IsNullOrEmpty(ttxtLayanan.Text)) { layanan = "-"; } else { layanan = ttxtLayanan.Text; }
            if (string.IsNullOrEmpty(ttxtBiaya.Text)) { tbiaya = 0; } else { tbiaya = Convert.ToInt32(ttxtBiaya.Text); }

            tbiayaTotal = tbiaya + tbiayaRawat;

            Cetak cetak = new Cetak(); cetak.titip(this); cetak.ShowDialog();

            if (cetak.OK())
            {
                CON.Open();

                SqlCommand cmd = CON.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("insert into layanan ([Makan & Minum],[Perawatan],[Lainnya],[Biaya Per Hari]) values ('" + mm + "','" + rawat + "','" + layanan + "','" + tbiayaTotal + "')" +
                    " insert into transaksi ([Tanggal Masuk],[ID Member],[ID Hewan],[ID Kandang],[ID Layanan]) values (@dtpMasuk,'" + tcbIdAnggota.Text + "','" + idhewan + "','" + tcbKandang.Text + "',@@IDENTITY)" +
                    " update kandang set [Status]='Terisi' where [ID Kandang]='" + tcbKandang.Text + "'");
                cmd.Parameters.Add("@dtpMasuk", SqlDbType.Date).Value = DateTime.Today;
                cmd.ExecuteNonQuery();

                CON.Close();

                MessageBox.Show("Transaksi Tersimpan");

                refreshTitip();
            }
        }
        
        private void loadCBTransaksi()
        {
            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Id Transaksi] from transaksi where [Tanggal Keluar] is null";
            cmd.ExecuteNonQuery();

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            { acbIdTransaksi.Items.Add(sdr["ID Transaksi"].ToString()); }

            CON.Close();
        }

        //Ambil data
        private void acbIdTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aBedaHari;

            CON.Open();

            SqlCommand cmd = CON.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from transaksi t, member m, hewan  h, kandang k, layanan l where t.[ID Member]=m.[ID Member] and t.[ID Hewan]=h.[ID Hewan] and t.[ID Kandang]=k.[ID Kandang] and t.[ID layanan]=l.[ID Layanan]";
            cmd.ExecuteNonQuery();

            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                alblIdAnggota.Text = (sdr["ID Member"].ToString());
                alblNamaAnggota.Text = (sdr["Nama Member"].ToString());
                alblNamaHewan.Text = (sdr["Nama Hewan"].ToString());
                alblIdKandang.Text = (sdr["ID Kandang"].ToString());
                amm = (sdr["Makan & Minum"].ToString());
                arawat = (sdr["Perawatan"].ToString());
                alayanan = (sdr["Lainnya"].ToString());
                aBiaya = Convert.ToInt32(sdr["Biaya Per Hari"].ToString());
                atglMasuk = Convert.ToDateTime(sdr["Tanggal Masuk"]);
            }

            CON.Close();

            atglKeluar = DateTime.Today;
            aBedaHari = Convert.ToInt32((atglKeluar - atglMasuk).TotalDays);
            if (aBedaHari <= 0) { atglKeluar = atglMasuk.AddDays(1); aBedaHari = 1; }

            if (amm == "Ya") { amm = "Makan dan Minum, "; } else { amm = ""; }
            if (arawat == "Ya") { arawat = "Perawatan, "; } else { arawat = ""; }
            if (alayanan == "-") { alayanan = ""; }

            atxtLayanan.Text = amm + arawat + alayanan;
            alblBiaya.Text = "Rp. " + aBiaya + "-,-";

            aTotalBiaya = aBiaya * aBedaHari;
            alblTotalBiaya.Text = "Rp. " + aTotalBiaya + "-,-";
        }

        private void refreshAmbil()
        {
            idhewan = jenisHewan = mm = rawat = layanan = amm = arawat = alayanan = null;
            tbiayaTotal = aBiaya = aTotalBiaya = 0;

            acbIdTransaksi.Items.Clear(); acbIdTransaksi.ResetText(); loadCBTransaksi();
            alblIdAnggota.Text = "ID Anggota"; alblNamaAnggota.Text = "Nama Anggota"; alblNamaHewan.Text = "Nama Hewan";
            alblIdKandang.Text = "ID Kandang"; alblBiaya.Text = "Rp. -,-"; alblTotalBiaya.Text = "Rp. -,-";
            atxtLayanan.Clear();
        }

        private void abtnRefresh_Click(object sender, EventArgs e)
        { refreshAmbil(); }

        //Tombol ambil
        private void abtnAmbil_Click(object sender, EventArgs e)
        {
            Cetak cetak = new Cetak(); cetak.ambil(this); cetak.ShowDialog();

            if(cetak.OK())
            {
                CON.Open();

                SqlCommand cmd = CON.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("update transaksi set [Tanggal Keluar] = @dtpKeluar, [Total Biaya] = '" + aTotalBiaya + "' where [ID Transaksi] = '" + acbIdTransaksi.Text + "' " +
                    " update kandang set [Status] = 'Kosong' where [ID Kandang]  = '" + alblIdKandang.Text + "'");
                cmd.Parameters.Add("@dtpKeluar", SqlDbType.Date).Value = atglKeluar;
                cmd.ExecuteNonQuery();

                CON.Close();
                refreshAmbil();
                MessageBox.Show("Transaksi Selesai!");
            }
        }

        // get set Penitipan
        public string titipIdAnggota { get { return tcbIdAnggota.Text; } set { tcbIdAnggota.Text = value; } }
        public string titipNamaAnggota { get { return tlblNamaAnggota.Text; } set { tlblNamaAnggota.Text = value; } }
        public string titipNamaHewan { get { return tcbNamaHewan.Text; } set { tcbNamaHewan.Text = value; } }
        public string titipKandang { get { return tcbKandang.Text; } set { tcbKandang.Text = value; } }
        public int titipBiaya { get { return tbiayaTotal; } set { tbiayaTotal = value; } }
        public string titipLayanan()
        {
            string titipMM, titipRawat, titipLayanan;
            if (tcekMM.Checked == true) { titipMM = "Makan & Minum "; } else { titipMM = ""; }
            if (tcekRawat.Checked == true) { titipRawat = "Perawatan "; } else { titipRawat = ""; }
            if (string.IsNullOrEmpty(ttxtLayanan.Text)) { titipLayanan = "-"; } else { titipLayanan = ttxtLayanan.Text; }
            return titipMM + titipRawat + titipLayanan;
        }

        // get set Pengambilan
        public string ambilIdTransaksi { get { return acbIdTransaksi.Text; } set { acbIdTransaksi.Text = value; } }
        public string ambilIdAnggota { get { return alblIdAnggota.Text; } set { alblIdAnggota.Text = value; } }
        public string ambilNamaAnggota { get { return alblNamaAnggota.Text; } set { alblNamaAnggota.Text = value; } }
        public string ambilNamaHewan { get { return alblNamaHewan.Text; } set { alblNamaHewan.Text = value; } }
        public string ambilKandang { get { return alblIdKandang.Text; } set { alblIdKandang.Text = value; } }
        public string ambilLayanan { get { return atxtLayanan.Text; } set { atxtLayanan.Text = value; } }
        public string ambilBiaya { get { return alblBiaya.Text; } set { alblBiaya.Text = value; } }
        public string ambilTotalBiaya { get { return alblTotalBiaya.Text; } set { alblTotalBiaya.Text = value; } }
    }
}