using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBazLibraru
{
    internal class DB
    {
        //private MySqlConnection connection;
      //  public DB()
        //{
        //    try
        //    {
        //        connection = new MySqlConnection($"server ={ip}; port=3306;username=root; database = kursovaa");
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Возникли проблемы при подключении к серверу");
        //        throw;
        //    }
        
       MySqlConnection con = new MySqlConnection("server=localhost;port=3306;username=root;password=; database = kursovaa"); 
        public void open () // открывает соединение с базой данных
        {
            if(con.State == System.Data.ConnectionState.Closed)
                con.Open ();
        }

        public void close() //прерывает соединение с бд
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
        public MySqlConnection getConnection () //возвращает соединение с бд
        {
            return con;
        }
    }
}
