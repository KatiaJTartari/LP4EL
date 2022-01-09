using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
	class PessoaFisica : Cliente
	{
		private string nome;
		private string cpf;

		//Métodos públicos get e set

		//Métodos set devem atribuir os valores recebidos como argumento aos respectivos atributos da classe:

		public void SetNome(string nome)
		{
			this.nome = nome;
		}

		public void SetCpf(string cpf)
		{
			this.cpf = cpf;
		}


		//Métodos get devem retornar os respectivos valores dos atributos da classe PessoaFisica:
		public string GetNome()
		{
			return nome;
		}

		public string GetCpf()
		{
			return cpf;
		}

		public PessoaFisica SetPessoaFisica(int codigo, string nome, string cpf, string endereco, string telefone)
		{
			this.SetCodigo(codigo);
			this.SetNome(nome);
			this.SetCpf(cpf);
			this.SetEndereco(endereco);
			this.SetTelefone(telefone);
			return this;
		}

		public void GetPessoaFisica(int codigo, PessoaFisica[] clientesPF)
		{
			for (int i = 0; i < codigo - 1; i++)
			{
				if (clientesPF[i] != null)
				{


					Console.WriteLine(clientesPF[i].GetCodigo() + " - " +
									  clientesPF[i].GetNome() + " - " +
									  clientesPF[i].GetCpf() + " - " +
									  clientesPF[i].GetEndereco() + " - " +
									  clientesPF[i].GetTelefone());
				}
			}
		}

		public int GetCodigoVetorPF(PessoaFisica clientesPF)
		{
			return clientesPF.GetCodigo();
		}
	}
}
