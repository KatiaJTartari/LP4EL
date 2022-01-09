using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc2
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
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public bool Ativo { get; set; }
    }

}
