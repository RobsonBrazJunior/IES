using System.Collections.Generic;

namespace Capitulo02.model
{
    public class StrictoSensu : PosGraduacao
    {
        public IList<string> LinhaDePesquisa { get; } = new List<string>();
    }
}
