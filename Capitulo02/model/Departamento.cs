using System.Collections.Generic;
using System.Linq;

namespace Capitulo02.model
{
    public class Departamento
    {
        public string Nome { get; set; }
        public IList<Curso> Cursos { get; } = new List<Curso>();

        public void RegistrarCurso(Curso c)
        {
            Cursos.Add(c);
        }

        public int ObterQunatidadeDeCursos()
        {
            return Cursos.Count;
        }

        public Curso ObterCursosPorIndice(int indice)
        {
            return Cursos[indice];
        }

        public void FecharDepartamento()
        {
            while (Cursos.Count > 0)
            {
                Cursos.RemoveAt(0);
            }
        }

        public Curso ObterCursoPorNome(string nome)
        {
            return Cursos.Where<Curso>(n => n.Nome.Equals(nome)).FirstOrDefault();
        }
    }
}
