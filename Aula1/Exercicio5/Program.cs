/* Exercício 5 - Escreva uma aplicação console em C# para calcular o gasto com combustível 
   em uma viagem. O programa deve ler a distância (Km), o preço do combustível e o consumo 
   de combustível (Km/litro) do veículo, e deve retornar o valor a ser gasto na viagem. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia, preco, consumoVeiculo, combustivelNecessario, valorGasto;

            Console.Write("Digite a distância (km): ");
            distancia = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço do litro do combustível: ");
            preco = double.Parse(Console.ReadLine());

            Console.Write("Digite o consumo de combustível (Km/litro) do veículo: ");
            consumoVeiculo = double.Parse(Console.ReadLine());

            combustivelNecessario = distancia / consumoVeiculo;
            valorGasto = combustivelNecessario * preco;

            Console.Write("\n O valor a ser gasto na viagem é " + valorGasto);

            Console.ReadKey(); //Mantém o console aberto enquanto o usuário não pressionar alguma tecla.

        }
    }
}
