using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Retangulo : Forma
    {
		private double baseRetangulo, altura;
		
        public Retangulo(double baseRetangulo, double altura, string cor)
		{
			this.baseRetangulo = baseRetangulo;
			this.altura = altura;
			this.CalcularArea();
			base.ConfigurarCor(cor);
		}

		// Sobrescreve o método CalcularArea da classe Forma.
		protected override void CalcularArea()
		{
			base.Area = this.baseRetangulo * this.altura;
			Console.Write("A área do Retângulo é " + base.Area);
		}
	}
}
	