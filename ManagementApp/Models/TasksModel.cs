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
        public string descTask { get; set; }
        public string funcTask { get; set; }
        public DateTime dateTask { get; set; }
        public string situacao { get; set; }

        Connection connection = new Connection();
        SqlCommand sqlCommand = new SqlCommand();
        public String msg = "";

        public void InsertTask(string descTask, string funcTask, DateTime dateTask, string situacao)
        {
            try
            {
                sqlCommand.CommandText = $"insert into tb_tasks(descTask, funcTask, dateTask, situacao, fg_ok)" +
                    $"values (@descTask, @funcTask, @dateTask, @situacao, @fg_ok)";

                // parameters
                sqlCommand.Parameters.AddWithValue("@descTask", descTask);
                sqlCommand.Parameters.AddWithValue("@funcTask", funcTask);
                sqlCommand.Parameters.AddWithValue("@dateTask", dateTask);
                sqlCommand.Parameters.AddWithValue("@situacao", situacao);
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
            catch(SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
        }

        public List<TasksModel> SelectTasks()
        {
            List<TasksModel> tasksModels = new List<TasksModel>();
            try
            {
                
                // Command Sql -- SqlCommand
                sqlCommand.CommandText = "select descTask, funcTask, dateTask, situacao from tb_tasks where fg_ok = 1";
                // connect with data -- Connection
                sqlCommand.Connection = connection.ConnectSql();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    TasksModel tasks = new TasksModel();
                    tasks.descTask = reader["descTask"].ToString();
                    tasks.funcTask = reader["funcTask"].ToString();
                    tasks.dateTask= DateTime.Parse(reader["dateTask"].ToString());
                    tasks.situacao = reader["situacao"].ToString();
                    tasksModels.Add(tasks);
                }

            }
            catch (SqlException e)
            {
                this.msg = e.Message + "Erro ao conectar-se ao banco de dados.";
            }
            return tasksModels;
        }

        public void UpdateTask(string descTask, string situacao)
        {
            try
            {
                // Command Sql -- SqlCommand
                sqlCommand.CommandText = $"update tb_tasks set situacao = @situacao where descTask=@descTask";

                // parameters
                sqlCommand.Parameters.AddWithValue("@descTask", descTask);
                sqlCommand.Parameters.AddWithValue("@situacao", situacao);

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

        public void DeleteTask(string descTask)
        {
            // Command Sql -- SqlCommand
            sqlCommand.CommandText = $"update tb_tasks set fg_ok = 0 where descTask = @descTask";

            // parameters
            sqlCommand.Parameters.AddWithValue("@descTask", descTask);
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
