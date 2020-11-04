using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ManagementApp.Models
{
    class SalesModel
    {
        public string descSale { get; set; }
        public int quantitySale { get; set; }
        public double valueSale { get; set; }
        public DateTime dateSale { get; set; }
        Connection connection = new Connection();
        SqlCommand sqlCommand = new SqlCommand();
        List<SalesModel> salesModels = new List<SalesModel>();
        public String msg = "";

        public void InsertAccount(string descSl, int quantitySl, double valueSl, DateTime dateSl)
        {
            try
            {
                sqlCommand.CommandText = $"insert into tb_sales(descSale, quantitySale, valueSale, dateSale, fg_ok)" +
                    $"values (@descSale, @quantitySale, @valueSale, @dateSale, @fg_ok)";

                // parameters
                sqlCommand.Parameters.AddWithValue("@descSale", descSl);
                sqlCommand.Parameters.AddWithValue("@quantitySale", quantitySl);
                sqlCommand.Parameters.AddWithValue("@valueSale", valueSl);
                sqlCommand.Parameters.AddWithValue("@dateSale", dateSl);
                sqlCommand.Parameters.AddWithValue("@fg_ok", 1);

                //Connection
                sqlCommand.Connection = connection.ConnectSql();

                //Query
                sqlCommand.ExecuteNonQuery();

                //Deconnect
                connection.desconnect();

                //Message
                this.msg = "Cadastrada com susseco!";
            }
            catch (SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
        }

        public List<SalesModel> SelectAccounts()
        {

            try
            {
                // Command Sql -- SqlCommand
                sqlCommand.CommandText = "select descSale, quantitySale, valueSale, dateSale from tb_sales where fg_ok = 1";
                // connect with data -- Connection
                sqlCommand.Connection = connection.ConnectSql();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    SalesModel sales = new SalesModel();
                    sales.descSale = reader["descSale"].ToString();
                    sales.quantitySale = int.Parse(reader["quantitySale"].ToString());
                    sales.valueSale = double.Parse(reader["valueSale"].ToString());
                    sales.dateSale = DateTime.Parse(reader["dateAccount"].ToString());
                    salesModels.Add(sales);
                }

            }
            catch (SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
            return salesModels;
        }

        public void UpdateAccount(string descSl, int quantitySl, double valueSl, DateTime dateSl)
        {
            try
            {
                // Command Sql -- SqlCommand
                sqlCommand.CommandText = $"update tb_sales set descSale = @descSale and quantitySale = @quantitySale and valueSale = @valueSale and dateSale = @dateSale where descSale=@descSale";

                // parameters
                sqlCommand.Parameters.AddWithValue("@descSale", descSl);
                sqlCommand.Parameters.AddWithValue("@quantitySale ", quantitySl);
                sqlCommand.Parameters.AddWithValue("@valueSale", valueSl);
                sqlCommand.Parameters.AddWithValue("@dateSale", dateSl);

                // connect with data -- Connection
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

        public void DeleteAccount(string descAc)
        {
            // Command Sql -- SqlCommand
            sqlCommand.CommandText = $"update tb_sales set fg_ok = @fg_ok where descAccount = @descAccount";

            // parameters
            sqlCommand.Parameters.AddWithValue("@descAccount", descAc);
            sqlCommand.Parameters.AddWithValue("@fg_ok", 0);
            // connect with data -- Connection
            try
            {
                sqlCommand.Connection = connection.ConnectSql();

                // execute command
                sqlCommand.ExecuteNonQuery();

                // desconnect
                connection.desconnect();

                // print massege of erroe or success
                this.msg = "Tarefa excluída com sucesso!";
            }
            catch (SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
        }
    }
}
