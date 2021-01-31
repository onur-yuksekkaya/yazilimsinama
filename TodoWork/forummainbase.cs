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
    public partial class forummainbase : Form
    {
        public forummainbase()
        {
            InitializeComponent();
        }

        VTBaglan vt = new VTBaglan();
        List<Proje> _projelerim = new List<Proje>();

        private void frm_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            lbl_kullanici.Text = Kullanici._login.Adi + " " + Kullanici._login.Soyadi;
            projelerim();
        }

        
        private void projelerim()
        {
            _projelerim.Clear();
            SqlCommand c = new SqlCommand("select * from tb_projeler inner join tb_projeSorumlu on tb_projeler.ID = tb_projeSorumlu.projeID where kullaniciID = @p1", vt.bagla());
            c.Parameters.AddWithValue("@p1", Kullanici._login.Id);
            SqlDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                Proje p = new Proje();
                p.Id = Convert.ToInt16(dr[0]);
                p.Projeİsmi = dr["projeismi"].ToString();
                p.Musteri = dr["musteri"].ToString();
                p.Bilgi = dr["bilgi"].ToString();
                _projelerim.Add(p);
            }
            vt.bagla().Close();

            cmb_projeler.Items.Clear();
            foreach (Proje item in _projelerim)
            {
                cmb_projeler.Items.Add(item.Projeİsmi);
            }

            foreach (Proje pr in _projelerim)
            {
                c = new SqlCommand("select * from tb_gorevler where projeId = @p1", vt.bagla());
                c.Parameters.AddWithValue("@p1", pr.Id);
                SqlDataReader dr2 = c.ExecuteReader();
                while (dr2.Read())
                {
                    Gorev gr = new Gorev();
                    gr.Id = Convert.ToInt16(dr2["ID"]);
                    gr.Baslik = dr2["baslik"].ToString();
                    gr.Gorevli = Convert.ToInt16(dr2["gorevliId"]);
                    gr.Aciklama = dr2["aciklama"].ToString();
                    gr.Durum = Convert.ToInt16(dr2["durum"]);
                    pr.Gorev.Add(gr);

                }
                vt.bagla().Close();

            }

            foreach (Proje pr in _projelerim)
            {
                c = new SqlCommand("select * from tb_projeSorumlu inner join tb_kullanicilar on tb_projeSorumlu.kullaniciId = tb_kullanicilar.ID where projeId = @p1",vt.bagla());
                c.Parameters.AddWithValue("@p1", pr.Id);
                SqlDataReader dr3 = c.ExecuteReader();
                while(dr3.Read())
                {
                    Kullanici kl = new Kullanici();
                    kl.Id = Convert.ToInt16(dr3["kullaniciId"]);
                    kl.Adi = dr3["adi"].ToString();
                    kl.Soyadi = dr3["soyadi"].ToString();
                    kl.KullaniciAdi = dr3["kullaniciAdi"].ToString();
                    pr.Sorumlu.Add(kl);
                }
                vt.bagla().Close();
            }
        }



        private void cmb_projeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_projeler.SelectedItem != null)
            {
                grp_seciliProje.Enabled = true;
                btn_hareket.Enabled = true;
                gorevleriListele();
            }
            sureHesapla();
            
        }


        private void gorevleriListele()
        {
            list_todo.Items.Clear();
            list_progress.Items.Clear();
            list_done.Items.Clear();

            int i = cmb_projeler.SelectedIndex;
            foreach (Gorev item in _projelerim[i].Gorev)
            {   
                switch (item.Durum)
                {
                    case 1: list_todo.Items.Add(item.Baslik); break;
                    case 2: list_progress.Items.Add(item.Baslik); break;
                    case 3: list_done.Items.Add(item.Baslik); break;
                    default: break;
                }
            }   
        }

        private void btn_gorevEkle_Click(object sender, EventArgs e)
        {
            forumgorevler fg = new forumgorevler(_projelerim[cmb_projeler.SelectedIndex]);
            fg.ShowDialog();
            int i = cmb_projeler.SelectedIndex;
            projelerim();
            cmb_projeler.SelectedIndex = i;
        }

        private void btn_gorevliEkle_Click(object sender, EventArgs e)
        {
            forumgorevlipage fgl = new forumgorevlipage(_projelerim[cmb_projeler.SelectedIndex]);
            fgl.ShowDialog();
            int i = cmb_projeler.SelectedIndex;
            projelerim();
            cmb_projeler.SelectedIndex = i;
        }


        private void gorevGoruntule(string baslik)
        {
            Gorev gr = new Gorev();
            foreach (Gorev item in _projelerim[cmb_projeler.SelectedIndex].Gorev)
            {
                if (item.Baslik == baslik)
                {
                    gr = item;
                    break;
                }
            }
            forumgorevler fg = new forumgorevler(gr, _projelerim[cmb_projeler.SelectedIndex]);
            fg.ShowDialog();
        }


        #region YAPILACAKTAN YAPILIYORA TAŞINMASI
        bool surukleYapilacak = false;
        private void list_todo_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    surukleYapilacak = false; list_todo.AllowDrop = false; list_progress.AllowDrop = false;
                    break;                
                case MouseButtons.Right:
                    surukleYapilacak = true; list_todo.AllowDrop = true; list_progress.AllowDrop = true;
                    break;
                default:
                    break;
            }

            if (list_todo.SelectedItem != null && surukleYapilacak == true)
            {
                list_todo.DoDragDrop(list_todo.SelectedItem.ToString(), DragDropEffects.Copy);
            }
        }


        private void list_todo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(surukleYapilacak == false)
                gorevGoruntule(list_todo.SelectedItem.ToString());
        }


        

        private void list_progress_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && surukleYapilacak == true)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void list_progress_DragDrop(object sender, DragEventArgs e)
        {
            if (!list_progress.Items.Contains(e.Data.GetData(DataFormats.Text)))
            {
                foreach (Gorev item in _projelerim[cmb_projeler.SelectedIndex].Gorev)
                {
                    if(item.Baslik == e.Data.GetData(DataFormats.Text))
                    {
                        item.Durum = 2;
                        durumDegistir(item);
                        break;
                    }
                }
                list_progress.Items.Add(e.Data.GetData(DataFormats.Text));
                list_todo.Items.Remove(e.Data.GetData(DataFormats.Text));
                sureHesapla();
            }
        }
        #endregion


        #region YAPILIYORDAN TAMAMLANANA TAŞINMASI
        bool surukleYapiliyor = false;
        private void list_progress_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    surukleYapiliyor = false; list_progress.AllowDrop = false; list_done.AllowDrop = false;
                    break;
                case MouseButtons.Right:
                    surukleYapiliyor = true; list_progress.AllowDrop = true; list_done.AllowDrop = true;
                    break;
                default:
                    break;
            }

            if (list_progress.SelectedItem != null && surukleYapiliyor == true)
            {
                list_progress.DoDragDrop(list_progress.SelectedItem.ToString(), DragDropEffects.Copy);
            }
        }


        private void list_progress_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (surukleYapiliyor == false)
                gorevGoruntule(list_progress.SelectedItem.ToString());
        }

        private void list_done_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) && surukleYapiliyor == true)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void list_done_DragDrop(object sender, DragEventArgs e)
        {
            if (!list_done.Items.Contains(e.Data.GetData(DataFormats.Text)))
            {
                foreach (Gorev item in _projelerim[cmb_projeler.SelectedIndex].Gorev)
                {
                    if (item.Baslik == e.Data.GetData(DataFormats.Text))
                    {
                        item.Durum = 3;
                        durumDegistir(item);
                        break;
                    }
                }
                list_done.Items.Add(e.Data.GetData(DataFormats.Text));
                list_progress.Items.Remove(e.Data.GetData(DataFormats.Text));
                sureHesapla();
            }
        }

        #endregion

        private void list_done_DoubleClick(object sender, EventArgs e)
        {
            gorevGoruntule(list_done.SelectedItem.ToString());
        }


        private void durumDegistir(Gorev gorev)
        {
            SqlCommand c = new SqlCommand("insert into tb_gorevHareket (gorevId, durumId, kullaniciId, tarih) values (@p1, @p2, @p3, @p4)", vt.bagla());
            c.Parameters.AddWithValue("@p1", gorev.Id);
            c.Parameters.AddWithValue("@p2", gorev.Durum);
            c.Parameters.AddWithValue("@p3", Kullanici._login.Id);
            c.Parameters.AddWithValue("@p4", DateTime.Now);
            c.ExecuteNonQuery();
            vt.bagla().Close();

            string sorgu = "";
            if(gorev.Durum == 2)
                sorgu = "update tb_gorevler set durum = @p1, baslama = @p2 where ID= @p0";
            else if(gorev.Durum == 3)
                sorgu = "update tb_gorevler set durum = @p1, bitirme = @p2 where ID= @p0";
            c = new SqlCommand(sorgu, vt.bagla());
            c.Parameters.AddWithValue("@p1", gorev.Durum);
            c.Parameters.AddWithValue("@p2", DateTime.Now);
            c.Parameters.AddWithValue("@p0", gorev.Id);
            c.ExecuteNonQuery();
            vt.bagla().Close();
        }



        private void sureHesapla()
        {
            int tahmin = 0;
            int gecen = 0;
            SqlCommand c = new SqlCommand("select * from tb_gorevler where projeId = @p1", vt.bagla());
            c.Parameters.AddWithValue("@p1", _projelerim[cmb_projeler.SelectedIndex].Id);
            SqlDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                tahmin += OrtalamaHesapla(Convert.ToInt16(dr["gorevliId"]));
                gecen += GecenSure(Convert.ToInt16(dr["ID"]), Convert.ToInt16(dr["durum"]));
            }
            vt.bagla().Close();
            lbl_tahmin.Text = tahmin.ToString();
            lbl_gecen.Text = gecen.ToString();

            


        }

        private int OrtalamaHesapla(int sorumlu)
        {
            int kisiOrtalamasi = 0;
            SqlCommand c = new SqlCommand("select avg(DATEdiff(MINUTE, baslama, bitirme)) from tb_gorevler where bitirme is not null and gorevliID = @p1 group by gorevliID", vt.bagla());
            c.Parameters.AddWithValue("@p1", sorumlu);
            SqlDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                kisiOrtalamasi = Convert.ToInt16(dr[0]);
            }
            vt.bagla().Close();
            return kisiOrtalamasi;
        }


        private int GecenSure(int gorevId, int durum = 1)
        {
            int gecenSure = 0;
            if (durum > 1)
            {
                string sorgu = "";
                if (durum == 3)
                    sorgu = "select DATEDIFF(MINUTE, baslama, bitirme) from tb_gorevler where ID = @p1";
                else if (durum == 2)
                    sorgu = "select DATEDIFF(MINUTE, baslama, getdate()) from tb_gorevler where ID = @p1";
                SqlCommand c = new SqlCommand(sorgu, vt.bagla());
                c.Parameters.AddWithValue("@p1", gorevId);
                SqlDataReader dr = c.ExecuteReader();
                if (dr.Read())
                {
                    gecenSure = Convert.ToInt16(dr[0]);
                }
                vt.bagla().Close();
            }
            return gecenSure;
        }

        private void btn_hareket_Click(object sender, EventArgs e)
        {
            forumgorevhareketleri fgh = new forumgorevhareketleri(_projelerim[cmb_projeler.SelectedIndex].Id);
            fgh.ShowDialog();
        }

        private void lbl_gecen_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list_progress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            forumproje fpy = new forumproje();
            fpy.ShowDialog();
            projelerim();
        }
    }
}
