using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
	public class Cliente
	{
		private int codigo;
		private string endereco;
		private string telefone;

		// Métodos protegidos get e set

		//Métodos set devem atribuir os valores recebidos como argumento aos respectivos atributos da classe:

		protected void SetCodigo(int codigo)
		{
			this.codigo = codigo;
		}

		protected void SetEndereco(string endereco)
		{
			this.endereco = endereco;
		}

		protected void SetTelefone(string telefone)
		{
			this.telefone = telefone;
		}


		//Métodos get devem retornar os respectivos valores dos atributos da classe Cliente:

		protected int GetCodigo()
		{
			return codigo;
		}

		protected string GetEndereco()
		{
			return endereco;
		}

		protected string GetTelefone()
		{
			return telefone;
		}
	}
}
