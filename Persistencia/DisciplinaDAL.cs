using Modelo;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistencia
{
    public class DisciplinaDAL
    {
        private SqlConnection connection;

        public DisciplinaDAL(SqlConnection connection)
        {
            this.connection = connection;
        }

        //public List<Disciplina> Repository { get; set; } = new List<Disciplina>();

        public void Inserir (Disciplina disciplina)
        {
            this.connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into DISCIPLINAS(nome, cargahoraria) values(@nome, @cargahoraria)";
            command.Parameters.AddWithValue("@cargahoraria", disciplina.CargaHoraria);
            command.ExecuteNonQuery();
            this.connection.Close();
        }

        public List<Disciplina> ObterTodas()
        {
            List<Disciplina> disciplinas = new List<Disciplina>();
            var command = new SqlCommand("select disciplinaid, nome, cargahoraria from DISCIPLINAS", connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var disciplina = new Disciplina();
                    disciplina.DisciplinaID = reader.GetInt32(0);
                    disciplina.Nome = reader.GetString(1);
                    disciplina.CargaHoraria = reader.GetInt32(2);
                    disciplinas.Add(disciplina);                    
                }
            }
            connection.Close();
            return disciplinas;
        }
    }
}
