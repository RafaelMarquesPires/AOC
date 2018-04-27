﻿using System;
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
    public partial class Entradas : Form
    {
        public Entradas()
        {
            InitializeComponent();
            ErroRam.Text = "";
            ErroBlocoRam.Text = "";
            ErroLinhaCache.Text = "";
        }
        private void TamanhoRam_KeyUp(object sender, KeyEventArgs e)
        {
            string texto = TamanhoRam.Text;
            if (texto != "")
            {
                if (VerificarNumeroLog2(Convert.ToDouble(texto)))
                {
                    ErroRam.Text = "* Memoria RAM deve ser elevado a 2";
                    return;
                }
            }
            ErroRam.Text = "";
        }
        private void TamanhoBloco_KeyUp(object sender, KeyEventArgs e)
        {
            string texto = TamanhoBloco.Text;
            if (texto != "")
            {
                if (VerificarNumeroLog2(Convert.ToDouble(texto)))
                {
                    ErroBlocoRam.Text = "* Memoria RAM deve ser elevado a 2";
                    return;
                }
            }
            ErroBlocoRam.Text = "";
        }
        private void TamanhoLinhaCache_KeyUp(object sender, KeyEventArgs e)
        {
            string texto = TamanhoLinha.Text;
            if (texto != "")
            {
                if (VerificarNumeroLog2(Convert.ToDouble(texto)))
                {
                    ErroLinhaCache.Text = "* Memoria RAM deve ser elevado a 2";
                    return;
                }
            }
            ErroLinhaCache.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string tecnica = Tecnica.Text;
            string algoritimo = Algoritimo.Text;
            string tamanhoRam = TamanhoRam.Text;
            string tamanhoBloco = TamanhoBloco.Text;
            string tamanhoLinha = TamanhoLinha.Text;

            if (tecnica == "")
            {
                MessageBox.Show("Escolha uma tecnica a ser simulada");
                return;
            }
            if (algoritimo == "")
            {
                MessageBox.Show("Escolha um algoritimo a ser simulado");
                return;
            }
            if (tamanhoRam == "")
            {
                MessageBox.Show("Defina o tamanho da memoria ram");
                return;
            }
            else
            {
                if (VerificarNumeroLog2(Convert.ToDouble(tamanhoRam)))
                {
                    MessageBox.Show("Tamanho de ram deve ser um numero log de 2");
                    return;
                }
            }
            if (tamanhoBloco == "")
            {
                MessageBox.Show("Defina o tamanho dos blocos");
                return;
            }
            else
            {
                if (VerificarNumeroLog2(Convert.ToDouble(tamanhoBloco)))
                {
                    MessageBox.Show("Tamanho dos blocos deve ser um numero log de 2");
                    return;
                }
            }
            if (tamanhoLinha == "")
            {
                MessageBox.Show("Defina o tamanho das linhas");
                return;
            }
            else
            {

                if (VerificarNumeroLog2(Convert.ToDouble(tamanhoLinha)))
                {
                    MessageBox.Show("Tamanho das linhas deve ser um numero log de 2");
                    return;
                }
            }
            CPU cpu = new CPU();
            cpu.SetDados(Convert.ToInt32(tamanhoRam), Convert.ToInt32(tamanhoBloco), Convert.ToInt32(tamanhoLinha), tecnica, algoritimo);
            cpu.Visible = true;
        }
        private bool VerificarNumeroLog2(double valor)
        {
            double raiz = Math.Log(valor, 2);
            return ((raiz - Math.Floor(raiz)) != 0);
        }
    }
}
