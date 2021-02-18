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
    public partial class TransaksiPendapatan : Form
    {
        SortedList<int, DuitLibrary.ArusKas> listTrans;
        SortedList<int, DuitLibrary.Pendapatan> listTransDapat;
        public TransaksiPendapatan(ref SortedList<int, DuitLibrary.ArusKas> listTrans, ref SortedList<int, DuitLibrary.Pendapatan> listTransDapat)
        {
            InitializeComponent();
            this.listTrans = listTrans;
            this.listTransDapat = listTransDapat;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            DuitLibrary.Pendapatan pendapatanBaru = new DuitLibrary.Pendapatan();
            try
            {
                pendapatanBaru.Nominal = Convert.ToInt32(txtNominal.Text);
                pendapatanBaru.Keterangan = txtKeterangan.Text;
                pendapatanBaru.Tanggal = dtpTanggal.Value.ToString("yyyy-MM-dd");
                pendapatanBaru.SetID(listTransDapat.Count);
            }
            catch(FormatException E)
            {
                MessageBox.Show("Mohon memasukkan nominal yang benar.");
            }

            
            listTransDapat.Add(pendapatanBaru.GetID(), pendapatanBaru);

            
            DuitLibrary.ArusKas arusKasBaru;
            if (pendapatanBaru is DuitLibrary.ArusKas)
            {
                arusKasBaru = (DuitLibrary.ArusKas)pendapatanBaru;
            //    MessageBox.Show("berhasil membuat arusKas"+pendapatanBaru.Nominal + " " + pendapatanBaru.Keterangan + " " + pendapatanBaru.Tanggal + " " + pendapatanBaru.GetID());
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
