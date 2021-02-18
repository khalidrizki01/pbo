using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuitLibrary
{
    public class TotalBulanan
    {
        int totalArusMasuk = 0;
        int totalArusKeluar = 0;
        static int saldo;

        public int TotalArusMasuk
        {
            get { return totalArusMasuk; }
            set { totalArusMasuk = value;  }
        }
        public int TotalArusKeluar
        {
            get { return totalArusKeluar; }
            set { totalArusKeluar = value ; }
        }
        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
    }
}
