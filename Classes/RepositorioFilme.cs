using System.Collections.Generic;
using cadastroFilmesSeries.Interfaces;

namespace cadastroFilmesSeries.Classes
{
    public class RepositorioFilme : IRepositorio<Filme>
    {
        private List<Filme> filmes = new List<Filme>();
        public void Atualiza(int id, Filme entidade)
        {
            this.filmes[id] = entidade;
        }

        public void Exclui(int id)
        {
            this.filmes[id].Excluir();
        }

        public void Insere(Filme entidade)
        {
            this.filmes.Add(entidade);
        }

        public List<Filme> Lista()
        {
            return this.filmes;
        }

        public int ProximoId()
        {
            return this.filmes.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return this.filmes[id];
        }
    }
}