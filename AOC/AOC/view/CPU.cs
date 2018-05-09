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
        private long QuantidadeLinhas, QuantidadeBlocos, TamanhoBloco;
        //Suporte algoritmo
        private long Entrada, Tempo;
        //Form
        private Entradas Parente;
        private Relatorio RelatorioObj;

        public CPU()
        {
            InitializeComponent();
        }
        public void SetDados(Entradas parent, long tamanhoRAM, long tamanhoBloco, long quantidadeLinha, string tecnica, string algoritmo)
        {
            RelatorioObj = new Relatorio();
            RelatorioObj.Visible = true;
            this.Parente = parent;
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
                tag = Math.Log(QuantidadeLinhas, 2);
                tamanhoCache = (tag + TamanhoBloco) * QuantidadeLinhas;
            }

            TamanhoTAG.Text = tag.ToString();
            TamanhoRAM.Text = tamanhoRAM.ToString() + " bytes";
            TamanhoCache.Text = tamanhoCache.ToString() + " bytes";

            /* Inicializar os arrays */
            InicializaArray();

            /* Cria tabela RAM e Cache */
            AtualizaTabelas();

            RelatorioObj.InserirTexto("Programa inicializado ");
            RelatorioObj.InserirTexto("Tecnica: " + this.Tecnica);
            RelatorioObj.InserirTexto("Algoritmo: " + this.Algoritmo);
            RelatorioObj.InserirTexto("");
        }
        private void InicializaArray()
        {
            for (long i = 0; i < this.QuantidadeLinhas; i++)
            {
                EstruturaDados[i] = new Estrutura(-1, 0, 0, 0);
                Linhas[i] = new Linha(i, -1, null);
            }
            if (Tecnica == "DIRETA")
            {
                for (long i = 0; i < QuantidadeBlocos; i++)
                {
                    Blocos[i] = new Bloco(i, (i % QuantidadeLinhas), GerarStringAleatorio(TamanhoBloco));
                }
            }
            else
            {
                for (long i = 0; i < QuantidadeBlocos; i++)
                {
                    Blocos[i] = new Bloco(i, 0, GerarStringAleatorio(TamanhoBloco));
                }
            }
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
        private DataTable AtualizaTabelaRam() 
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (CargaBloco.Text != "")
            {
                CarregaBlocos();
            }
        }
        private void CarregaBlocos()
        {
            string[] carga = CargaBloco.Text.Split(';');
            CargaBloco.Text = "";
            for (int i = 0; i < carga.Length; i++)
            {
                if (int.TryParse(carga[i], out int n))
                {
                    Int64 valor = Convert.ToInt64(carga[i]);
                    if (valor > QuantidadeBlocos)
                    {
                        MessageBox.Show("Numero do bloco informado excede quantidade de blocos da memoria RAM");
                    }
                    else
                    {
                        if (this.Tecnica == "DIRETA")
                        {
                            long tag = Blocos[valor].Tag;
                            if (Linhas[Blocos[valor].Tag].Bloco < 0) 
                            {
                                Linhas[tag].SetBloco(Blocos[valor]);
                                Blocos[valor].Processo = "Memoria cache";

                                RelatorioObj.InserirTexto("Bloco: " + valor + " foi para cache na linha:" + tag);
                            }
                            else //Subtitui
                            {
                                Blocos[Linhas[tag].Bloco].Processo = Linhas[tag].Processo;
                                Linhas[Blocos[valor].Tag].SetBloco(Blocos[valor]);
                                Blocos[valor].Processo = "Memoria cache";

                                RelatorioObj.InserirTexto("Bloco: " + tag + " foi retirado da cache");
                                RelatorioObj.InserirTexto("Bloco: " + valor + " foi para cache na linha:" + tag);
                            }

                        }
                        else //ASSOCIATIVA
                        {
                            long posicao = ProcuraEstruturaDadosContem(valor);
                            //MessageBox.Show("nUMERO " + posicao.ToString());
                            //Verifica se a cache tem espaço vazio
                            if (ProcuraEstruturaDadosVazio()) // true possui espaço
                            {
                                //Se tem, temos que verificar se o bloco ja esta na cache
                                if (posicao < 0) //Menor que zero, não possui na cache > 0 possui na cache
                                {
                                    for (int j = 0; j < Linhas.Length; j++)
                                    {
                                        if (Linhas[j].Bloco < 0) // nao possui set novo
                                        {
                                            EstruturaDados[j].id = valor;
                                            EstruturaDados[j].Entrada = Entrada++; // so acontece quando é enviado para cache
                                            EstruturaDados[j].Tempo = Tempo++;
                                            EstruturaDados[j].Quantidade = 1;
                                            Linhas[j].SetBloco(Blocos[valor]);
                                            Blocos[valor].Processo = "Memoria cache";
                                            RelatorioObj.InserirTexto("Bloco: " + valor + " foi para cache na linha:" + j);
                                            break;
                                        }
                                    }
                                }
                                else //Possui na memoria cache, ira acontecer nada
                                {
                                    EstruturaDados[posicao].Tempo = Tempo++;
                                    EstruturaDados[posicao].Quantidade = EstruturaDados[posicao].Quantidade +1;

                                    RelatorioObj.InserirTexto("Bloco: " + posicao + " ja esta na cache ");
                                }
                            }
                            else //Memoria Cache cheia, começa o trabalho dos algoritmos
                            {
                                //Precisa checar se o bloco ja esta na cache
                                if (posicao >= 0) //Maior que 0, ja esta na cache, não precisa mecher em nada
                                {
                                    EstruturaDados[posicao].Tempo = Tempo++;
                                    EstruturaDados[posicao].Quantidade = EstruturaDados[posicao].Quantidade + 1;
                                    RelatorioObj.InserirTexto("Bloco: " + posicao + " ja esta na cache ");
                                    // MessageBox.Show("jA TEM NA CACHE: " + EstruturaDados[posicao].Quantidade.ToString());
                                }
                                else //Não possui na cache precisa fazer a troca
                                {
                                    long indexSubtituir = -1;
                                    if (this.Algoritmo == "FIFO") //PRIMEIRO A ENTRAR É O PRIMEIRO A SAIR
                                    {
                                        indexSubtituir = Fifo(); //Bloco que deve sair da memoria cache
                                    }
                                    else if (this.Algoritmo == "LFU")
                                    {
                                        indexSubtituir = LFU();
                                        //Pegar o bloco da memoria cache e retorna pra ram
                                        //Pegar o  bloco novo na memoria ram para cache
                                    }
                                    else
                                    {
                                        indexSubtituir = LRU();
                                        //Pegar o bloco da memoria cache e retorna pra ram
                                        //Pegar o  bloco novo na memoria ram para cache
                                    }
                                    EstruturaDados[indexSubtituir].id = valor;
                                    EstruturaDados[indexSubtituir].Entrada = Entrada++; // so acontece quando é enviado para cache
                                    EstruturaDados[indexSubtituir].Tempo = Tempo++;
                                    EstruturaDados[indexSubtituir].Quantidade = 1;

                                    RelatorioObj.InserirTexto("Bloco: " + Linhas[indexSubtituir].Bloco + " foi retirado da cache");

                                    Blocos[Linhas[indexSubtituir].Bloco].Processo = Linhas[indexSubtituir].Processo;
                                    Linhas[indexSubtituir].SetBloco(Blocos[valor]);
                                    Blocos[valor].Processo = "Memoria cache";

                                    RelatorioObj.InserirTexto("Bloco: " + valor + " foi para cache na linha:" + indexSubtituir);
                                }
                            }
                        }
                        AtualizaTabelas();
                    }
                }
                else
                {
                    MessageBox.Show("Você tem certeza que o indice do bloco é uma string?");
                }

            }
        }
        private void CargaBloco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && CargaBloco.Text != "")
            {
                CarregaBlocos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RelatorioObj.Visible = false;
            this.Parente.Visible = true;
        }

        private long Fifo() //PRIMEIRO A ENTRAR É O PRIMEIRO A SAIR
        {
            long index = 0; //index do menor dado
            long entrada = EstruturaDados[index].Entrada;
            for (long i = 1; i < EstruturaDados.Length; i++)
            {
                if (EstruturaDados[i].id >= 0)
                {
                    if (entrada > EstruturaDados[i].Entrada)
                    {
                        entrada = EstruturaDados[i].Entrada;
                        index = i;
                    }
                }
            }
            return index;
        }
        private long LFU() //Menos Frequentimente Usuado
        {
            long index = 0; //index do menor dado
            long quantidade = EstruturaDados[index].Quantidade;
            for (long i = 1; i < EstruturaDados.Length; i++)
            {
                if (EstruturaDados[i].id >= 0)
                {
                 //   MessageBox.Show("INDEX " + i + " - QUANTIDADE" + EstruturaDados[i].Quantidade);
                    if (quantidade > EstruturaDados[i].Quantidade)
                    {
                        quantidade = EstruturaDados[i].Quantidade;
                        index = i;
                    }
                }
            }
            return index;
        }
        private long LRU() //Menos Recente usado
        {
            long index = 0; //index do menor dado
            long tempo = EstruturaDados[0].Tempo;
            for (long i = 1; i < EstruturaDados.Length; i++)
            {
                if (EstruturaDados[i].id >= 0)
                {
                    if (tempo > EstruturaDados[i].Tempo)
                    {
                        tempo = EstruturaDados[i].Tempo;
                        index = i;
                    }
                }
            }
            return index;
        }

        private bool ProcuraEstruturaDadosVazio()
        {
            for (long i = 0; i < Linhas.Length; i++)
            {
                if (Linhas[i].Bloco < 0)
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
                if (EstruturaDados[i].id == id)
                {
                    return i;
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