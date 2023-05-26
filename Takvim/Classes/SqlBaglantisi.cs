using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Takvim.Classes
{
    class SqlBaglantisi
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-LNMPQIK9;Initial Catalog=takvim;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
