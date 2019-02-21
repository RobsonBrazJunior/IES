using Modelo;
using Persistencia;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Servico
{
    public class DisciplinaServico
    {
        private DisciplinaDAL disciplinaDAL;

        public DisciplinaServico(SqlConnection connection)
        {
            disciplinaDAL = new DisciplinaDAL(connection);
        }

        public void Inserir(Disciplina disciplina)
        {
            disciplinaDAL.Inserir(disciplina);
        }

        public List<Disciplina> ObterTodas()
        {
            return disciplinaDAL.ObterTodas();
        }
    }
}
