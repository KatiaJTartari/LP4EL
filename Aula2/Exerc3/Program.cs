using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc3
{
    class Inicio
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(); //Criação do objeto p que instancia a classe Produto.

            Console.Write("Código: ");
            p.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            p.Descricao = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Informe se o produto está ativo (true ou false): ");
            p.Ativo = bool.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(p.Codigo);
            Console.WriteLine(p.Descricao);
            Console.WriteLine("R$ " + p.Preco);
            Console.WriteLine(p.Ativo);

            Console.ReadKey();
        }
    }

	class Produto
	{
		private int codigo;
		private string descricao;
		private double preco;
		private bool ativo;

		//Construtor da classe Produto para inicializar seus atributos:
		public Produto()
		{
			codigo = 0;
			descricao = "";
			preco = 0;
			ativo = false;
		}

		//Destrutor da classe Produto
		//~Produto() { }

		public int Codigo
		{
			get { return codigo; }
			set
			{
				if (value != 0)
					codigo = value;
			}
		}

		public string Descricao
		{
			get { return descricao; }
			set
			{
				if (!value.Equals(""))
					descricao = value;
			}
		}

		public double Preco
		{
			get { return preco; }
			set
			{
				if (value > 0)
					preco = value;
			}
		}

		public bool Ativo
		{
			get { return ativo; }
			set { ativo = value; }
		}
	}
}
