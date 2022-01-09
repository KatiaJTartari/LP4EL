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
            Produto p = new Produto();

            bool erro;

            do
            {
                erro = false;
                Console.Write("Informe o Código: ");
                try
                {
                    p.SetCodigo(int.Parse(Console.ReadLine()));
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    erro = true;
                }
                finally
                {
                    Console.WriteLine("\nBem Vindo ao Sistema KJT!\n");
                }
            } while (erro);

            do
            {
                erro = false;
                Console.Write("Informe a descrição: ");
                try
                {
                    p.SetDescricao(Console.ReadLine());
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    erro = true;
                }
            } while (erro) ;

            do
            {
                 erro = false;
                 Console.Write("Informe o preço: ");
                 try
                 {
                     p.SetPreco(double.Parse(Console.ReadLine()));
                 }
                 catch (FormatException e)
                 {
                      Console.WriteLine(e.Message);
                      erro = true;
                 }
                 catch (ArgumentException e)
                 {
                     Console.WriteLine(e.Message);
                     erro = true;
                 }
            } while (erro);

            do
            {
                 erro = false;
                 Console.Write("Informe se o produto está ativo (true ou false): ");
                 try
                 {
                      p.SetAtivo(bool.Parse(Console.ReadLine()));
                 }
                 catch (FormatException e)
                 {
                      Console.WriteLine(e.Message);
                      erro = true;
                 }
            } while (erro);

            Console.WriteLine();
            Console.WriteLine(p.GetCodigo());
            Console.WriteLine(p.GetDescricao());
            Console.WriteLine("R$ " + p.GetPreco());
            Console.WriteLine(p.GetAtivo());

            Console.ReadKey();
        }
            
    }

    class Produto
    { 
        private int codigo;
        private string descricao;
        private double preco;
        private bool ativo;

       public int GetCodigo()
       {
           return this.codigo;
       }

       public string GetDescricao()
       {
           return this.descricao;
       }

       public double GetPreco()
       {
           return this.preco;
       }

       public bool GetAtivo()
       {
           return ativo;
       }

       public void SetCodigo(int codigo)
       {
           if (codigo < 1)
               throw new ArgumentException("O código deve ser maior ou igual a 1.");

           this.codigo = codigo;
       }

       public void SetDescricao(string descricao)
       {
            if (descricao.Length > 20)
                throw new ArgumentException("A descrição deve ter até 20 caracteres!");

            this.descricao = descricao;
       }

       public void SetPreco(double preco)
       {
            if (preco <= 0)
                throw new ArgumentException("O preço deve ser maior que R$ 0,00!");

            this.preco = preco;
       }

       public void SetAtivo(bool ativo)
       {
           this.ativo = ativo;
       }

    }
}


