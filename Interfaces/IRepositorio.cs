using System.Collections.Generic;

namespace cadastroFilmesSeries.Interfaces
{
    public interface IRepositorio<T>
    {
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        List<T> Lista();
        int ProximoId();
        T RetornaPorId(int id);
    }
}