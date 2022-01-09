using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Cliente
    {
        private int codigo;
        private string nome;
        private string cpf;

		public bool SetCodigo(int codigo)
		{
			this.codigo = codigo;
			return true;
		}

		public bool SetNome(string nome)
		{
			if (nome.Contains(" "))
			{
				this.nome = nome;
				return true;
			}
			else
			{
				Console.WriteLine("Dados inválidos insira pelo menos um sobrenome!");
				//Console.WriteLine("Dados inválidos!");
				return false;
			}
		}

		public bool SetCpf(string cpf)
		{
			if (cpf.Length == 11)
            {
				this.cpf = cpf;
				return true;
			}
			else
			{
				Console.WriteLine("Dados inválidos o CPF deve ter 11 números!");
				return false;
			}
		}
		
		
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
