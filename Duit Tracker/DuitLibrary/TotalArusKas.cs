using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DuitLibrary
{
    public class TotalArusKas
    {
        int nominal;
        string tipe;
        public TotalArusKas(string tipe, int nominalAwal)
        {
            nominal = nominalAwal;
            this.tipe = tipe;
        }
        public void SetNominal(SortedList<int, ArusKas> daftarArusKas) 
        {
            nominal = 0;
            foreach (int id in daftarArusKas.Keys)
            { 
                if(daftarArusKas[id].Tipe == this.tipe)
                    this.nominal += daftarArusKas[id].Nominal;
            }
        }
        public int GetNominal()
        {
            return nominal;
        }
        public static int operator-(TotalArusKas totalArusKasMasuk, TotalArusKas totalArusKasKeluar)
        {
            int nominalBaru = totalArusKasMasuk.GetNominal() - totalArusKasKeluar.GetNominal();
            return nominalBaru;
        }

    }
}
