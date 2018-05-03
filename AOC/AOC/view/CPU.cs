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
            this.QuantidadeBlocos = tamanhoRAM / TamanhoBloco;
            
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
                tag = Math.Log(tamanhoRAM, 2);
                tamanhoCache = (tag + TamanhoBloco) * QuantidadeLinhas;
                TamanhoCache.Text = tamanhoCache.ToString() + " bytes";
            }
            TamanhoTAG.Text = tag.ToString();

            /*Cria tabela RAM e Cache */
            MemoriaCache.DataSource = CriaTabelaCache(QuantidadeLinhas, TamanhoBloco);
            MemoriaRam.DataSource = CriaTabelaRam(QuantidadeBlocos, TamanhoBloco);
        }
        private void AtualizaTabelas()
        {
            MemoriaCache.DataSource = AtualizaTabelaCache();
            MemoriaRam.DataSource = AtualizaTabelaRam();
        }
        private DataTable AtualizaTabelaCache()
        {
            DataTable memoriaCacheTabela = new DataTable();
            memoriaCacheTabela.Columns.Add("id", typeof(int));
            memoriaCacheTabela.Columns.Add("Numero Bloco", typeof(string));
            memoriaCacheTabela.Columns.Add("Processo", typeof(string));

            for (int i = 0; i < this.QuantidadeLinhas; i++)
            {
                string bloco;
                if (Linhas[i].Bloco < 0)
                {
                    bloco = " ";
                }
                else
                {
                    bloco = Linhas[i].Bloco.ToString();
                }
                memoriaCacheTabela.Rows.Add(Linhas[i].id, bloco, Linhas[i].Processo);
            }
            return memoriaCacheTabela;
        }
        private DataTable AtualizaTabelaRam() //ERRO FILHA DA PUTA 
        {
            DataTable memoriaRAMTabela = new DataTable();
            memoriaRAMTabela.Columns.Add("id", typeof(int));
            memoriaRAMTabela.Columns.Add("Bloco", typeof(string));
            memoriaRAMTabela.Columns.Add("Linha", typeof(string));

            if (Tecnica == "DIRETA")
            {
                for (long i = 0; i < this.QuantidadeBlocos; i++)
                {
                    memoriaRAMTabela.Rows.Add(Blocos[i].id, Blocos[i].Tag, Blocos[i].Processo);
                }
            }
            else
            {/*
                for (long i = 0; i < quantidadeBlocos; i++)
                {
                    Blocos[i] = new Bloco(i, 0, GerarStringAleatorio(tamanhoBlocos));
                    MemoriaRAMTabela.Rows.Add(Blocos[i].id, Blocos[i].Tag, Blocos[i].Processo);
                }
                */
            }
            return memoriaRAMTabela;
        }

        /* CRIAR TABELA INICIAL */
        private DataTable CriaTabelaCache(long linhas, long tamanhoBloco)
        {
            DataTable memoriaCacheTabela = new DataTable();
            memoriaCacheTabela.Columns.Add("id", typeof(int));
            memoriaCacheTabela.Columns.Add("Numero Bloco", typeof(string));
            memoriaCacheTabela.Columns.Add("Processo", typeof(string));

            for (int i = 0; i < linhas; i++)
            {
                Linhas[i] = new Linha(i, -1, null);
                string bloco;
                if (Linhas[i].Bloco < 0)
                {
                    bloco = " ";
                }
                else
                {
                    bloco = Linhas[i].Bloco.ToString();
                }
                memoriaCacheTabela.Rows.Add(Linhas[i].id, bloco, Linhas[i].Processo);
            }
            return memoriaCacheTabela;
        }
        private DataTable CriaTabelaRam(long quantidadeBlocos, long tamanhoBlocos) //ERRO FILHA DA PUTA 
        {
            DataTable memoriaRAMTabela = new DataTable();
            memoriaRAMTabela.Columns.Add("id", typeof(long));
            memoriaRAMTabela.Columns.Add("Tag", typeof(long));
            memoriaRAMTabela.Columns.Add("Processo ", typeof(string));

            if (Tecnica == "DIRETA")
            {
                for (long i = 0; i < quantidadeBlocos; i++)
                {
                    Blocos[i] = new Bloco(i, (i % QuantidadeLinhas), GerarStringAleatorio(tamanhoBlocos));
                    memoriaRAMTabela.Rows.Add(Blocos[i].id, Blocos[i].Tag, Blocos[i].Processo);
                }
            }
            else
            {
                for (long i = 0; i < quantidadeBlocos; i++)
                {
                    Blocos[i] = new Bloco(i, 0, GerarStringAleatorio(tamanhoBlocos));
                    memoriaRAMTabela.Rows.Add(Blocos[i].id, Blocos[i].Tag, Blocos[i].Processo);
                }
            }
            return memoriaRAMTabela;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] carga = CargaBloco.Text.Split(';');
            for (int i = 0; i < carga.Length; i++)
            {
                Int64 valor = Convert.ToInt64(carga[i]);
                if (this.Tecnica == "DIRETA")
                {
                    long tag = Blocos[valor].Tag;
                    if (Linhas[Blocos[valor].Tag].Bloco < 0)
                    {
                        Linhas[tag].SetBloco(Blocos[valor]);
                        Blocos[valor].Processo = "Memoria cache";
                    }
                    else
                    {
                        Blocos[Linhas[tag].Bloco].Processo = Linhas[tag].Processo;
                        Linhas[Blocos[valor].Tag].SetBloco(Blocos[valor]);
                        Blocos[valor].Processo = "Memoria cache";
                    }
                    
                }
                else
                {
                    /*     Blocos[valor].Processo = "Memoria cache";
                         Linhas[valor % this.QuantidadeLinhas] = new Linha(Blocos[valor]);*/
                }
                AtualizaTabelas();
            }
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
