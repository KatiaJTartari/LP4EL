using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
   	class Circulo : IForma
	{
		private double area, raio;
		private string cor;
				
		public Circulo(double raio, string cor)
		{
			this.raio = raio;
			this.CalcularArea();
			this.ConfigurarCor(cor);
		}

		public void CalcularArea()
		{
			this.area = Math.Pow(raio, 2) * Math.PI;
			Console.Write("A área do Círculo é " + this.area);
		}

		public void ConfigurarCor(string cor)
		{
			this.cor = cor;
			Console.WriteLine(" e sua cor é " + this.cor + ".\n");
		}

	}

}
