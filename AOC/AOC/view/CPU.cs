using AOC.memorias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOC.view
{
    public partial class CPU : Form
    {
        Bloco[] Blocos;
        Linha[] Linhas;

        public CPU()
        {
            InitializeComponent();
        }

        public void SetDados(Int64 tamanhoRAM, Int64 tamanhoBloco, Int64 quantidadeLinha, string tecnica, string algotiritmo)
        {
            Blocos = new Bloco[tamanhoRAM / tamanhoBloco];
            Linhas = new Linha[quantidadeLinha];
            TamanhoRAM.Text = tamanhoRAM.ToString() + " bytes";

            /* Calcula tamanho ram */
            double tamanhoCache = 0;
            double tag = 0;
            if (tecnica.ToUpper() == "DIRETA")
            {
                tag = Math.Log((tamanhoBloco / quantidadeLinha), 2);
                tamanhoCache = (tag + tamanhoBloco) * quantidadeLinha;
                TamanhoCache.Text = tamanhoCache.ToString() + " bytes";
            }
            else //Associativa
            {
                tag = Math.Log(tamanhoRAM , 2);
                tamanhoCache = tag + (tamanhoBloco * tamanhoBloco);
                TamanhoCache.Text = tamanhoCache.ToString() + " bytes";
            }

            MessageBox.Show(tag.ToString());
            MemoriaRam.DataSource = DadosTabelaRam(tamanhoRAM, tamanhoBloco, quantidadeLinha);
            MemoriaCache.DataSource = DadosTabelaCache(quantidadeLinha, tamanhoBloco);




        }
        private DataTable DadosTabelaCache(Int64 linhas, Int64 tamanhoBloco)
        {
            DataTable memoriaCache = new DataTable();
            memoriaCache.Columns.Add("id", typeof(int));
            memoriaCache.Columns.Add("TAG", typeof(string));
            memoriaCache.Columns.Add("Linha", typeof(string));

            for (int i = 0; i < linhas; i++)
            {
                memoriaCache.Rows.Add(i, null, GerarStringAleatorio(tamanhoBloco));
            }
            return memoriaCache;
        }
        private DataTable DadosTabelaRam(Int64 tamanhoRam, Int64 tamanhoBloco, Int64 quantidadeLinhas)
        {
            DataTable memoriaCache = new DataTable();
            memoriaCache.Columns.Add("id", typeof(int));
            memoriaCache.Columns.Add("TAG", typeof(int));
            memoriaCache.Columns.Add("Linha", typeof(string));

            for (Int64 i = 0; i < tamanhoRam; i += tamanhoBloco)
            {
                memoriaCache.Rows.Add(i, (i % quantidadeLinhas), GerarStringAleatorio(tamanhoBloco));
            }
            return memoriaCache;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          //  CargaBloco.Text;
        }
        private string GerarStringAleatorio(Int64 quantidade)
        {
            string stringGerada = string.Empty;
            Random random = new Random();
            for (int i = 0; i < quantidade; i++)
            {
                stringGerada += (char)random.Next(01, 26);
            }
            return stringGerada;
        }

    }
}
