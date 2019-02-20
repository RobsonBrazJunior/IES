using System.Collections.Generic;

namespace ProjetoIES.model
{
    public class StrictoSensu : PosGraduacao
    {
        public IList<string> LinhaDePesquisa { get; } = new List<string>();
    }
}
