using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1
{
    class Inicio
    {
		static void Main(string[] args)
		{
			Produto p = new Produto();
			// Criação do objeto Produto que chamará os métodos get e set da classe Produto

			/* São usados os métodos set para atribuir os valores informados 
			 * pelo usuário aos atributos da classe Produto */
			Console.Write("Código: ");
			p.SetCodigo(int.Parse(Console.ReadLine()));
			Console.Write("Descrição: ");
			p.SetDescricao(Console.ReadLine());
			Console.Write("Preço: ");
			p.SetPreco(double.Parse(Console.ReadLine()));
			Console.Write("Informe se o produto está ativo (true ou false): ");
			p.SetAtivo(bool.Parse(Console.ReadLine()));

			// São usados os métodos get para apresentar seus novos valores ao usuário
			Console.WriteLine();
			Console.WriteLine(p.GetCodigo());
			Console.WriteLine(p.GetDescricao());
			Console.WriteLine(p.GetPreco());
			Console.WriteLine("R$ " + p.GetAtivo());

			Console.ReadKey();
		}
	}

	class Produto
	{
		private int codigo;
		private string descricao;
		private double preco;
		private bool ativo;

		// Métodos públicos get e set

		// Métodos get retornam os respectivos valores dos atributos da classe Produto

		public int GetCodigo()
		{
			return codigo;
		}

		public string GetDescricao()
		{
			return descricao;
		}

		public double GetPreco()
		{
			return preco;
		}

		public bool GetAtivo()
		{
			return ativo;
		}

		// Métodos set atribuem os valores recebidos como argumento aos respectivos atributos da classe

		public void SetCodigo(int codigo)
		{
			this.codigo = codigo;
		}

		public void SetDescricao(string descricao)
		{
			this.descricao = descricao;
		}

		public void SetPreco(double preco)
		{
			this.preco = preco;
		}

		public void SetAtivo(bool ativo)
		{
			this.ativo = ativo;
		}

	}

}

