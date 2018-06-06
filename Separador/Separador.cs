using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Separador
{
    public class Separador
    {
        public string text { get; set; }
        public StreamReader leitor { get; set; }
        public Decimal Qtde { get; set; }
        public string nome { get; set; }

        public Separador(string text)
        {
            this.text = text;
            Qtde = -1;
            Separar();
        }


        public void Separar()
        {
            try
            {
                leitor = new StreamReader(text);
                string line = "";
                while (line != null)
                {
                    line = leitor.ReadLine();
                    if (line == null) return;
                    if (line.Contains("#QUANT"))
                    {
                        int i = line.IndexOf("#");
                        string aux = line.Substring(i);
                        aux = aux.Replace("#","").Replace("Q","").Replace("U","").Replace("A","").Replace("N","").Replace("T","").Replace("=","").Replace("-", "").Replace("|", "").Trim() ;
                        Qtde = Convert.ToDecimal(aux.Substring(0, 1));
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
            
            
        }


        public void Fold1(string source , string destinatario)
        {
            int cont = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == '\\') cont++;
                    
            }
            string nome = source.Split('\\')[cont];
            this.nome = nome;
            Copiar(source,destinatario,nome);
        }

        public void Fold2(string source, string destinatario)
        {
            int cont = 0;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] == '\\') cont++;

            }
            string nome = source.Split('\\')[cont];
            Copiar(source, destinatario, nome);
        }



        private void Copiar(string source, string destinatario, string nome)
        {
            string saida = Path.Combine(destinatario, nome).Replace('\\','/');

           
            File.Copy(source, saida, true);
        }




    }
}
