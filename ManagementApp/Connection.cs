using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ManagementApp
{
    class Connection
    {
        SqlConnection con;
        public SqlConnection ConnectSql()
        {
            try
            {

                string connetionString;
                connetionString = @"Data Source=DESKTOP-00DCH3V\SQLEXPRESS;Initial Catalog=ERP;User ID=sa;Password=code123";
                con = new SqlConnection(connetionString);
                con.Open();
                Console.WriteLine("Connection Open !" + con.ToString());
            }
            catch (SqlException erro)
            {
                Console.WriteLine("Erro ao se conectar no banco de dados \n" + "Verifique os dados informados " + erro);
            }
            return con;

        }

        /*
        public SqlConnection connect()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        */
        public void desconnect()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
