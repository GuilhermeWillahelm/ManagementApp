using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ManagementApp.Models
{
    class AccountsModel
    {
        public string descAccount { get; set; }
        public double valueAccount { get; set; }
        public DateTime dateAccount { get; set; }
        public string situacaoAc { get; set; }

        Connection connection = new Connection();
        SqlCommand sqlCommand = new SqlCommand();
        public String msg = "";

        public void InsertAccount(string descAc, double valueAc, DateTime dateAc, string situacaoAc)
        {
            try
            {
                sqlCommand.CommandText = $"insert into tb_accounts(descAccount, valueAccount, dateAccount, situacaoAc, fg_ok)" +
                    $"values (@descAccount, @valueAccount, @dateAccount, @situacaoAc, @fg_ok)";

                // parameters
                sqlCommand.Parameters.AddWithValue("@descAccount", descAc);
                sqlCommand.Parameters.AddWithValue("@valueAccount", valueAc);
                sqlCommand.Parameters.AddWithValue("@dateAccount", dateAc);
                sqlCommand.Parameters.AddWithValue("@situacaoAc", situacaoAc);
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

        public List<AccountsModel> SelectAccounts()
        {
            List<AccountsModel> accountsModels = new List<AccountsModel>();
            try
            {
                // Command Sql -- SqlCommand
                sqlCommand.CommandText = "select descAccount, valueAccount, dateAccount, situacaoAc from tb_accounts where fg_ok = 1";
                // connect with data -- Connection
                sqlCommand.Connection = connection.ConnectSql();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    AccountsModel accounts = new AccountsModel();
                    accounts.descAccount= reader["descAccount"].ToString();
                    accounts.valueAccount = double.Parse(reader["valueAccount"].ToString());
                    accounts.dateAccount = DateTime.Parse(reader["dateAccount"].ToString());
                    accounts.situacaoAc = reader["situacaoAc"].ToString();
                    accountsModels.Add(accounts);
                }

            }
            catch (SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
            return accountsModels;
        }

        public void UpdateAccount(string descAc, double valueAc, DateTime dateAc, string situacaoAc)
        {
            try
            {
                // Command Sql -- SqlCommand
                sqlCommand.CommandText = $"update tb_accounts set descAccount = @descAccount and valueAccount = @valueAccount and dateAccount = @dateAccount and situacaoAc = @situacaoAc where descAccount=descAccount";

                // parameters
                sqlCommand.Parameters.AddWithValue("@descAccount", descAc);
                sqlCommand.Parameters.AddWithValue("@valueAccount", valueAc);
                sqlCommand.Parameters.AddWithValue("@dateAccount", dateAc);
                sqlCommand.Parameters.AddWithValue("@situacaoAc", situacaoAc);

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
            sqlCommand.CommandText = $"update tb_accounts set fg_ok = 0 where descAccount = @descAccount";

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
