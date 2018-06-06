using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;




namespace Separador
{
    public partial class Form1 : Form
    {
        public int cont { get; set; }
        public int qtdAquivos { get; set; }
        public string[] arquivos { get; set; }
        public string Folder1 { get; set; }
        public string Folder2 { get; set; }
        public string sourceFile { get; set; }
        public string DestinationFile { get; set; }
        public string naoVerificador { get; set; }
        Separador S;

        public Form1()
        {
            InitializeComponent();
            cont =0;
        }

        private void procurar_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBox1.Text = folderBrowserDialog1.SelectedPath;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro :" + ex.Message);
                }
            }

        }

        private void separar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {

            }
            else
            {
                try
                {
                    qtdAquivos = Directory.GetFiles(textBox1.Text, "*.txt", SearchOption.TopDirectoryOnly).Length;
                    arquivos = Directory.GetFiles(textBox1.Text, "*.txt" , SearchOption.TopDirectoryOnly);
                    qtd.Text = "Qtd  = " + qtdAquivos;
                    

                    Folder1 = textBox1.Text + "\\quantidade_maior_que_zero";
                    Folder2 = textBox1.Text + "\\quantidade_igual_a_zero";
                    
                    if (Directory.Exists(Folder1))
                    {
                        if(MessageBox.Show(null, "O Diretório 'quantidade_maior_que_zero' ja existe deseja deletar ?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Directory.Delete(Folder1, true);
                        }
                        else
                        {
                            MessageBox.Show("O programa será finalizado. Não é possivel separar sem um diretório!");
                            Close();
                        }
                    }
                    if (Directory.Exists(Folder2))
                    {
                        if (MessageBox.Show(null, "O Diretório 'quantidade_igual_a_zero' ja existe deseja deletar ?", "Deletar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Directory.Delete(Folder2, true);
                        }
                        else
                        {
                            MessageBox.Show("O programa será finalizado. Não é possivel separar sem um diretório!");
                            Close();
                        }
                    }

                    Directory.CreateDirectory(Folder1);
                    Directory.CreateDirectory(Folder2);
                    progresso.Maximum = qtdAquivos;

                    foreach (string item in arquivos)
                    {
                        cont++;
                        lblcont.Text = "Verificando " + cont + " de " + qtdAquivos; 
                        S = new Separador(item);
                        if (S.Qtde > 0)
                        {
                            S.Fold1(item, Folder1);
                        }
                        else if (S.Qtde == 0)
                        {
                            S.Fold2(item, Folder2);
                        }
                        else
                        {
                            cont--;
                            naoVerificador += "\n" + item.ToString() ;
                        }
                        progresso.Value++;
                    }

                    pictureBox1.BackColor = Color.Green;
                    lblcont.Text = "Finalizado " + cont;
                    txtErros.Text = naoVerificador;
                    procurar.Enabled = false;
                    separar.Enabled = false;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro :" + ex.Message + "\nNo arquivo: " + arquivos[cont]);
                }
            }
        }

        private void novo_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            txtErros.Clear();
            cont = 0;
            naoVerificador = "";
            separar.Enabled = true;
            procurar.Enabled = true;
            qtd.Text = "Qtd = 0";
            pictureBox1.BackColor = Color.Red;
            lblcont.Text = "Parado";
            progresso.Value = 0;
        }
    }
}
