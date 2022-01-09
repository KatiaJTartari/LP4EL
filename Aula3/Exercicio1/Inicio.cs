using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Inicio
    {
        static void Main(string[] args)
        {
			int opcao;
			string texto = "";
			string cadeiaCaracteres = "";

			Pesquisa p = new Pesquisa();

			do
			{
				Console.WriteLine("MENU DE OPÇÕES");
				Console.WriteLine("1 - Informar Texto");
				Console.WriteLine("2 - Buscar String");
				Console.WriteLine("3 - Buscar String no Início");
				Console.WriteLine("4 - Buscar String no Fim");
				Console.WriteLine("0 - Sair");
				Console.Write("Digite sua opção: ");
				opcao = int.Parse(Console.ReadLine());
				
				switch (opcao)
				{
					case 1:
						Console.Write("Insira um texto: ");
						texto = Console.ReadLine();
						p = new Pesquisa();
						p.SetTexto(texto);
						break;

					case 2:
						Console.Write("Insira uma cadeia de caracteres: ");
						cadeiaCaracteres = Console.ReadLine();
						p = new Pesquisa();
						if (!texto.Equals(""))
						{
							if (p.BuscarString(cadeiaCaracteres))
								Console.WriteLine("Cadeia de caracteres encontrada!");
					        else
								Console.WriteLine("Cadeia de caracteres não encontrada!");
						}
						else
							Console.WriteLine("Primeiramente insira um texto através da opção 1!");
						break;

					case 3:
						Console.Write("Insira uma cadeia de caracteres: ");
						cadeiaCaracteres = Console.ReadLine();
						p = new PesquisaInicio();
						if (!texto.Equals(""))
						{
							if (p.BuscarString(cadeiaCaracteres))
								Console.WriteLine("Cadeia de caracteres encontrada no início!");
					        else
								Console.WriteLine("Cadeia de caracteres não encontrada no início!");
						}
						else
							Console.WriteLine("Primeiramente insira um texto através da opção 1!");
						break;

					case 4:
						Console.Write("Insira uma cadeia de caracteres: ");
						cadeiaCaracteres = Console.ReadLine();
						p = new PesquisaFim();
						if (!texto.Equals(""))
						{
							if (p.BuscarString(cadeiaCaracteres))
								Console.WriteLine("Cadeia de caracteres encontrada no fim!");
					        else
								Console.WriteLine("Cadeia de caracteres não encontrada no fim!");
						}
						else
							Console.WriteLine("Primeiramente insira um texto através da opção 1!");
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
		
