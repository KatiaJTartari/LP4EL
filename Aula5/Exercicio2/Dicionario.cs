using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Dicionario
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> funcionarios = new Dictionary<string, decimal>();
            string nome;
            decimal salario;
            int opcao;
            int quantElementos;

            do
            {
                Console.WriteLine("1 - Adicionar um Funcionário ");
                Console.Write("Informe a quantidade de elementos que deseja adicionar " +
                              "no dicionário: ");
                quantElementos = int.Parse(Console.ReadLine());
                               
                for (int i = 0; i < quantElementos; i++)
                {
                    //Console.WriteLine((i + 1) + "º Funcionário: ");
                    Console.WriteLine();
                    Console.Write("Informe o nome do funcionário: ");
                    nome = Console.ReadLine();
                    Console.Write("Informe o salário do funcionário: ");
                    salario = decimal.Parse(Console.ReadLine());

                    funcionarios.Add(nome, salario);
                }

                foreach (KeyValuePair<string, decimal> f in funcionarios)
                    Console.WriteLine(f); 
                    Console.WriteLine();


                Console.WriteLine("2 - Alterar o salário de um Funcionário ");
                try
                {
                    Console.Write("Informe o nome do funcionário que deseja alterar o salário: ");
                    nome = Console.ReadLine();

                    if (funcionarios.ContainsKey(nome)) {
                        Console.Write("Informe o novo salário do funcionário: ");
                        salario = decimal.Parse(Console.ReadLine());
                        funcionarios[nome] = salario;
                        Console.WriteLine("Salário alterado com sucesso!");
                    }
                    else
                        Console.WriteLine("Este funcionário não existe!");
                } catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                
                foreach (KeyValuePair<string, decimal> f in funcionarios)
                    Console.WriteLine(f); Console.WriteLine();


                Console.WriteLine("3 - Remover um Funcionário ");
                try
                {
                    Console.Write("Informe o nome do funcionário que deseja remover: ");
                    nome = Console.ReadLine();
                    if (funcionarios.ContainsKey(nome))
                    {
                        funcionarios.Remove(nome);
                        Console.WriteLine("Funcionário removido com sucesso!");
                    }
                    else
                        Console.WriteLine("Este funcionário não existe!");
                } catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }

                foreach (KeyValuePair<string, decimal> f in funcionarios)
                    Console.WriteLine(f); Console.WriteLine();


                Console.WriteLine("4 - Verificar a Existência de um Funcionário ");

                Console.Write("Informe o nome do funcionário que deseja verificar: ");
                nome = Console.ReadLine();

                if (funcionarios.ContainsKey(nome))
                    Console.WriteLine("A coleção tem este funcionário!");
                else
                    Console.WriteLine("A coleção não tem este funcionário!");


                Console.WriteLine("\n5 - Verificar a Existência de um Salário ");

                Console.Write("Informe o salário que deseja verificar: ");
                salario = decimal.Parse(Console.ReadLine());

                if (funcionarios.ContainsValue(salario))
                    Console.WriteLine("A coleção tem este salário!");
                else
                    Console.WriteLine("A coleção não tem este salário!");


                Console.Write("\nDigite 0 para sair do programa ou 1 para continuar: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

            } while (opcao != 0);

            Console.ReadKey();
        }
    }
}
