using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Pesquisa
    {
		private static string texto;

		public string GetTexto()
		{
			return texto;
		}

		public void SetTexto(string text)
		{
			texto = text;
		}

		public virtual bool BuscarString(string cadeiaCaracteres)
		{ // Implementação genérica
			if (texto.Contains(cadeiaCaracteres))
				return true;
			//else  //Não precisa do else
			return false;
		}
	}
}

