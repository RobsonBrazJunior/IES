using System.Collections.Generic;

namespace Capitulo02.Repo
{
    public interface IRepositorio<T>
    {
        T ObterPorId(string id);
        IEnumerable<T> ObterTodos();
        void Gravar(T objeto);
        void Remover(T objeto);
    }
}
