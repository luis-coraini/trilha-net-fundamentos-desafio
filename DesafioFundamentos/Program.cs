using System.Net.NetworkInformation;
using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");


Console.WriteLine("Digite o preço inicial:");
bool precoInicialValido = false;

while (!precoInicialValido)
{

    try
    {
        precoInicial = Convert.ToDecimal(Console.ReadLine());
        precoInicialValido = true;
        Console.Clear();
    }
    catch
    {
        Console.Clear();
        precoInicialValido = false;
        Console.WriteLine("Informe um preço inicial válido:");
    }
}

Console.Clear();
Console.WriteLine("Agora digite o preço por hora:");
bool precoPorHoraValido = false;

while (!precoPorHoraValido)
{

    try
    {
        precoPorHora = Convert.ToDecimal(Console.ReadLine());
        precoPorHoraValido = true;
        Console.Clear();
    }
    catch
    {
        Console.Clear();
        precoPorHoraValido = false;
        Console.WriteLine("Informe um preço por hora válido:");
    }
}

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.Clear();
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
    Console.Clear();
}

Console.Clear();
Console.WriteLine("O programa se encerrou");

