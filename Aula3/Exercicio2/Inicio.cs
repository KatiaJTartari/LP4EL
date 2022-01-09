using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Inicio
    {
        static void Main(string[] args)
        {
			int opcao;
			double baseRetangulo, altura, raio;
			string cor;
									
			do
			{
				Console.WriteLine("OPÇÕES");
				Console.WriteLine("1 - Retângulo");
				Console.WriteLine("2 - Círculo");
				Console.WriteLine("0 - Sair");
				Console.Write("Digite sua opção: ");
				opcao = int.Parse(Console.ReadLine());

				switch (opcao)
				{
					case 1:
						Console.Write("Digite a base do retângulo: ");
						baseRetangulo = double.Parse(Console.ReadLine());
						Console.Write("Digite a altura do retângulo: ");
						altura = double.Parse(Console.ReadLine());
						Console.Write("Digite a cor do retângulo: ");
						cor = Console.ReadLine();
						new Retangulo(baseRetangulo, altura, cor);
						break;

					case 2:
						Console.Write("Digite o raio do círculo: ");
						raio = double.Parse(Console.ReadLine());
						Console.Write("Digite uma cor para o círculo: ");
						cor = Console.ReadLine();
						new Circulo(raio, cor);
						break;

					default:
						if (opcao != 0)
							Console.WriteLine("Opção Inválida!");
				        else
							Console.WriteLine("Programa Encerrado!");

						Console.ReadKey();
						break;
				}
			} while (opcao != 0);

		}
	}
}

	