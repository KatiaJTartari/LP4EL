using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Circulo : Forma
	{
		private double raio;
		
		public Circulo(double raio, string cor)
		{
			this.raio = raio;
			this.CalcularArea();
			base.ConfigurarCor(cor);
		}

		// Sobrescreve o método CalcularArea da classe Forma.
		protected override void CalcularArea()
		{
			this.Area = Math.Pow(raio, 2) * Math.PI;
			Console.Write("A área do Círculo é " + this.Area);
		}
	}
}
