using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TodoWork
{
    public partial class forumkayitpage : Form
    {
        public forumkayitpage()
        {
            InitializeComponent();
        }

        VTBaglan vt = new VTBaglan();

       

        private void kayitOl(Kullanici _kullanici)
        {
            if (tekrarKayit(_kullanici.KullaniciAdi))
            {
                SqlCommand c = new SqlCommand("insert into tb_kullanicilar (kullaniciAdi,adi,soyadi,parola) values (@p1, @p2, @p3, @p4)", vt.bagla());
                c.Parameters.AddWithValue("@p1", _kullanici.KullaniciAdi);
                c.Parameters.AddWithValue("@p2", _kullanici.Adi);
                c.Parameters.AddWithValue("@p3", _kullanici.Soyadi);
                c.Parameters.AddWithValue("@p4", _kullanici.Parola);
                c.ExecuteNonQuery();
                vt.bagla().Close();
            }
        }


        private bool tekrarKayit(string kullanciAdi)
        {
            bool onay = true;
            SqlCommand c = new SqlCommand("select ID from tb_kullanicilar where kullaniciAdi = @p1", vt.bagla());
            c.Parameters.AddWithValue("@p1", kullanciAdi);
            SqlDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                onay = false;
            }
            vt.bagla().Close();
            return onay;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KayitOlBtn_Click(object sender, EventArgs e)
        {
            bool kontrol = true;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    if (String.IsNullOrEmpty(t.Text))
                    {
                        kontrol = false;
                        break;
                    }
                }
            }

            if (kontrol == false)
            {
                MessageBox.Show("Boş alanları doldurunuz", "Dikat", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                if (SifreTxt.Text.Trim() == SifreTxtTekrar.Text.Trim())
                {
                    Kullanici ku = new Kullanici();
                    ku.Adi = AdTxt.Text.Trim();
                    ku.Soyadi = soyadTxt.Text.Trim();
                    ku.KullaniciAdi = KullaniciAdiTxt.Text.Trim();
                    ku.Parola = SifreTxt.Text.Trim();
                    kayitOl(ku);

                    MessageBox.Show("Kullanıcı kayıt edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Şifreler aynı değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
