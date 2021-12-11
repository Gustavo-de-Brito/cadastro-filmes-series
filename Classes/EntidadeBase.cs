namespace cadastroFilmesSeries.Classes
{
    public abstract class EntidadeBase
    {
        protected int Id { get; set; }
        protected string Titulo { get; set; }
        protected string Descricao { get; set; }
        protected int Ano { get; set; }
        protected Genero Genero { get; set; }
        protected bool Excluido { get; set; }

        public abstract int RetornaId();

        public abstract string RetornaTitulo();
    }
}