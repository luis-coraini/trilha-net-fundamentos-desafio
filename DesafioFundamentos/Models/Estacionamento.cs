namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            string? placa = VerificarPlacaNula(Console.ReadLine());

            veiculos.Add(placa);


        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = VerificarPlacaNula(Console.ReadLine());

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Clear();
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);

                Console.Clear();
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.Clear();
                Console.WriteLine("Os veículos estacionados são:");

                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine(veiculos[i]);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Não há veículos estacionados.");
            }
        }


        private string VerificarPlacaNula(string? placa)
        {
            while (String.IsNullOrEmpty(placa))
            {
                Console.Clear();
                Console.WriteLine("Digite uma placa válida:");
                placa = Console.ReadLine();
            }

            return placa.ToUpper();
        }
    }
}
