using System.Collections.Generic;

namespace Colecoes.Helper
{
    public class OperacoesLIsta
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Ìndice {i}, Valor: {lista[i]}");
            }

        }

        
    }
}