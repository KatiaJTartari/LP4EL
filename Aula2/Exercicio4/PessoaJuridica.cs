using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
	class PessoaJuridica : Cliente
	{
		private string razaoSocial;
		private string cnpj;

		//Métodos públicos get e set

		//Métodos set devem atribuir os valores recebidos como argumento aos respectivos atributos da classe:
		public void SetRazaoSocial(string razaoSocial)
		{
			this.razaoSocial = razaoSocial;
		}

		public void SetCnpj(string cnpj)
		{
			this.cnpj = cnpj;
		}

		//Métodos get devem retornar os respectivos valores dos atributos da classe PessoaJuridica:
		public string GetRazaoSocial()
		{
			return razaoSocial;
		}

		public string GetCnpj()
		{
			return cnpj;
		}

		public PessoaJuridica SetPessoaJuridica(int codigo, string razaoSocial, string cnpj, string endereco, string telefone)
		{
			this.SetCodigo(codigo);
			this.SetRazaoSocial(razaoSocial);
			this.SetCnpj(cnpj);
			this.SetEndereco(endereco);
			this.SetTelefone(telefone);
			return this;
		}

		public void GetPessoaJuridica(int codigo, PessoaJuridica[] clientesPJ)
		{
			for (int i = 0; i < codigo - 1; i++)
			{
				if (clientesPJ[i] != null)
				{
					Console.WriteLine(clientesPJ[i].GetCodigo() + " - " +
									  clientesPJ[i].GetRazaoSocial() + " - " +
									  clientesPJ[i].GetCnpj() + " - " +
									  clientesPJ[i].GetEndereco() + " - " +
									  clientesPJ[i].GetTelefone());
				}
			}
		}

		public int GetCodigoVetorPJ(PessoaJuridica clientesPJ)
		{
			return clientesPJ.GetCodigo();
		}

	}
}
