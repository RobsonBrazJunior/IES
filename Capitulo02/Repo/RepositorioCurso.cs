using Capitulo02.model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Capitulo02.Repo
{
    public class RepositorioCurso : IRepositorio<Curso>
    {
        public HashSet<Curso> Cursos { get; } = new HashSet<Curso>();

        public void Gravar(Curso curso)
        {
            Cursos.Add(curso);
        }

        public Curso ObterPorId(string nome)
        {
            return Cursos.Where(c => c.Nome.Equals(nome)).FirstOrDefault();
        }

        public IEnumerable<Curso> ObterTodos()
        {
            return Cursos;
        }

        public void Remover(Curso curso)
        {
            Cursos.Remove(curso);
        }
    }
}
