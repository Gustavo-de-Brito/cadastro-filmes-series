using System.Collections.Generic;
using cadastroFilmesSeries.Interfaces;

namespace cadastroFilmesSeries.Classes
{
    public class RepositorioSerie : IRepositorio<Serie>
    {
        private List<Serie> series = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            this.series[id] = entidade;
        }

        public void Exclui(int id)
        {
            this.series[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            this.series.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return this.series;
        }

        public int ProximoId()
        {
            return this.series.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return this.series[id];
        }
    }
}