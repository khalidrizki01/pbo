using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DuitLibrary
{
    public class ArusKas
    {
        protected int id = 0;
        int nominal;
        string tipe;
        string keterangan;
        string tanggal;

        public int GetID()
        {
            return id;
        }
        public void SetID(int panjangDaftarArusKas)
        {
            //Membuat ID berdasarkan tanggal terjadinya arus kas dan 
            //seberapa banyak objek yang telah diinstance
            char[] tanggalChar = tanggal.ToCharArray(2, 8);
            char[] tempID = new char[6];
            tempID[0] = tanggalChar[0];
            tempID[1] = tanggalChar[1];
            tempID[2] = tanggalChar[3];
            tempID[3] = tanggalChar[4];
            tempID[4] = tanggalChar[6];
            tempID[5] = tanggalChar[7];

            string tempID2 = new string(tempID);
            int tempID3 = Convert.ToInt32(tempID2);
            id = id + tempID3* 1000 + panjangDaftarArusKas* 10;
        }
        public int Nominal
        {
            get { return nominal; }
            set { nominal = value; }
        }

        public string Tipe
        {
            get { return tipe; }
            set { tipe = value; }
        }
        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }
        public string Tanggal
        {
            get { return tanggal; }
            set { tanggal = value; }
        }
    }
}
