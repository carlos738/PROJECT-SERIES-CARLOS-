using Internal;
using System;

namespace PROJECT_SERIES_CARLOS_
{
    class Program
    {   static SerieRepositorio  = new SERIEREPOSITORIO();
        static void Main(string[] args) 
           {
               string opcaoUsuario = ObterOpcaoUsuario();
               while (opcaoUsuario.ToUpper() != "X")
               {
                   switch (opcaoUsuario)
                   {
                       case "1":
                             ListarSeries();
                            break;
                            case "2":
                            InserirSerie();
                            break;
                            case "3":
                            AtualizarSerie();
                            break;
                            case "4":
                            ExcluirSerie();
                            break;
                            case "5":
                            VisualizarSerie();
                            break;
                            case "C":
                            Console.Clear();
                            break;

                            default:
                            throw new ArgumentOutOfRangeException();


                   }
                   opcaoUsuario = ObterOpcaoUsuario();
               }
               Console.WriteLine("Obrigado por utilizar nossos servi�os.");
               Console.ReadLine();

            
        }
        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da s�rie: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.writeLine();
        }
        private static void AtualizarSerie()
        {
            Console.Write("Digite o id da s�rie: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.
            //https//docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view =netcore-3.
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o g�nero entre a op��es acima:");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o titulo da serie:");
            string entradaTitulo = Console.ReadLine();

             Console.Write("Digite o Ano de In�cio da S�rie: ");
             int entradaAno = int.Parse(Console.ReadLine());

             Console.Write("Digite a Descri��o da S�rie:");
             string entradaDescri��o = Console.ReadLine()
             serie novaSerie = new serie(id: repositorio.ProximoId()),

             (Genero)entradaGenero,
             Genero;
             entradaTitulo,
             titulo;
             entradaAno,
             ano: 
             
             descricao: entradaDescricao

                descricao: entradaDescricao=0;

              repositorio.Insere (novaSerie);
        


        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("PROJECT-SERIES-CARLOS- a seu dispor!!!");

            Console.Write("Informe a opcao desejada:");

            Console.WriteLine("1- Listar s�ries");
            Console.Writeline("2- Inserir nova serie");
            Console.Writeline("3- Atualizar serie");
            Console.Writeline("5- Visualizar s�rie");
            Console.WriteLine("C Limpar Tela");
            Console.WriteLine("X- sair");
            Console.WriteLine();

            string opcaoUsuario =  Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;


        }
    }
}