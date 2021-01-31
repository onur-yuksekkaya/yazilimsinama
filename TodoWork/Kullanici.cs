using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoWork
{
    public class Kullanici
    {
        public static Kullanici _login;

        private int _id;
        private string _adi;
        private string _soyadi;
        private string _kullaniciAdi;
        private string _parola;


        public int Id { get { return _id; } set { _id = value; } }
        public string Adi { get { return _adi; } set { _adi = value; } }
        public string Soyadi { get { return _soyadi; } set { _soyadi = value; } }
        public string KullaniciAdi { get { return _kullaniciAdi; } set { _kullaniciAdi = value; } }
        public string Parola { get { return _parola; } set { _parola = sifrele(value); } }



        private string sifrele(string parola)
        {
            Sifreleme srf = new Sifreleme();
            return srf.RijndaelSifrele(parola);
        }
    }
}
