using Modelo;
using Persistencia;

namespace Servico
{
    public class DisciplinaServico
    {
        private DisciplinaDAL disciplinaDAL = new DisciplinaDAL();

        public void Inserir(Disciplina disciplina)
        {
            disciplinaDAL.Inserir(disciplina);
        }
    }
}
