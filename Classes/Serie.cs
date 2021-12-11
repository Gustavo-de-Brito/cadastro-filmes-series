using System;

namespace cadastroFilmesSeries.Classes
{
    public class Serie : EntidadeBase
    {
        private int QtdEpisodios { get; set; }
        public Serie(int id, string titulo, string descricao, int ano, Genero genero, int qtdEpisodios)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Genero = genero;
            this.Excluido = false;
            this.QtdEpisodios = qtdEpisodios;
        }

        public override string ToString()
        {
            string dados = "";
            dados += "Id: " + this.Id + Environment.NewLine;
            dados += "Título: " + this.Titulo + Environment.NewLine;
            dados += "Descrição: " + this.Descricao + Environment.NewLine;
            dados += "Ano: " + this.Ano + Environment.NewLine;
            dados += "Genero: " + this.Genero + Environment.NewLine;
            dados += "Número de Episódios: " + this.QtdEpisodios + Environment.NewLine;
            dados += "Excluído: " + this.Excluido;

            return dados;
        }

        override public string RetornaTitulo()
        {
            return this.Titulo;
        }

        override public int RetornaId()
        {
            return this.Id;
        }

        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}