namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        private string placaEntrada = "";

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placaEntrada = Console.ReadLine();
            if (VerificarVeiculoJaNoestacionamento())
            {
                Console.WriteLine("veiculo ja cadastrado");
            }
            else if (placaEntrada == "")
            {
                Console.WriteLine("Por Favor Digite Novamente");
            }
            else
            {
                veiculos.Add(placaEntrada);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                try
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    decimal horas = decimal.Parse(Console.ReadLine());
                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                    // *IMPLEMENTE AQUI*
                    decimal valorTotal = precoInicial + (precoPorHora * horas);

                    // TODO: Remover a placa digitada da lista de veículos
                    // *IMPLEMENTE AQUI*
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                catch
                {
                    Console.WriteLine("Volte ao Menu Inicar");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (var item in veiculos)
                {
                    Console.WriteLine($"placaEntrada: {item}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        //verificar se veiculo ja está No estacionamento
        public bool VerificarVeiculoJaNoestacionamento()
        {
            //Console.WriteLine("verifica");
            for (int i = 0; i < veiculos.Count(); i++)
            {

                if (veiculos[i] == placaEntrada)
                {
                    Console.WriteLine(" Placa encontrada", veiculos[i]);
                    return true;
                }
            }
            return false;
        }
    }
}
