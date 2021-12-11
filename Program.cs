using System;
using cadastroFilmesSeries.Classes;
using System.Collections.Generic;

namespace cadastroFilmesSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioSerie colecaoSeries = new RepositorioSerie();
            RepositorioFilme colecaoFilmes = new RepositorioFilme();
            Console.WriteLine("Bem-vindo ao programa de cadastro de séries e filmes");
            string opcaoUsuario = ObtemOpcaoUsuario().ToUpper();

            while(opcaoUsuario != "S") 
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        Listar(colecaoSeries.Lista());
                        Console.WriteLine("Primeira opção");
                        break;
                    case "2":
                        Listar(colecaoFilmes.Lista());
                        break;
                    case "3":
                        Cadastrar(colecaoSeries);
                        break;
                    case "4":
                        Cadastrar(colecaoFilmes);
                        break;
                    case "5":
                        Atualizar(colecaoSeries);
                        break;
                    case "6":
                        Atualizar(colecaoFilmes);
                        break;
                    case "7":
                        Vizualizar(colecaoSeries);
                        break;
                    case "8":
                        Vizualizar(colecaoFilmes);
                        break;
                    case "9":
                        Excluir(colecaoSeries);
                        break;
                    case "10":
                        Excluir(colecaoFilmes);
                        break;
                    case "L":
                        Console.Clear();
                        break;
                    case "S":
                        Console.WriteLine("Obrigado por usar o cadastro de séries e filmes!!!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                opcaoUsuario = ObtemOpcaoUsuario().ToUpper();
            }
        }

        public static void Listar(List<Serie> series)
        {
            if(series.Count != 0) {
                foreach(Serie serie in series)
                {
                    Console.WriteLine("#{0} - {1} {2}", serie.RetornaId(), serie.RetornaTitulo(), serie.RetornaExcluido() ? "- *Excluído*" : "");
                }
            }
            else
            {
                Console.WriteLine("Nenhuma série cadastrada");
                Console.Write("Pressiona qualquer tecla para voltar ao menu principal...");
                Console.ReadKey();
            }
        }
        public static void Listar(List<Filme> filmes)
        {
            if(filmes.Count != 0)
            {
                foreach(Filme filme in filmes)
                {
                    Console.WriteLine("#{0} - {1} {2}", filme.RetornaId(), filme.RetornaTitulo(), filme.RetornaExcluido() ? "- *Excluído*" : "");
                }
            }
            else
            {
                Console.WriteLine("Nenhum filme cadastrado");
                Console.Write("Pressiona qualquer tecla para voltar ao menu principal...");
                Console.ReadKey();
            }
        }
        public static void Cadastrar(RepositorioSerie series)
        {
            int id = series.ProximoId();
            Console.Write("Digite o título da série: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite a descrição da série: ");
            string descricao = Console.ReadLine();
            Console.Write("Digite o ano de lançamento: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de episódios: ");
            int qtdEpisodios = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o gênero da série: ");

            foreach(int valorGenero in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("[{0}] - {1}", valorGenero, Enum.GetName(typeof(Genero), valorGenero));
            }
            int generoEscolhido = int.Parse(Console.ReadLine());

            Serie novaSerie = new Serie(
                id: id,
                titulo: titulo,
                descricao: descricao,
                ano: ano,
                genero: (Genero)generoEscolhido,
                qtdEpisodios: qtdEpisodios
            );

            series.Insere(novaSerie);
        }
        public static void Cadastrar(RepositorioFilme filmes)
        {
            int id = filmes.ProximoId();
            Console.Write("Digite o título do filme: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite a descrição do filme: ");
            string descricao = Console.ReadLine();
            Console.Write("Digite o ano de lançamento: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o tempo de duração em minutos: ");
            string tempoDuracao = Console.ReadLine();
            Console.WriteLine("Informe o gênero do filme: ");

            foreach(int valorGenero in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("[{0}] - {1}", valorGenero, Enum.GetName(typeof(Genero), valorGenero));
            }
            Console.WriteLine();
            int generoEscolhido = int.Parse(Console.ReadLine());

            Filme novoFilme = new Filme(
                id: id,
                titulo: titulo,
                descricao: descricao,
                ano: ano,
                genero: (Genero)generoEscolhido,
                tempoDuracao: tempoDuracao
            );

            filmes.Insere(novoFilme);
        }
        public static void Atualizar(RepositorioSerie series)
        {
            Console.Write("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Digite o título da série: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite a descrição da série: ");
            string descricao = Console.ReadLine();
            Console.Write("Digite o ano de lançamento: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de episódios: ");
            int qtdEpisodios = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o gênero da série: ");

            foreach(int valorGenero in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("[{0}] - {1}", valorGenero, Enum.GetName(typeof(Genero), valorGenero));
            }
            int generoEscolhido = int.Parse(Console.ReadLine());

            Serie serieAtualizada = new Serie(
                id: id,
                titulo: titulo,
                descricao: descricao,
                ano: ano,
                genero: (Genero)generoEscolhido,
                qtdEpisodios: qtdEpisodios
            );

            series.Atualiza(id, serieAtualizada);
        }
        public static void Atualizar(RepositorioFilme filmes)
        {
            Console.Write("Digite o ID do filme: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Digite o título do filme: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite a descrição do filme: ");
            string descricao = Console.ReadLine();
            Console.Write("Digite o ano de lançamento: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o tempo de duração do filme em minutos: ");
            string tempoDuracao = Console.ReadLine();
            Console.WriteLine("Informe o gênero do filme: ");

            foreach(int valorGenero in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("[{0}] - {1}", valorGenero, Enum.GetName(typeof(Genero), valorGenero));
            }
            int generoEscolhido = int.Parse(Console.ReadLine());

            Filme filmeAtualizado = new Filme(
                id: id,
                titulo: titulo,
                descricao: descricao,
                ano: ano,
                genero: (Genero)generoEscolhido,
                tempoDuracao: tempoDuracao
            );

            filmes.Atualiza(id, filmeAtualizado);
        }
        public static void Vizualizar(RepositorioSerie series)
        {
            Console.WriteLine("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine(series.RetornaPorId(id));
            Console.WriteLine("Aperte qualquer tecla pra voltar para o menu principal...");
            Console.ReadKey();
        }
        public static void Vizualizar(RepositorioFilme filmes)
        {
            Console.WriteLine("Digite o ID do filme: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine(filmes.RetornaPorId(id));
            Console.WriteLine("Aperte qualquer tecla pra voltar para o menu principal...");
            Console.ReadKey();
        }
        public static void Excluir(RepositorioFilme filmes)
        {
            Console.WriteLine("Digite o ID do filme a ser excluído: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Tem certeza que deseja excluir o filme {0}?", filmes.RetornaPorId(id).RetornaTitulo());
            Console.Write("[S] - Sim / [N] - Não: ");
            string escolhaExcluir = Console.ReadLine();

            if(escolhaExcluir.ToUpper() == "S")
            {
                filmes.RetornaPorId(id).Excluir();
                Console.WriteLine("Processo de exclusão concluído com sucesso!");
                Console.WriteLine();
            }
            else if(escolhaExcluir.ToUpper() == "N")
            {
                Console.WriteLine("Processo de exclusão cancelado");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Opção inválida. Processo de exclusão cancelado");
                Console.WriteLine();
            }

            Console.WriteLine("Aperte qualquer tecla pra voltar para o menu principal...");
            Console.ReadKey();
        }
        public static void Excluir(RepositorioSerie series)
        {
            Console.WriteLine("Digite o ID da série a ser excluída: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Tem certeza que deseja excluir a série {0}?", series.RetornaPorId(id).RetornaTitulo());
            Console.Write("[S] - Sim / [N] - Não: ");
            string escolhaExcluir = Console.ReadLine();

            if(escolhaExcluir.ToUpper() == "S")
            {
                series.RetornaPorId(id).Excluir();
                Console.WriteLine("Processo de exclusão concluído com sucesso!");
                Console.WriteLine();
            }
            else if(escolhaExcluir.ToUpper() == "N")
            {
                Console.WriteLine("Processo de exclusão cancelado");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Opção inválida. Processo de exclusão cancelado");
                Console.WriteLine();
            }

            Console.WriteLine("Aperte qualquer tecla pra voltar para o menu principal...");
            Console.ReadKey();
        }
        public static string ObtemOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Digite uma das opções abaixo: ");
            Console.WriteLine("[1]  - Listar séries");
            Console.WriteLine("[2]  - Listar filmes");
            Console.WriteLine("[3]  - Cadastrar uma série");
            Console.WriteLine("[4]  - Cadastrar um filme");
            Console.WriteLine("[5]  - Atualizar informações de uma série");
            Console.WriteLine("[6]  - Atualizar informações de um filme");
            Console.WriteLine("[7]  - Vizualizar as informações de uma série");
            Console.WriteLine("[8]  - Vizualizar as informações de um filme");
            Console.WriteLine("[9]  - Excluir uma série");
            Console.WriteLine("[10] - Excluir um filme");
            Console.WriteLine("[L]  - Limpar tela");
            Console.WriteLine("[S]  - Sair do programa");
            Console.WriteLine();
            string opcaoEscolhida = Console.ReadLine();
            Console.WriteLine();
            
            return opcaoEscolhida;
        }
    }
}
