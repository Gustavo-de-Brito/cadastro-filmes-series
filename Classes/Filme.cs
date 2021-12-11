using System;

namespace cadastroFilmesSeries.Classes
{
    public class Filme : EntidadeBase
    {
        private string TempoDuracao { get; set; }

        public Filme(int id, string titulo, string descricao, int ano, Genero genero, string tempoDuracao)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Genero = genero;
            this.Excluido = false;
            this.TempoDuracao = tempoDuracao;
        }

        public override string ToString()
        {
            string dados = "";
            dados += "Id: " + this.Id + Environment.NewLine;
            dados += "Título: " + this.Titulo + Environment.NewLine;
            dados += "Descrição: " + this.Descricao + Environment.NewLine;
            dados += "Ano: " + this.Ano + Environment.NewLine;
            dados += "Genero: " + this.Genero + Environment.NewLine;
            dados += "Tempo de Duração: " + this.TempoDuracao + Environment.NewLine;
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

        public void Excluir()
        {
            this.Excluido = true;
        }
        public bool RetornaExcluido()
        {
            return this.Excluido;
        }

    }
}