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
			int opcao = 0, codigo = 1;
			string nome = "", cpf = "";
			Cliente c = new Cliente();
			bool erro;

			Cliente[] clientes = new Cliente[5];

			do
			{
				Console.Clear();
				Console.WriteLine("OPÇÕES:");
				Console.WriteLine("1- Inserir Cliente");
				Console.WriteLine("2- Consultar Cliente Específico");
				Console.WriteLine("3- Consultar Clientes");

				do
				{
					erro = false;
					Console.Write("Digite uma opção (0 para Sair): ");
					try
					{
						opcao = int.Parse(Console.ReadLine());
					}
					catch (FormatException e)
					{
						Console.WriteLine(e.Message);
						erro = true;
					}
				} while (erro);

				switch (opcao)
				{
					case 1:
						Console.Clear();
						c = new Cliente();
						do
						{
							erro = false;
							Console.Write("Informe o CPF: ");
							try
							{
								cpf = Console.ReadLine();
								c.SetCpf(cpf);
							}
							catch (ArgumentException e)
							{
								Console.WriteLine(e.Message);
								erro = true;
							}
						} while (erro);

						do
						{
							erro = false;
							Console.Write("Informe o Nome: ");
							try
							{
								nome = Console.ReadLine();
								c.SetNome(nome);
							}
							catch (ArgumentException e)
							{
								Console.WriteLine(e.Message);
								erro = true;
							}
						} while (erro);

						c.SetCodigo(codigo);
						clientes[codigo - 1] = c;
						codigo++;

						break;

					case 2:
						Console.Clear();
						int cod = 0;
						do
						{
							erro = false;
							Console.Write("Informe o código do cliente: ");
							try
							{
								cod = int.Parse(Console.ReadLine());

								erro = true;
								for (int i = 0; i < (codigo - 1); i++)
									if (clientes[i].GetCodigo() == cod)
										erro = false;
								if (erro)
									throw new ArgumentException("Este cliente não existe!");
							}
							catch (FormatException e)
							{
								Console.WriteLine(e.Message);
								erro = true;
							}
							catch (ArgumentException e)
							{
								Console.WriteLine(e.Message);
							}
							finally
							{
								if (erro)
									Console.WriteLine("A consulta não retornou nenhum resultado!");
								else
									Console.WriteLine("Consulta realizada com sucesso!");
							}
						} while (erro);

						Console.WriteLine("CLIENTE ENCONTRADO: ");
						for (int i = 0; i < (codigo - 1); i++)
						{
							if (clientes[i].GetCodigo() == cod)
								Console.WriteLine(cod + " - " +
												   clientes[i].GetNome() + " - " +
												   clientes[i].GetCpf());
						}
						Console.ReadKey();
						break;

					case 3:
						Console.Clear();
						Console.WriteLine("CLIENTES ENCONTRADOS: ");
						for (int i = 0; i < codigo - 1; i++)
							Console.WriteLine(clientes[i].GetCodigo() + " - " +
											  clientes[i].GetNome() + " - " +
											  clientes[i].GetCpf());
						Console.ReadKey();
						break;
					default:
						if (opcao != 0)
							Console.WriteLine("Digite uma opção válida. \nTecle Enter para continuar.");
						else
							Console.WriteLine("Programa encerrado.");
						Console.ReadKey();
						break;
				}
				Console.ReadLine();
			} while (opcao != 0);
		}
	}

	class Cliente
	{
		private int codigo;
		private string nome;
		private string cpf;

		//Métodos set devem atribuir os valores recebidos como argumento aos respectivos atributos da classe:
		public void SetCodigo(int codigo)
		{
			this.codigo = codigo;
		}
		public void SetCpf(string cpf)
		{
			bool numeros = true;
			foreach (char digito in cpf.ToCharArray())
				if (!char.IsNumber(digito)) // IsNumber -> Verifica se o caractere é um número.
				{
					numeros = false;
					break;
				}
			if (cpf.Length != 11)
				throw new ArgumentException("Digite 11 números!");
			else if (!numeros)
				throw new ArgumentException("Digite apenas números!");

			this.cpf = cpf;
		}
		public void SetNome(string nome)
		{
			bool letrasEspacos = true;
			foreach (char caractere in nome.ToCharArray())
				// IsLetter -> Verifica se o caractere é uma letra.
				// IsWhiteSpace -> Verifica se o caractere é um espaço.
				if (!char.IsLetter(caractere) && !char.IsWhiteSpace(caractere))
				{
					letrasEspacos = false;
					break;
				}

			if (!nome.Contains(" "))
				throw new ArgumentException("Digite pelo menos um sobrenome!");
			else if (!letrasEspacos)
				throw new ArgumentException("Digite apenas letras!");

			this.nome = nome;
		}

		//Métodos get devem retornar os respectivos valores dos atributos da classe Cliente:
		public int GetCodigo()
		{
			return this.codigo;
		}

		public string GetNome()
		{
			return this.nome;
		}

		public string GetCpf()
		{
			return this.cpf;
		}
	}
}
	