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

        public int codProduct { get; set; }
        public string nameProduct { get; set; }
        public string brandProduct { get; set; }
        public double priceProduct { get; set; }
        public int quantityProduct { get; set; }
        Connection connection = new Connection();
        SqlCommand sqlCommand = new SqlCommand();
        public String msg = "";

        public void InsertProduct(int codProd, string nameProd,  string brandProd, double priceProd,int quantityProd)
        {
            // Command Sql -- SqlCommand
            sqlCommand.CommandText = $"insert into tb_products(cdProduct, nameProd, brandProd, priceProd, quantityProd, fg_ok) " +
                $"values (@cdProduct, @nameProd, @brandProd, @priceProd, @quantityProd, @fg_ok)";

            // parameters
            sqlCommand.Parameters.AddWithValue("@cdProduct", codProd);
            sqlCommand.Parameters.AddWithValue("@nameProd",nameProd);
            sqlCommand.Parameters.AddWithValue("@brandProd", brandProd);
            sqlCommand.Parameters.AddWithValue("@priceProd", priceProd);
            sqlCommand.Parameters.AddWithValue("@quantityProd", quantityProd);
            sqlCommand.Parameters.AddWithValue("@fg_ok", 1);

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

        public void UpdateProduct(int codProd, string nameProd, string brandProd, double priceProd, int quantityProd)
        {
            // Command Sql -- SqlCommand
            sqlCommand.CommandText = $"update tb_products set values(cdProduct, nameProd, brandProd, priceProd, quantityProd, fg_ok) " +
                $"values (@cdProduct, @nameProd, @brandProd, @priceProd, @quantityProd, @fg_ok) where idProduct={codProd}";

            // parameters
            sqlCommand.Parameters.AddWithValue("@cdProduct", codProd);
            sqlCommand.Parameters.AddWithValue("@nameProd", nameProd);
            sqlCommand.Parameters.AddWithValue("@brandProd", brandProd);
            sqlCommand.Parameters.AddWithValue("@priceProd", priceProd);
            sqlCommand.Parameters.AddWithValue("@quantityProd", quantityProd);
            sqlCommand.Parameters.AddWithValue("@fg_ok", 1);

            // connect with data -- Connection
            try
            {
                sqlCommand.Connection = connection.ConnectSql();

                // execute command
                sqlCommand.ExecuteNonQuery();

                // desconnect
                connection.desconnect();

                // print massege of erroe or success
                this.msg = "Atualizado com sucesso!";
            }
            catch (SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
        }

        public List<ProductModel> SelectProducts()
        {

            List<ProductModel> productsList = new List<ProductModel>();
            // Command Sql -- SqlCommand
            sqlCommand.CommandText = "select * from tb_products";


            // connect with data -- Connection
            try
            {
                sqlCommand.Connection = connection.ConnectSql();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    ProductModel product = new ProductModel();
                    product.codProduct = Convert.ToInt32(reader["cdProduct"].ToString());
                    product.nameProduct = reader["nameProd"].ToString();
                    product.brandProduct = reader["brandProd"].ToString();
                    product.priceProduct = Convert.ToDouble(reader["priceProd"].ToString());
                    product.quantityProduct = Convert.ToInt32(reader["quantityProd"].ToString());

                    productsList.Add(product);

                    
                }

                return productsList;


                // print massege of erroe or success
                this.msg = "Atualizado com sucesso!";
            }
            catch (SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
            return productsList;
        }
    }
}
