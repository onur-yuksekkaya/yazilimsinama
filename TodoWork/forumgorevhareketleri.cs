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
    public partial class forumgorevhareketleri : Form
    {
        public forumgorevhareketleri(int projeId)
        {
            _projeId = projeId;
            InitializeComponent();
        }

        int _projeId;

        private void frm_gorevHaareketleri_Load(object sender, EventArgs e)
        {
            VTBaglan vt = new VTBaglan();
            SqlDataAdapter da = new SqlDataAdapter("select baslik as Baslik, adi+' '+soyadi as AdSoyad, tarih as Tarih, durumAdi from tb_gorevHareket inner join tb_gorevler on tb_gorevhareket.gorevId = tb_gorevler.ID inner join tb_kullanicilar on tb_kullanicilar.ID = tb_gorevler.gorevliId inner join tb_Durum on tb_Durum.ID = tb_gorevHareket.durumId where projeId = @p1", vt.bagla());
            da.SelectCommand.Parameters.AddWithValue("@p1", _projeId);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
