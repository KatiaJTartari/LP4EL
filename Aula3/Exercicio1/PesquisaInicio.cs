using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class PesquisaInicio : Pesquisa
	{
		// Sobrescreve o método "BuscarString" da classe mãe (Pesquisa).
		public sealed override bool BuscarString(string cadeiaCaracteres)
		{
			if (GetTexto().StartsWith(cadeiaCaracteres))
				return true;
			//else  //Não precisa do else
			return false;
		}
	}
}

