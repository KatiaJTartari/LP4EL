/* Exercício 4 - Escreva uma aplicação console em C# que leia o valor de um produto e seu respectivo
desconto (de 0% a 100%) e retorne o valor do produto com o desconto informado. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorProduto, descontoProduto, valorProdutoDesconto;

            Console.Write("Informe o valor do produto: ");
            valorProduto = double.Parse(Console.ReadLine());

            Console.Write("Informe o desconto do produto:");
            descontoProduto = double.Parse(Console.ReadLine());

            valorProdutoDesconto = valorProduto * (descontoProduto / 100);
            valorProdutoDesconto = valorProduto - valorProdutoDesconto;

            Console.Write("O valor do produto com desconto é " + valorProdutoDesconto);

            Console.ReadKey(); //Mantém o console aberto enquanto o usuário não pressionar alguma tecla.
        }
    }
}
