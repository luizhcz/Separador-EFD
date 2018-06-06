using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Separador
{
    public class Restricoes
    {
        public List<string> arquivos { get; private set; }

        public Restricoes() {
        }



        private static bool verifica(string arquivo)
        {
            string aux;
            int i = arquivo.IndexOf("EFD");
            aux = arquivo.Substring(i+3).Replace("-","");
            if (aux[0] == '0' && aux[1] == '0' && aux[2] == '0' && aux[3] == '0')
                return false;
            if (aux[0] == '0' && aux[1] == '0' && aux[2] == '0' && aux[3] == '5')
                return false;
            if (aux[0] == '0' && aux[1] == '1' && aux[2] == '0' && aux[3] == '0')
                return false;
            if (aux[0] == '9')
                return false;
            if (aux[0] == '1')
                return false;
            if (aux[0] == 'e' || aux[0] == 'E')
                return false;
            if (aux[0] == 'g' || aux[0] == 'G')
                return false;
            if (aux[0] == 'h' || aux[0] == 'H')
                return false;
            if (aux[0] == 'k' || aux[0] == 'K')
                return false;

            return true;
        }

        public string[] restricao(string[] arquivo)
        {
            string aux;
            string[] retorn;
            arquivos = new List<string>();
            foreach (string item in arquivo)
            {
                aux = nomeArquivo(item);
                if (aux.Contains("EFD"))
                {
                    if (verifica(aux))
                    {
                        arquivos.Add(item);
                    }
                }
            }
            retorn = (String[])arquivos.ToArray();

            return retorn;
        }


        private string nomeArquivo(string arquivo)
        {
                    int cont = 0; string aux;
                    for (int i = 0; i < arquivo.Length ; i++)
                    {
                        if (arquivo[i] == '\\') cont++;

                    }
                    aux = arquivo.Split('\\')[cont];
            return aux.Substring(0, aux.Length - 4);
        }
    }
}
