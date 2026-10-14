using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class KişiGrişi
    {
        public int kisiId { get; set; }
        public string KisiAdi { get; set; }
        public string KisiSoyadi { get; set; }
        public string TelNo1 { get; set; }
        public string TelNo2 { get; set; }
        public string Mail { get; set; }
        public string Unvan { get; set; }

        KişiGrişi veritabanibaglantisi;
        SqlConnection baglanti;
        SqlCommand komut;
        public KişiGrişi()
        {
            veritabanibaglantisi = new KişiGrişi();
            baglanti = veritabanibaglantisi.baglan();
            komut = new SqlCommand();
            komut.Connection = baglanti;

        }
        public void kisiekle()
        {

        }
        public void kisiyiguncelle()
        {

        }
        public void kisisil()
        {

        }
        public DataTable kisilerilistele()
        {

        }
        public DataTable kisiara()
        {

        }
    }
}
