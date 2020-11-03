using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp.Models
{
    class TasksModel
    {
        Connection connection = new Connection();
        SqlCommand sqlCommand = new SqlCommand();
        public String msg = "";

        public void InsertTask(string descTask, string funcTask, DateTime dateTask, string fg_ok)
        {
            try
            {
                sqlCommand.CommandText = $"insert into tb_tasks(descTask, funcTask, dateTask, fg_ok)" +
                    $"values (@descTask, @funcTask, @dateTask, @fg_ok)";

                // parameters
                sqlCommand.Parameters.AddWithValue("@descTask", descTask);
                sqlCommand.Parameters.AddWithValue("@funcTask", funcTask);
                sqlCommand.Parameters.AddWithValue("@dateTask", dateTask);
                sqlCommand.Parameters.AddWithValue("@fg_ok", fg_ok);

                //Connection
                sqlCommand.Connection = connection.ConnectSql();

                //Query
                sqlCommand.ExecuteNonQuery();

                //Deconnect
                connection.desconnect();

                //Message
                this.msg = "Cadastrada com susseco!";
            }
            catch(SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
        }
    }
}
