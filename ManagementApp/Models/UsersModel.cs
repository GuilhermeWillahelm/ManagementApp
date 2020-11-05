using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ManagementApp.Models
{
    class UsersModel
    {
        Connection connection = new Connection();
        SqlCommand sqlCommand = new SqlCommand();

        public String msg = "";

        public void InsertUser(string nameUs, string emailUs, string passUs, string nivelUs)
        {
            try
            {
                sqlCommand.CommandText = $"insert into tb_users(nameUser, email, pass, nivel, fg_ok)" +
                    $"values (@nameUser, @email, @pass, @nivel, @fg_ok)";

                // parameters
                sqlCommand.Parameters.AddWithValue("@nameUser", nameUs);
                sqlCommand.Parameters.AddWithValue("@email", emailUs);
                sqlCommand.Parameters.AddWithValue("@pass", passUs);
                sqlCommand.Parameters.AddWithValue("@nivel", nivelUs);
                sqlCommand.Parameters.AddWithValue("@fg_ok", 1);

                //Connection
                sqlCommand.Connection = connection.ConnectSql();

                //Query
                sqlCommand.ExecuteNonQuery();

                //Deconnect
                connection.desconnect();

                //Message
                this.msg = "Usuário cadastrado com sucesso!";
            }
            catch (SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
        }

        public List<SalesModel> SelectSales()
        {
            List<SalesModel> salesModels = new List<SalesModel>();
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
                    sales.dateSale = DateTime.Parse(reader["dateSale"].ToString());
                    salesModels.Add(sales);
                }

            }
            catch (SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
            return salesModels;
        }

        public void UpdateASale(string descSl, int quantitySl, double valueSl, DateTime dateSl)
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
                this.msg = "Venda atualizada com sucesso!";
            }
            catch (SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
        }

        public void DeleteSale(string descAc)
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
                this.msg = "Venda excluída com sucesso!";
            }
            catch (SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
        }
    }
}
