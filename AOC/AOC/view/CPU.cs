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
        private Bloco[] Blocos;
        private Linha[] Linhas;
        private string Tecnica;
        private string Algoritmo;
        private long QuantidadeLinhas, QuantidadeBlocos, TamanhoBloco;
        private DataTable MemoriaCacheTabela = new DataTable();
        private DataTable MemoriaRAMTabela = new DataTable();

        public CPU()
        {
            InitializeComponent();
        }
        public void SetDados(long tamanhoRAM, long tamanhoBloco, long quantidadeLinha, string tecnica, string algoritmo)
        {
            this.Tecnica = tecnica.ToUpper();
            this.Algoritmo = algoritmo.ToUpper();
            this.QuantidadeLinhas = quantidadeLinha;
            this.TamanhoBloco = tamanhoBloco;

            /* Cria blocos e valores */
            long QuantidadeBlocos = tamanhoRAM / TamanhoBloco;
            Blocos = new Bloco[QuantidadeBlocos];
            Linhas = new Linha[QuantidadeLinhas];
            TamanhoRAM.Text = tamanhoRAM.ToString() + " bytes";

            /* Calcula tamanho Cache */
            double tamanhoCache = 0;
            double tag = 0;
            if (this.Tecnica == "DIRETA")
            {
                tag = Math.Log((QuantidadeBlocos / QuantidadeLinhas), 2);
                tamanhoCache = (tag + TamanhoBloco) * QuantidadeLinhas;
                TamanhoCache.Text = tamanhoCache.ToString() + " bytes";
            }
            else //Associativa
            {
                tag = Math.Log(tamanhoRAM , 2);
                tamanhoCache = (tag + TamanhoBloco) * QuantidadeLinhas;
                TamanhoCache.Text = tamanhoCache.ToString() + " bytes";
            }
            TamanhoTAG.Text = tag.ToString();

            /*Cria tabela RAM e Cache */
            AtualizaTabelas();
        }
        private void AtualizaTabelas()
        {
            MemoriaRam.DataSource = DadosTabelaRam(QuantidadeBlocos, TamanhoBloco);
            MemoriaCache.DataSource = DadosTabelaCache(QuantidadeLinhas, TamanhoBloco);
        }
        private DataTable DadosTabelaCache(long linhas, long tamanhoBloco)
        {
            MemoriaCacheTabela.Columns.Add("id", typeof(int));
            MemoriaCacheTabela.Columns.Add("TAG", typeof(string));
            MemoriaCacheTabela.Columns.Add("Linha", typeof(string));

            for (int i = 0; i < linhas; i++)
            {
                MemoriaCacheTabela.Rows.Add(i, null, GerarStringAleatorio(tamanhoBloco));
            }
            return MemoriaCacheTabela;
        }
        private DataTable DadosTabelaRam(long quantidadeBlocos, long tamanhoBlocos)
        {
            MemoriaRAMTabela.Columns.Add("id", typeof(long));
            MemoriaRAMTabela.Columns.Add("Tag", typeof(long));
            MemoriaRAMTabela.Columns.Add("Processo ", typeof(string));
            if (Tecnica == "DIRETA")
            {
                for (long i = 0; i < quantidadeBlocos; i++)
                {
                    Blocos[i] = new Bloco(i, (i % QuantidadeLinhas), GerarStringAleatorio(tamanhoBlocos));
                    MemoriaRAMTabela.Rows.Add(i, (i % QuantidadeLinhas), GerarStringAleatorio(tamanhoBlocos));
                }
            }
            else
            {
                for (long i = 0; i < quantidadeBlocos; i += tamanhoBlocos)
                {
                    MemoriaRAMTabela.Rows.Add(i, 0, GerarStringAleatorio(tamanhoBlocos));
                }
            }
            return MemoriaCacheTabela;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int carga = Convert.ToInt32(CargaBloco.Text);
            if (this.Tecnica == "DIRETA")
            {
                MemoriaCacheTabela.Rows[(int)(carga % QuantidadeLinhas)].SetParentRow(MemoriaRAMTabela.Rows[carga]);
                MemoriaRAMTabela.Rows[carga].SetField("Processo", "Memoria Cache");

            }
            else
            {
                MessageBox.Show("nÃIO IMPLEMENTADO");
            }
            AtualizaTabelas();
          //  CargaBloco.Text;
        }
        private string GerarStringAleatorio(long quantidade)
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
