using System.Globalization;

string mensagemBoasVindas = "Seja bem-vindo ao Screen Sound";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirMensagemBoasVindas()
{
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = new string('*', quantidadeDeLetras);
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("\nDigite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Bandas Registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual nota a {nomeBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeBanda}!");
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não está registrada!");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
}

void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média das Bandas");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        List<int> notas = bandasRegistradas[nomeBanda];
        if (notas.Count > 0)
        {
            double media = notas.Average();
            Console.WriteLine($"\nA média da banda {nomeBanda} é {media:F1}");
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} ainda não recebeu nenhuma nota.");
        }
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não está registrada!");
    }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
}

void ExibirMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Media da banda");
    Console.Write("Digite o nome da banda: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        List<int> notas = bandasRegistradas[nomeBanda];
        if (notas.Count > 0)
        {
            double media = notas.Average();
            Console.WriteLine($"\nA média da banda {^nomeBanda} é: {media}");
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeBanda} ainda não recebeu nenhuma nota.");
        }
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não está registrada!");
    }
}

            void ExibirOpcoes()
            {
                int opcNumerica = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("\nDigite 1 para registrar uma banda");
                    Console.WriteLine("Digite 2 para mostrar todas as bandas");
                    Console.WriteLine("Digite 3 para avaliar uma banda");
                    Console.WriteLine("Digite 4 para exibir a média de uma banda");
                    Console.WriteLine("Digite -1 para sair");

                    Console.Write("\nDigite aqui a opção: ");
                    string opcEscolhida = Console.ReadLine()!;
                    opcNumerica = int.Parse(opcEscolhida);

                    switch (opcNumerica)
                    {
                        case 1:
                            RegistrarBanda();
                            break;
                        case 2:
                            MostrarBandasRegistradas();
                            break;
                        case 3:
                            AvaliarBanda();
                            break;
                        case 4:
                            ExibirMediaDaBanda();
                            break;
                        case -1:
                            Console.WriteLine("Falou, meu caro! :)");
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente!");
                            Thread.Sleep(2000);
                            break;
                    }

                } while (opcNumerica != -1);
            }

Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
ExibirMensagemBoasVindas();
ExibirOpcoes();
