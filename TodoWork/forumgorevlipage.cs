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
    public partial class forumgorevlipage : Form
    {
        public forumgorevlipage(Proje proje)
        {
            _proje = proje;
            InitializeComponent();
        }

        Proje _proje;
        List<Kullanici> tumKullanicilar = new List<Kullanici>();
        VTBaglan vt = new VTBaglan();

        private void frm_gorevli_Load(object sender, EventArgs e)
        {
            SqlCommand c = new SqlCommand("select * from tb_kullanicilar", vt.bagla());
            SqlDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                Kullanici kl = new Kullanici();
                kl.Id = Convert.ToInt16(dr["ID"]);
                kl.Adi = dr["adi"].ToString();
                kl.Soyadi = dr["soyadi"].ToString();
                kl.KullaniciAdi = dr["kullaniciAdi"].ToString();
                tumKullanicilar.Add(kl);
            }
            vt.bagla().Close();

            int top = 25;
            int left = 25;
            foreach (Kullanici item in tumKullanicilar)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.KullaniciAdi;
                cb.Top = top;
                cb.Left = left;
                cb.Checked = projeSorumlusu(item.Id);                
                panel1.Controls.Add(cb);
                top += 25;
            }            
        }



        private bool projeSorumlusu(int id)
        {
            bool onay = false;
            SqlCommand c = new SqlCommand("select * from tb_projeSorumlu where projeId = @p1 and kullaniciId = @p2",vt.bagla());
            c.Parameters.AddWithValue("@p1", _proje.Id);
            c.Parameters.AddWithValue("@p2", id);
            SqlDataReader dr = c.ExecuteReader();
            if(dr.Read())
            {
                onay = true;
            }

            return onay;
        }

      

        private void SayacBtn_Click(object sender, EventArgs e)
        {
            SqlCommand c = new SqlCommand("delete from tb_projeSorumlu where projeId = @p1", vt.bagla());
            c.Parameters.AddWithValue("@p1", _proje.Id);
            c.ExecuteNonQuery();
            vt.bagla().Close();

            int i = 0;
            foreach (CheckBox item in panel1.Controls)
            {
                if (item.Checked == true)
                {
                    c = new SqlCommand("insert into tb_projeSorumlu (projeId, kullaniciId) values (@p1, @p2)", vt.bagla());
                    c.Parameters.AddWithValue("@p1", _proje.Id);
                    c.Parameters.AddWithValue("@p2", tumKullanicilar[i].Id);
                    c.ExecuteNonQuery();
                    vt.bagla().Close();
                }
                i++;
            }

            MessageBox.Show("Seçili kişiler projeye dahil edildi");
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
