using System.Drawing;
using System.Windows.Forms;

namespace AOC.view
{
    partial class CPU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MemoriaCache = new System.Windows.Forms.DataGridView();
            this.MemoriaRam = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.TamanhoTAG = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TamanhoCache = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TamanhoRAM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CargaBloco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemoriaCache)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoriaRam)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemoriaCache
            // 
            this.MemoriaCache.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemoriaCache.Location = new System.Drawing.Point(3, 45);
            this.MemoriaCache.Name = "MemoriaCache";
            this.MemoriaCache.Size = new System.Drawing.Size(472, 440);
            this.MemoriaCache.TabIndex = 0;
            // 
            // MemoriaRam
            // 
            this.MemoriaRam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemoriaRam.Location = new System.Drawing.Point(3, 45);
            this.MemoriaRam.Name = "MemoriaRam";
            this.MemoriaRam.Size = new System.Drawing.Size(472, 440);
            this.MemoriaRam.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TamanhoTAG);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TamanhoCache);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TamanhoRAM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 150);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Informações";
            // 
            // TamanhoTAG
            // 
            this.TamanhoTAG.AutoSize = true;
            this.TamanhoTAG.BackColor = System.Drawing.Color.Transparent;
            this.TamanhoTAG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TamanhoTAG.Location = new System.Drawing.Point(248, 84);
            this.TamanhoTAG.Name = "TamanhoTAG";
            this.TamanhoTAG.Size = new System.Drawing.Size(109, 20);
            this.TamanhoTAG.TabIndex = 5;
            this.TamanhoTAG.Text = "TamanhoTAG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamanho da TAG";
            // 
            // TamanhoCache
            // 
            this.TamanhoCache.AutoSize = true;
            this.TamanhoCache.BackColor = System.Drawing.Color.Transparent;
            this.TamanhoCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TamanhoCache.Location = new System.Drawing.Point(248, 64);
            this.TamanhoCache.Name = "TamanhoCache";
            this.TamanhoCache.Size = new System.Drawing.Size(122, 20);
            this.TamanhoCache.TabIndex = 3;
            this.TamanhoCache.Text = "TamanhoCache";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tamanho da memoria CACHE:";
            // 
            // TamanhoRAM
            // 
            this.TamanhoRAM.AutoSize = true;
            this.TamanhoRAM.BackColor = System.Drawing.Color.Transparent;
            this.TamanhoRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TamanhoRAM.Location = new System.Drawing.Point(248, 42);
            this.TamanhoRAM.Name = "TamanhoRAM";
            this.TamanhoRAM.Size = new System.Drawing.Size(112, 20);
            this.TamanhoRAM.TabIndex = 1;
            this.TamanhoRAM.Text = "TamanhoRAM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamanho da memoria RAM:";
            // 
            // CargaBloco
            // 
            this.CargaBloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargaBloco.Location = new System.Drawing.Point(14, 72);
            this.CargaBloco.Name = "CargaBloco";
            this.CargaBloco.Size = new System.Drawing.Size(360, 26);
            this.CargaBloco.TabIndex = 4;
            this.CargaBloco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CargaBloco_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Carrega blocos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Carregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.CargaBloco);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(493, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 150);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Processador";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.MemoriaCache);
            this.panel3.Location = new System.Drawing.Point(7, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 488);
            this.panel3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Memoria Cache";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.MemoriaRam);
            this.panel4.Location = new System.Drawing.Point(492, 162);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 488);
            this.panel4.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Memoria RAM";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Novas configurações";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(981, 662);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CPU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPU";
            ((System.ComponentModel.ISupportInitialize)(this.MemoriaCache)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoriaRam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView MemoriaCache;
        private DataGridView MemoriaRam;
        private Panel panel1;
        private Label TamanhoCache;
        private Label label4;
        private Label TamanhoRAM;
        private Label label1;
        private TextBox CargaBloco;
        private Label label5;
        private Button button1;
        private Panel panel2;
        private Label TamanhoTAG;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label7;
        private Label label6;
        private Label label8;
        private Button button2;
    }
}