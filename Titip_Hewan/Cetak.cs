using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace Titip_Hewan
{
    public partial class Cetak : Form
    {
        private bool ok;

        public Cetak()
        {
            InitializeComponent();
        }

        public void titip(Beranda beranda)
        {
            ok = false;

            rtbPrint.SelectionFont = new Font("Arial", 15, FontStyle.Bold);
            rtbPrint.SelectionAlignment = HorizontalAlignment.Center;
            rtbPrint.SelectedText = "Penitipan Hewan SamSri \n -=-=-=-=-=-=-=-=-=-=-=- \n \n";

            rtbPrint.SelectionFont = new Font("Consolas", 10);
            rtbPrint.SelectionAlignment = HorizontalAlignment.Left;
            rtbPrint.SelectedText =
                "Tanggal      : " + DateTime.Today.ToString("dd-MM-yyyy") + "\n \n" +

                "ID Anggota     : " + beranda.titipIdAnggota + "\n" +
                "Nama Anggota   : " + beranda.titipNamaAnggota + "\n" +
                "-=-=-=-=-=-=-=-=- \n" +
                "Nama Hewan     : " + beranda.titipNamaHewan + "\n" +
                "-=-=-=-=-=-=-=-=- \n" +
                "Kandang        : " + beranda.titipKandang + "\n" +
                "-=-=-=-=-=-=-=-=- \n" +
                "Layanan        : " + beranda.titipLayanan() + "\n \n" +
                "Biaya per Hari : Rp. " + beranda.titipBiaya + ",- \n" +

                "Status         : BELUM DIAMBIL."
            ;
        }

        public void ambil(Beranda beranda)
        {
            ok = false;

            rtbPrint.SelectionFont = new Font("Arial", 15, FontStyle.Bold);
            rtbPrint.SelectionAlignment = HorizontalAlignment.Center;
            rtbPrint.SelectedText = "Penitipan Hewan SamSri \n -=-=-=-=-=-=-=-=-=-=-=- \n \n";

            rtbPrint.SelectionFont = new Font("Consolas", 12);
            rtbPrint.SelectionAlignment = HorizontalAlignment.Left;
            rtbPrint.SelectedText =
                "Tanggal        : " + DateTime.Today.ToString("dd-MM-yyyy") + "\n \n" +
                
                "ID Transaksi   : " + beranda.ambilIdTransaksi + "\n" +
                "-=-=-=-=-=-=-=-=- \n" +
                "ID Anggota     : " + beranda.ambilIdAnggota + "\n" +
                "Nama Anggota   : " + beranda.ambilNamaAnggota + "\n" +
                "Nama Hewan     : " + beranda.ambilNamaHewan + "\n" +
                "Kandang        : " + beranda.ambilKandang + "\n" +
                "Layanan        : " + beranda.ambilLayanan + "\n \n" +

                "Biaya per Hari : " + beranda.ambilBiaya + "\n" +
                "Total Biaya    : " + beranda.ambilTotalBiaya + "\n \n" +

                "Status         : SUDAH DIAMBIL."
            ;
        }

        private void DocumentToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(rtbPrint.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            string Line = null;
            Font PrintFont = this.rtbPrint.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(Line, PrintFont, PrintBrush, LeftMargin, YPosition, new StringFormat());
                Count++;
            }

            if (Line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            PrintBrush.Dispose();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPrint = new PrintDocument();
            printDialog.Document = documentToPrint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(rtbPrint.Text);
                documentToPrint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);
                documentToPrint.Print();

                ok = true;

                this.Close();
            }
        }

        public bool OK() { return ok; }
    }
}
