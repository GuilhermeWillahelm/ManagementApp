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
        public void ConnectSql()
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=DESKTOP-00DCH3V\SQLEXPRESS;Initial Catalog=Teste;User ID=sa;Password=code123";
                cnn = new SqlConnection(connetionString); 
                cnn.Open();
                Console.WriteLine("Connection Open !" + cnn.ToString());
                cnn.Close();
            }
            catch (SqlException erro)
            {
                Console.WriteLine("Erro ao se conectar no banco de dados \n" + "Verifique os dados informados " + erro);
            }

        }
    }
}
