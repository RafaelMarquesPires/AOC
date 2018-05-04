using AOC.memorias;
using System;
using System.Data;
using System.Windows.Forms;

namespace AOC.view
{
    public partial class CPU : Form
    {
        private Bloco[] Blocos;
        private Linha[] Linhas;
        private Estrutura[] EstruturaDados;
        private string Tecnica, Algoritmo;
        private long QuantidadeLinhas, QuantidadeBlocos, TamanhoBloco, Tempo;

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
            this.Tempo = 0;

            this.EstruturaDados = new Estrutura[this.QuantidadeLinhas];
            this.Blocos = new Bloco[QuantidadeBlocos];
            this.Linhas = new Linha[QuantidadeLinhas];
            
            /* Calcula tamanho Cache */
            double tamanhoCache = 0;
            double tag = 0;
            if (this.Tecnica == "DIRETA")
            {
                tag = Math.Log((QuantidadeBlocos / QuantidadeLinhas), 2);
                tamanhoCache = (tag + TamanhoBloco) * QuantidadeLinhas;
            }
            else //Associativa
            {
                tag = Math.Log(tamanhoRAM, 2);
                tamanhoCache = (tag + TamanhoBloco) * QuantidadeLinhas;
            }

            TamanhoTAG.Text = tag.ToString();
            TamanhoRAM.Text = tamanhoRAM.ToString() + " bytes";
            TamanhoCache.Text = tamanhoCache.ToString() + " bytes";

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
            memoriaRAMTabela.Columns.Add("TAG", typeof(string));
            memoriaRAMTabela.Columns.Add("Linha", typeof(string));

            for (long i = 0; i < this.QuantidadeBlocos; i++)
            {
                memoriaRAMTabela.Rows.Add(Blocos[i].id, Blocos[i].Tag, Blocos[i].Processo);
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
        private DataTable CriaTabelaRam(long quantidadeBlocos, long tamanhoBlocos) 
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
                else //ASSOCIATIVA
                {
                    long posicao = ProcuraEstruturaDadosContem(valor);
                    //Verifica se a cache tem espaço vazio
                    if (ProcuraEstruturaDadosVazio()) // true possui espaço
                    {
                        //Se tem, temos que verificar se o bloco ja esta na cache
                        if (posicao < 0) //Menor que zero, não possui na cache > 0 possui na cache
                        {
                            for (int j = 0; j < Linhas.Length; j++)
                            {
                                if (Linhas[j].Bloco < 0)
                                {
                                    EstruturaDados[j] = new Estrutura(valor, Tempo++, 0);
                                    Linhas[j].SetBloco(Blocos[valor]);
                                    Blocos[valor].Processo = "Memoria cache";
                                    break;
                                }
                            }
                        }
                        else
                        {
                            EstruturaDados[posicao].Tempo = Tempo++;
                            EstruturaDados[posicao].Quantidade++;
                        }
                    } //Memoria Cache cheia, começa o trabalho dos algoritmos
                    else
                    {
                        //Precisa checar se o bloco ja esta na cache
                       
                        if (posicao < 0) //Menor que zero, não possui na cache > 0 possui na cache
                        {

                        }
                        else
                        {
                            EstruturaDados[posicao].Tempo = Tempo++;
                            EstruturaDados[posicao].Quantidade++;
                        }

                        if (this.Algoritmo == "FIFO") //PRIMEIRO A ENTRAR É O PRIMEIRO A SAIR
                        {
                            Fifo();
                        }
                        MessageBox.Show("CHEIO");
                    }
                }
                AtualizaTabelas();
            }
        }
        private long Fifo()
        {
            //index do menor dado
            long index = -1;
            long tempo = 0;
            for (long i = 0; i < EstruturaDados.Length; i++)
            {
                if (tempio > EstruturaDados[i].Tempo){
            }
            }
            return 1;
        }
        private bool ProcuraEstruturaDadosVazio()
        {
            for (long i = 0; i < EstruturaDados.Length; i++)
            {
                if (EstruturaDados[i] == null)
                {
                    return true;
                }
            }
            return false;
        }
        private long ProcuraEstruturaDadosContem(long id)
        {
            for (long i = 0; i < EstruturaDados.Length; i++)
            {
                if (EstruturaDados[i] != null)
                {
                    if (EstruturaDados[i].id == id)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        private string GerarStringAleatorio(long quantidade)
        {
            string stringGerada = string.Empty;
            Random random = new Random();
            for (long i = 0; i < quantidade; i++)
            {
                stringGerada += (char)random.Next(01, 26);
            }
            return stringGerada;
        }
    }
}