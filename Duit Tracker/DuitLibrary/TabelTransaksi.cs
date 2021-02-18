using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DuitLibrary
{
    public class TabelTransaksi
    {
        public DataTable tabelTransaksi;

        public TabelTransaksi()
        {
            tabelTransaksi = new DataTable();
            tabelTransaksi.Columns.Add("Tanggal");
            tabelTransaksi.Columns.Add("Keterangan");
            tabelTransaksi.Columns.Add("Nominal");
        }
        public void display(SortedList<int, ArusKas> daftarTransaksi)
        {
            tabelTransaksi.Rows.Clear();
            foreach(int id in daftarTransaksi.Keys)
            {
                DataRow rowTabelTransaksi = tabelTransaksi.NewRow();
                rowTabelTransaksi[0] = daftarTransaksi[id].Tanggal;
                rowTabelTransaksi[1] = daftarTransaksi[id].Keterangan;
                rowTabelTransaksi[2] = daftarTransaksi[id].Nominal;
                tabelTransaksi.Rows.Add(rowTabelTransaksi);
            }
        }
    }
}
