using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
   	class Retangulo : IForma
	{
		private double area, baseRetangulo, altura;
		private string cor;
		
		public Retangulo(double b, double h, string c)
		{
			this.baseRetangulo = b;
			this.altura = h;
			this.CalcularArea();
			this.ConfigurarCor(c);
		}
			
		public void CalcularArea()
		{
			this.area = this.baseRetangulo * this.altura;
			Console.Write("A área do Retângulo é " + this.area);
		}

		public void ConfigurarCor(string cor)
		{
			this.cor = cor;
			Console.WriteLine(" e sua cor é " + this.cor + ".\n");
		}

	}

}
