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

        public void SetDados(int tamanhoRAM, int tamanhoBloco, int tamanhoLinha, string tecnica, string algotiritmo)
        {
            Blocos = new Bloco[tamanhoRAM / tamanhoBloco];
            Linhas = new Linha[tamanhoLinha];
            MemoriaRam.DataSource = DadosTabelaRam(tamanhoRAM, tamanhoBloco);
            MemoriaCache.DataSource = DadosTabelaCache(tamanhoLinha);

        }





        private DataTable DadosTabelaCache(int linhas)
        {
            DataTable memoriaCache = new DataTable();
            memoriaCache.Columns.Add("id", typeof(int));
            memoriaCache.Columns.Add("TAG", typeof(string));
            memoriaCache.Columns.Add("Linha", typeof(string));

            for (int i = 0; i < linhas; i++)
            {
                memoriaCache.Rows.Add(i, null, null);
            }
            return memoriaCache;
        }
        private DataTable DadosTabelaRam(int tamanhoRam, int tamanhoBloco)
        {
            DataTable memoriaCache = new DataTable();
            memoriaCache.Columns.Add("id", typeof(int));
            memoriaCache.Columns.Add("TAG", typeof(string));
            memoriaCache.Columns.Add("Linha", typeof(string));

            for (int i = 0; i < tamanhoRam; i += tamanhoBloco)
            {
                memoriaCache.Rows.Add(i, null, null);
            }
            return memoriaCache;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
