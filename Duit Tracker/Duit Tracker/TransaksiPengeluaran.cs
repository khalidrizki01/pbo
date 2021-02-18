using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duit_Tracker
{
    public partial class TransaksiPengeluaran : Form
    {
        SortedList<int, DuitLibrary.ArusKas> listTrans;
        SortedList<int, DuitLibrary.Pengeluaran> listTransKeluar;
        public TransaksiPengeluaran(ref SortedList<int, DuitLibrary.ArusKas> listTrans, ref SortedList<int, DuitLibrary.Pengeluaran> listTransKeluar)
        {
            InitializeComponent();
            this.listTrans = listTrans;
            this.listTransKeluar = listTransKeluar;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DuitLibrary.Pengeluaran pengeluaranBaru = new DuitLibrary.Pengeluaran();
            try
            {
                pengeluaranBaru.Nominal = Convert.ToInt32(txtNominal.Text);
                pengeluaranBaru.Keterangan = txtKeterangan.Text;
                pengeluaranBaru.Tanggal = dtpTanggal.Value.ToString("yyyy-MM-dd");
                pengeluaranBaru.SetID(listTransKeluar.Count);
            }
            catch(FormatException E)
            {
                MessageBox.Show("Mohon memasukkan nominal yang benar.");
            }

            listTransKeluar.Add(pengeluaranBaru.GetID(), pengeluaranBaru);

            DuitLibrary.ArusKas arusKasBaru;
            if (pengeluaranBaru is DuitLibrary.ArusKas)
            {
                arusKasBaru = (DuitLibrary.ArusKas)pengeluaranBaru;

            //    MessageBox.Show("berhasil membuat arusKas" + pengeluaranBaru.Nominal + " " + pengeluaranBaru.Keterangan + " " + pengeluaranBaru.Tanggal + " " + pengeluaranBaru.GetID());
            }
            else
                MessageBox.Show("Gagal menambahkan transaksi");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
