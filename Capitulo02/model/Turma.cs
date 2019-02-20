using Capitulo02.Enum;

namespace Capitulo02.model
{
    public class Turma
    {
        private Curso _Curso;

        public Turma(Curso curso)
        {
            _Curso = curso;
        }

        public string CodigoTurma { get; set; }
        public PeriodoCursoEnum PeriodoCurso { get; set; }
        public TurnoTurmaEnum TurnoTurma { get; set; }
        public Curso Curso { get { return _Curso; } }

        public void RegistrarCurso(Curso curso)
        {
            this._Curso = curso;
        }

        public override bool Equals(object obj)
        {
            if (obj is Turma)
            {
                Turma t = obj as Turma;
                return this.CodigoTurma.Equals(t.CodigoTurma);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (11 + this.CodigoTurma == null ? 0 : this.CodigoTurma.GetHashCode());
        }
    }
}
