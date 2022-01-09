using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
	abstract class Forma
	{
		protected string Cor { get; set; }

		protected double Area { get; set; }


		//Métodos
		protected void ConfigurarCor(string cor)
		{
			this.Cor = cor;
			Console.WriteLine(" e sua cor é " + this.Cor + ".\n");
		}

		/* Para indicar que um método é abstrato, deve-se usar a palavra reservada
		   abstract antes do tipo de retorno do método. */
		protected abstract void CalcularArea();

	}

}

