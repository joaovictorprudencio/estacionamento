using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento.models
{
    public class EstacionamentoApp(decimal precoInicial, decimal precoPorHora)
    {
        private decimal precoInicial = precoInicial;
        private decimal precoPorHora = precoPorHora;

        private List<String> veiculos = new List<string>();

        public void AdicionarVeiculo()
        {
         Console.WriteLine("Digite a placa do veículo para estacionar:");
          string novoVeiculo = Console.ReadLine();
          veiculos.Add(novoVeiculo);
        }

          public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int quantidadeHoras = int.Parse(Console.ReadLine());
                decimal valorTotal = quantidadeHoras + this.precoPorHora; 
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
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
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine(veiculos[i]);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }


    }
}