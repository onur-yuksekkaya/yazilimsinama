using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoWork
{
    public class Proje
    {
        private int _id;
        private string _projeisim;
        private string _musteri;
        private string _bilgi;
        private List<Kullanici> _sorumlular = new List<Kullanici>();
        private List<Gorev> _gorev = new List<Gorev>();


        public int Id { get { return _id; } set { _id = value; } }
        public string Projeİsmi { get { return _projeisim; } set { _projeisim = value; } }
        public string Musteri { get { return _musteri; } set { _musteri = value; } }
        public string Bilgi { get { return _bilgi; } set { _bilgi = value; } }
        public List<Kullanici> Sorumlu { get { return _sorumlular; } set { _sorumlular = value; } }
        public List<Gorev> Gorev { get { return _gorev; } set { _gorev = value; } }
    }
}
