using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ManagementApp.Models
{
    class ProductModel
    {
        Connection connection = new Connection();
        SqlCommand sqlCommand = new SqlCommand();
        public String msg = "";

        public void InsertProduct(int codProd, string nameProd,  string brandProd, double priceProd,int quantityProd)
        {
            // Command Sql -- SqlCommand
            sqlCommand.CommandText = $"insert into tb_products(cdProduct, nameProd, brandProd, priceProd, quantityProd) " +
                $"values (@cdProduct, @nameProd, @brandProd, @priceProd, @quantityProd)";

            // parameters
            sqlCommand.Parameters.AddWithValue("@cdProduct", codProd);
            sqlCommand.Parameters.AddWithValue("@nameProd",nameProd);
            sqlCommand.Parameters.AddWithValue("@brandProd", brandProd);
            sqlCommand.Parameters.AddWithValue("@priceProd", priceProd);
            sqlCommand.Parameters.AddWithValue("@quantityProd", quantityProd);

            // connect with data -- Connection
            try 
            {
                sqlCommand.Connection = connection.ConnectSql();

                // execute command
                sqlCommand.ExecuteNonQuery();

                // desconnect
                connection.desconnect();

                // print massege of erroe or success
                this.msg = "Cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
        }
    }
}
