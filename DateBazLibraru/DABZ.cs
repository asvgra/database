MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBazLibraru
{
    internal class DABZ
    {
        MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=; database = kursovaa; Convert Zero Datetime=True");
 
    }
}
