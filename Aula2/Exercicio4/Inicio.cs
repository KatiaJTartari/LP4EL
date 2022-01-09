using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
	class Inicio
	{
		static void Main(string[] args)
		{
			int opcao, cod, codigo = 1;
			string nome, cpf, razaoSocial, cnpj, endereco, telefone;
			// Instancias das classes PessoaFisica e PessoaJuridica
			PessoaFisica pf = new PessoaFisica();
			PessoaJuridica pj = new PessoaJuridica();

			PessoaFisica[] clientesPF = new PessoaFisica[10]; //Vetor do tipo pessoa física com 10 posições
			PessoaJuridica[] clientesPJ = new PessoaJuridica[10]; //Vetor do tipo pessoa jurídica com 10 posições

			do
			{
				Console.WriteLine("MENU DE OPÇÕES:");
				Console.WriteLine("1- Inserir Cliente");
				Console.WriteLine("2- Remover Cliente");
				Console.WriteLine("3- Consultar Clientes");
				Console.WriteLine("0- Sair");
				Console.Write("Digite sua opção: ");
				opcao = int.Parse(Console.ReadLine());

				switch (opcao)
				{
					case 1:
						string tipo_Cliente;
						Console.Write("Digite (PF) para Pessoa Física ou (PJ) para Pessoa Jurídica:");
						tipo_Cliente = Console.ReadLine();

						switch (tipo_Cliente)
						{
							case "pf":
								Console.Write("Nome: ");
								nome = Console.ReadLine();
								Console.Write("CPF: ");
								cpf = Console.ReadLine();
								Console.Write("Endereço: ");
								endereco = Console.ReadLine();
								Console.Write("Telefone: ");
								telefone = Console.ReadLine();

								pf = new PessoaFisica();
								clientesPF[codigo - 1] = pf.SetPessoaFisica(codigo, nome, cpf, endereco, telefone);

								codigo++;

								Console.WriteLine("Cliente inserido com sucesso!");

								break;

							case "pj":
								Console.Write("Razão Social: ");
								razaoSocial = Console.ReadLine();
								Console.Write("CNPJ: ");
								cnpj = Console.ReadLine();
								Console.Write("Endereço: ");
								endereco = Console.ReadLine();
								Console.Write("Telefone: ");
								telefone = Console.ReadLine();

								pj = new PessoaJuridica();
								clientesPJ[codigo - 1] = pj.SetPessoaJuridica(codigo, razaoSocial, cnpj, endereco, telefone);

								codigo++;

								Console.WriteLine("Cliente inserido com sucesso!");

								break;

							default:
								Console.WriteLine("Tipo de cliente inexistente!");
								break;
						}
						Console.WriteLine();
						break;

					case 2:
						Console.Write("Digite (PF) para Pessoa Física ou (PJ) para Pessoa Jurídica:");
						tipo_Cliente = Console.ReadLine();

						bool remocao = false;

						switch (tipo_Cliente)
						{
							case "pf":
								Console.Write("Informe o código do cliente: ");
								cod = int.Parse(Console.ReadLine());

								for (int i = 0; i < codigo; i++)
									if (clientesPF[i] != null)
										if (pf.GetCodigoVetorPF(clientesPF[i]) == cod)
										{
											//Foi atribuído o valor “null” à posição do vetor relacionada ao cliente informado.
											clientesPF[i] = null;
											remocao = true;
											break;
										}
								break;

							case "pj":
								Console.Write("Informe o código do cliente: ");
								cod = int.Parse(Console.ReadLine());

								for (int i = 0; i < codigo; i++)
									if (clientesPJ[i] != null)
										if (pj.GetCodigoVetorPJ(clientesPJ[i]) == cod)
										{
											//Foi atribuído o valor “null” à posição do vetor relacionada ao cliente informado.
											clientesPJ[i] = null;
											remocao = true;
											break;
										}
								break;
							default:
								Console.WriteLine("Tipo de cliente inexistente!");
								Console.WriteLine();
								break;
						}

						if (remocao)
							Console.WriteLine("Cliente removido com sucesso!");
						else
							Console.WriteLine("Código inexistente!");

						Console.WriteLine();

						break;

					case 3:
						bool existe_pf = false;

						for (int i = 0; i < codigo - 1; i++)
						{
							if (clientesPF[i] != null)
							{
								existe_pf = true;
								break;
							}
						}

						if (existe_pf == true)
							Console.WriteLine("PESSOAS FÍSICAS:");
						else
							Console.WriteLine("PESSOAS FÍSICAS: Nenhum registro encontrado!");

						pf.GetPessoaFisica(codigo, clientesPF);

						//---------------------------------------------------------------------
						bool existe_pj = false;

						for (int i = 0; i < codigo - 1; i++)
						{
							if (clientesPJ[i] != null)
							{
								existe_pj = true;
								break;
							}
						}

						if (existe_pj == true)
							Console.WriteLine("PESSOAS JURÍDICAS:");
						else
							Console.WriteLine("PESSOAS JURÍDICAS: Nenhum registro encontrado!");

						pj.GetPessoaJuridica(codigo, clientesPJ);

						Console.WriteLine();
						break;

					default:
						if (opcao != 0)
							Console.WriteLine("Opção inválida!");
						else
						{
							Console.WriteLine("Programa encerrado!");
							Console.ReadKey();
						}
						Console.WriteLine();
						break;
				}
			} while (opcao != 0);

		}
	}
}
