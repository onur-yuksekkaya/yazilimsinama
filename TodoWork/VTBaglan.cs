using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TodoWork
{
    class VTBaglan
    {
        public SqlConnection bagla()
        {
            SqlConnection bagla = new SqlConnection(@"Data Source=DESKTOP-JIG192K;Initial Catalog=isTakip;Integrated Security=True");
            bagla.Open();
            return bagla;
        }
    }
}
