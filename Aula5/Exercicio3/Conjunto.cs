using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Conjunto
    {
        static void Main(string[] args)
        {
            HashSet<string> conjunto1 = new HashSet<string>();
            HashSet<string> conjunto2 = new HashSet<string>();

            int opcao;
            string nomeProduto;
            int quantProdutos;

            do
            {

                Console.Write("Informe a quantidade de produtos para o conjunto 1: ");
                quantProdutos = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe os nomes dos produtos para o conjunto 1: ");
                for (int i = 0; i < quantProdutos; i++)
                {
                    Console.Write((i + 1) + "º produto: ");
                    nomeProduto = Console.ReadLine();
                    conjunto1.Add(nomeProduto);
                }

                Console.Write("\nInforme a quantidade de produtos para o conjunto 2: ");
                quantProdutos = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe os nomes dos produtos para o conjunto 2: ");
                for (int i = 0; i < quantProdutos; i++)
                {
                    Console.Write((i + 1) + "º produto: ");
                    nomeProduto = Console.ReadLine();
                    conjunto2.Add(nomeProduto);
                }

                Console.WriteLine("\nConjunto 1: ");
                foreach (string c1 in conjunto1)
                    Console.Write(c1 + ", "); Console.WriteLine();
                Console.WriteLine("Conjunto 2: ");
                foreach (string c2 in conjunto2)
                    Console.Write(c2 + ", "); Console.WriteLine();

                Console.WriteLine("\n1 - Remover um produto do 1º conjunto.");
                try
                {
                    Console.Write("Informe o nome do produto que deseja remover: ");
                    nomeProduto = Console.ReadLine();
                    if (conjunto1.Contains(nomeProduto))
                    {
                        conjunto1.Remove(nomeProduto);
                        Console.WriteLine("Produto removido com sucesso!");
                    }
                    else
                        Console.WriteLine("Este produto não existe!");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("\nConjunto 1: ");
                foreach (string c1 in conjunto1)
                    Console.Write(c1 + ", "); Console.WriteLine();
                Console.WriteLine("Conjunto 2: ");
                foreach (string c2 in conjunto2)
                    Console.Write(c2 + ", "); Console.WriteLine();

                Console.WriteLine("\n2 - Mostrar os produtos em comum nos dois conjuntos.");
                conjunto1.IntersectWith(conjunto2);
                Console.WriteLine("\nConjunto 1: ");
                foreach (string c1 in conjunto1)
                    Console.Write(c1 + ", "); Console.WriteLine();
                Console.WriteLine("Conjunto 2: ");
                foreach (string c2 in conjunto2)
                    Console.Write(c2 + ", "); Console.WriteLine();

                Console.WriteLine("\n3 - Juntar os produtos dos dois conjuntos.");
                conjunto1.UnionWith(conjunto2);
                Console.WriteLine("\nConjunto 1: ");
                foreach (string c1 in conjunto1)
                    Console.Write(c1 + ", "); Console.WriteLine();
                Console.WriteLine("Conjunto 2: ");
                foreach (string c2 in conjunto2)
                    Console.Write(c2 + ", "); Console.WriteLine();

                Console.WriteLine("\n4 - Subtrair o 1º conjunto do 2º conjunto.");
                conjunto1.ExceptWith(conjunto2);
                Console.WriteLine("\nConjunto 1: ");
                foreach (string c1 in conjunto1)
                    Console.Write(c1 + ", "); Console.WriteLine();
                Console.WriteLine("Conjunto 2: ");
                foreach (string c2 in conjunto2)
                    Console.Write(c2 + ", "); Console.WriteLine();

                Console.WriteLine("\n5 - Verificar se o 1º conjunto está contido no 2º.");
                if (conjunto1.IsSubsetOf(conjunto2))
                    Console.WriteLine("O conjuto 1 está contido no conjunto 2. ");
                else
                    Console.WriteLine("O conjuto 1 não está contido no conjunto 2. ");

                Console.WriteLine("\n6 - Verificar se o 1º conjunto contém o 2º.");
                if (conjunto1.IsSupersetOf(conjunto2))
                    Console.WriteLine("O conjuto 1 está contém o conjunto 2. ");
                else
                    Console.WriteLine("O conjuto 1 não contém o conjunto 2. ");

                Console.Write("\nDigite 0 para sair do programa ou 1 para continuar: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

            } while (opcao != 0);

            Console.ReadKey();
        }
    }
}