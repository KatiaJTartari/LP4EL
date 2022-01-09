/*Exercício 3 -  Escreva uma aplicação console em C# que leia 
  duas notas e retorne a média do aluno. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            Console.Write("Informe a 1ª Nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a 2ª Nota: ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.Write("A média do aluno é " + media);

            Console.ReadKey(); //Mantém o console aberto enquanto o usuário não pressionar alguma tecla.
        }
    }
}
