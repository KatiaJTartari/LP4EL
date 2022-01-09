using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Inicio
    {
        static void Main(string[] args)
        {
            int opcao, codigo = 1;
            string nome, cpf;
            Cliente c = new Cliente();

            List<Cliente> clientes = new List<Cliente>();

            do
            {
                Console.Clear();
                Console.WriteLine("OPÇÕES:");
                Console.WriteLine("1- Inserir Cliente");
                Console.WriteLine("2- Alterar Cliente");
                Console.WriteLine("3- Excluir Cliente");
                Console.WriteLine("4- Consultar Clientes");
                Console.Write("Digite uma opção (0 para Sair): ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Informe o Nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Informe o CPF: ");
                        cpf = Console.ReadLine();
                        c = new Cliente();
                        if (c.SetCodigo(codigo) && c.SetNome(nome) && c.SetCpf(cpf))
                        {
                            clientes.Add(c);
                            Console.WriteLine("Cliente inserido!");
                            codigo++;
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Informe o código do cliente a ser alterado: ");
                        int cod = int.Parse(Console.ReadLine());

                        int numClientes = 0;
                        bool clienteExiste = false;
                        foreach (Cliente cli in clientes)
                        {
                            if (cli.GetCodigo() == cod)
                            {
                                clienteExiste = true;
                                Console.Write("Informe o nome (0 para mnter o mesmo):");
                                nome = Console.ReadLine();
                                Console.Write("Informe o CPF (0 para mnter o mesmo): ");
                                cpf = Console.ReadLine();

                                if (!nome.Equals("0") && !cpf.Equals("0"))
                                {
                                    if (c.SetNome(nome) && c.SetCpf(cpf))
                                       {
                                            clientes.RemoveAt(numClientes);
                                            clientes.Insert(numClientes, cli);
                                            Console.WriteLine("Cliente alterado!");
                                       }
                                }
                                else if (!nome.Equals("0") && cpf.Equals("0"))
                                {
                                    if (c.SetNome(nome))
                                    {
                                        clientes.RemoveAt(numClientes);
                                        clientes.Insert(numClientes, cli);
                                        Console.WriteLine("Cliente alterado!");
                                    }
                                }
                                else if (nome.Equals("0") && !cpf.Equals("0"))
                                {
                                    if (c.SetCpf(cpf))
                                    {
                                        clientes.RemoveAt(numClientes);
                                        clientes.Insert(numClientes, cli);
                                        Console.WriteLine("Cliente alterado!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Os dados do cliente não foram alterados!");
                                }
                                break;
                            }
                            numClientes++;
                        }
                        if (clienteExiste == false)
                        {
                            Console.WriteLine("Este cliente não existe!");
                            Console.ReadKey();
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Informe o código do cliente a ser excluído: ");
                        cod = int.Parse(Console.ReadLine());

                        numClientes = 0;
                        clienteExiste = false;
                        foreach (Cliente cli in clientes)
                        {
                            if (cli.GetCodigo() == cod)
                            {
                                clienteExiste = true;
                                clientes.RemoveAt(numClientes);
                                Console.WriteLine("Cliente excluído!");
                                break;
                            }
                            numClientes++;
                        }
                        if (clienteExiste == false)
                        {
                            Console.WriteLine("Este cliente não existe!");
                            Console.ReadKey();
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("CLIENTES ENCONTRADOS: ");
                        foreach (Cliente cli in clientes)
                            Console.WriteLine(cli.GetCodigo() + " - " +
                                              cli.GetNome() + " - " +
                                              cli.GetCpf());
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 0);
        }
    }
}
