using System;

namespace DIO.AnimesSeries
{
    class Program
    {
        static AnimesRepositorio repositorioAnime = new AnimesRepositorio();
        static SeriesRepositorio repositorioSerie = new SeriesRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarAnimes();
                        break;
                    case "2":
                        ListarSeries();
                        break;
                    case "3":
                        InserirAnime();
                        break;
                    case "4":
                        InserirSerie();
                        break;
                    case "5":
                        AtualizarAnime();
                        break;
                    case "6":
                        AtualizarSerie();
                        break;
                    case "7":
                        ExcluirAnime();
                        break;
                    case "8":
                        ExcluirSerie();
                        break;
                    case "9":
                        VisualizarAnimes();
                        break;
                    case "10":
                        ListarSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void ExcluirAnime()
        {
            Console.Write("Digite o id do anime: ");
            int indiceAnime = int.Parse(Console.ReadLine());

            repositorioAnime.Exclui(indiceAnime);
        
        }
        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorioSerie.Exclui(indiceSerie);
        
        }
        private static void VisualizarAnimes()
        {
            Console.Write("Digite o id do anime: ");
            int indiceAnime = int.Parse(Console.ReadLine());

            var anime = repositorioAnime.RetornaPorId(indiceAnime);
            Console.WriteLine(anime);
        }
        private static void VisualizarSeries()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorioAnime.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);
        }
        private static void AtualizarAnime()
        {
            Console.Write("Digite o id do anime: ");
            int indiceAnime = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Anime: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Inicio do Anime: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Sinopse do Anime: ");
            string entradaSinopse = Console.ReadLine();

            Anime atualizaAnime = new Anime(id: indiceAnime,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        sinopse: entradaSinopse);
        }
        private static void AtualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Inicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Sinopse da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Animes&Séries, Seja Bem vindo!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar animes.");
            Console.WriteLine("2- Listar séries.");
            Console.WriteLine("3- Inserir novo anime.");
            Console.WriteLine("4- Inserir nova série.");
            Console.WriteLine("5- Atualizar anime.");
            Console.WriteLine("6- Atualizar série.");
            Console.WriteLine("7- Excluir anime.");
            Console.WriteLine("8- Excluir série.");
            Console.WriteLine("9- Visualizar anime.");
            Console.WriteLine("10- Visualizar série.");
            Console.WriteLine("C- Limpar a tela.");
            Console.WriteLine("X- Sair do programa.");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static void InserirAnime()
        {
            Console.WriteLine("Inserir novo anime");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo do anime: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio do anime: ");
            int entradaAno = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a descrição do anime: ");
            string entradaSinopse = Console.ReadLine();

            Anime novoAnime = new Anime(id: repositorioAnime.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        sinopse: entradaSinopse);      
        }
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o genêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da série: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a descrição da série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novoSerie = new Serie(id: repositorioAnime.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);      
        }
        private static void ListarAnimes()
        {
            Console.WriteLine("Listar animes");
            var lista = repositorioAnime.Lista();
            if(lista.Count == 0)
            {
                Console.WriteLine("Nehum anime cadastrado.");
                return;
            }

            foreach(var anime in lista)
            {
                var excluido = anime.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} - {2}", anime.retornaId(), anime.retornaTitulo(), (excluido ? "*Excluido*": ""));
            }
        }
        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");
            var listaSerie = repositorioSerie.Lista();
            if(listaSerie.Count == 0)
            {
                Console.WriteLine("Nehuma série cadastrada.");
                return;
            }

            foreach(var serie in listaSerie)
            {
                var excluido = serie.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} - {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido*": ""));
            }
        }

        
    }
}
