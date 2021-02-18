using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Duit_Tracker
{
    public partial class Form1 : Form
    {
        DuitLibrary.TotalBulanan panelTotal = new DuitLibrary.TotalBulanan();
        DataTable tabelTransaksi = new DataTable();

        // Perintah yang dikomen di bawah ini tidak jadi dipakai
        // Karena tidak menghasilkan hasil yang diharapkan.
        // Untuk ke depannya akan diperbaiki
        // agar bisa dengan benar menerapkan prinsip SOLID dan reusability

        //DuitLibrary.TabelTransaksi sejarahTransaksi = new DuitLibrary.TabelTransaksi();
        //DuitLibrary.TotalArusKas totalPendapatan = new DuitLibrary.TotalArusKas("pendapatan",0);
        //DuitLibrary.TotalArusKas totalPengeluaran = new DuitLibrary.TotalArusKas("pengeluaran",0);

        public SortedList<int, DuitLibrary.ArusKas> daftarTransaksi = new SortedList<int, DuitLibrary.ArusKas>();
        public SortedList<int, DuitLibrary.Pendapatan> daftarTransaksiPendapatan = new SortedList<int, DuitLibrary.Pendapatan>();
        public SortedList<int, DuitLibrary.Pengeluaran> daftarTransaksiPengeluaran = new SortedList<int, DuitLibrary.Pengeluaran>();
        public Form1()
        {
            InitializeComponent();
            tabelTransaksi.Columns.Add("Tanggal");
            tabelTransaksi.Columns.Add("Keterangan");
            tabelTransaksi.Columns.Add("Nominal");
            //dgvSejarahTransaksi.DataSource = sejarahTransaksi.tabelTransaksi;
            //lblNilaiKasMasuk.Text = panelTotal.TotalArusMasuk.ToString();
            //lblNilaiKasKeluar.Text = panelTotal.TotalArusKeluar.ToString();
            //lblNilaiSaldo.Text = panelTotal.Saldo.ToString();
        }

        private void btnTransaksiBaru_Click(object sender, EventArgs e)
        {
            Form2 formTipe = new Form2(ref daftarTransaksi, ref daftarTransaksiPendapatan, ref daftarTransaksiPengeluaran);
            formTipe.Show();
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //totalPendapatan.SetNominal(daftarTransaksi);
            //lblNilaiKasMasuk.Text = totalPendapatan.GetNominal().ToString();
            panelTotal.TotalArusMasuk = 0;
            foreach (DuitLibrary.Pendapatan pendapatan in daftarTransaksiPendapatan.Values)
                panelTotal.TotalArusMasuk += pendapatan.Nominal;
            lblNilaiKasMasuk.Text = panelTotal.TotalArusMasuk.ToString();

            panelTotal.TotalArusKeluar = 0;
            foreach (DuitLibrary.Pengeluaran pengeluaran in daftarTransaksiPengeluaran.Values)
                panelTotal.TotalArusKeluar += pengeluaran.Nominal;
            lblNilaiKasKeluar.Text = panelTotal.TotalArusKeluar.ToString();

            panelTotal.Saldo = panelTotal.TotalArusMasuk - panelTotal.TotalArusKeluar;
            lblNilaiSaldo.Text = panelTotal.Saldo.ToString();

            display(daftarTransaksi);
            //sejarahTransaksi.display(daftarTransaksi);
            //dgvSejarahTransaksi.DataSource = sejarahTransaksi;
        }

        public void display(SortedList<int, DuitLibrary.ArusKas> daftarTransaksi)
        {
            //tabelTransaksi.Rows.Clear();
            foreach (int id in daftarTransaksi.Keys)
            {
                DataRow rowTabelTransaksi = tabelTransaksi.NewRow();
                rowTabelTransaksi[0] = daftarTransaksi[id].Tanggal;
                rowTabelTransaksi[1] = daftarTransaksi[id].Keterangan;
                rowTabelTransaksi[2] = daftarTransaksi[id].Nominal;
                tabelTransaksi.Rows.Add(rowTabelTransaksi);
                MessageBox.Show(daftarTransaksi[id].Tanggal + daftarTransaksi[id].Keterangan + daftarTransaksi[id].Nominal);
            }

            dgvSejarahTransaksi.DataSource = tabelTransaksi;
        }

    }
}
