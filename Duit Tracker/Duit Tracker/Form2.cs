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
    public partial class Form2 : Form
    {
        SortedList<int, DuitLibrary.ArusKas> listTrans;
        SortedList<int, DuitLibrary.Pendapatan> listTransDapat;
        SortedList<int, DuitLibrary.Pengeluaran> listTransKeluar;
        public Form2(ref SortedList<int, DuitLibrary.ArusKas> listTrans, ref SortedList<int, DuitLibrary.Pendapatan> listTransDapat, ref SortedList<int, DuitLibrary.Pengeluaran> listTransKeluar)
        {
            InitializeComponent();
            this.listTrans = listTrans;
            this.listTransDapat = listTransDapat;
            this.listTransKeluar = listTransKeluar;
        }

        private void btnPendapatan_Click(object sender, EventArgs e)
        {
            TransaksiPendapatan trPendapatan = new TransaksiPendapatan(ref listTrans, ref listTransDapat);
            trPendapatan.Show();
            this.Close();
        }

        private void btnPengeluaran_Click(object sender, EventArgs e)
        {
            TransaksiPengeluaran trPengeluaran = new TransaksiPengeluaran(ref listTrans, ref listTransKeluar);
            trPengeluaran.Show();
            this.Close();
        }
    }
}
