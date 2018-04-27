namespace AOC.view
{
    partial class Entradas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErroLinhaCache = new System.Windows.Forms.Label();
            this.ErroBlocoRam = new System.Windows.Forms.Label();
            this.ErroRam = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Tecnica = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TamanhoLinha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TamanhoBloco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TamanhoRam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Algoritimo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.ErroLinhaCache);
            this.panel1.Controls.Add(this.ErroBlocoRam);
            this.panel1.Controls.Add(this.ErroRam);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Algoritimo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Tecnica);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TamanhoLinha);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TamanhoBloco);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TamanhoRam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 431);
            this.panel1.TabIndex = 0;
            // 
            // ErroLinhaCache
            // 
            this.ErroLinhaCache.AutoSize = true;
            this.ErroLinhaCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErroLinhaCache.ForeColor = System.Drawing.Color.DarkRed;
            this.ErroLinhaCache.Location = new System.Drawing.Point(12, 255);
            this.ErroLinhaCache.Name = "ErroLinhaCache";
            this.ErroLinhaCache.Size = new System.Drawing.Size(89, 13);
            this.ErroLinhaCache.TabIndex = 18;
            this.ErroLinhaCache.Text = "Erro linhas cache";
            // 
            // ErroBlocoRam
            // 
            this.ErroBlocoRam.AutoSize = true;
            this.ErroBlocoRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErroBlocoRam.ForeColor = System.Drawing.Color.DarkRed;
            this.ErroBlocoRam.Location = new System.Drawing.Point(12, 184);
            this.ErroBlocoRam.Name = "ErroBlocoRam";
            this.ErroBlocoRam.Size = new System.Drawing.Size(81, 13);
            this.ErroBlocoRam.TabIndex = 17;
            this.ErroBlocoRam.Text = "Erro Bloco Ram";
            // 
            // ErroRam
            // 
            this.ErroRam.AutoSize = true;
            this.ErroRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErroRam.ForeColor = System.Drawing.Color.DarkRed;
            this.ErroRam.Location = new System.Drawing.Point(12, 112);
            this.ErroRam.Name = "ErroRam";
            this.ErroRam.Size = new System.Drawing.Size(51, 13);
            this.ErroRam.TabIndex = 16;
            this.ErroRam.Text = "Erro Ram";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tecnica
            // 
            this.Tecnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tecnica.FormattingEnabled = true;
            this.Tecnica.Items.AddRange(new object[] {
            "Direta",
            "Associativa"});
            this.Tecnica.Location = new System.Drawing.Point(15, 295);
            this.Tecnica.Name = "Tecnica";
            this.Tecnica.Size = new System.Drawing.Size(317, 28);
            this.Tecnica.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tecnica a ser simuada";
            // 
            // TamanhoLinha
            // 
            this.TamanhoLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TamanhoLinha.Location = new System.Drawing.Point(15, 226);
            this.TamanhoLinha.Name = "TamanhoLinha";
            this.TamanhoLinha.Size = new System.Drawing.Size(199, 26);
            this.TamanhoLinha.TabIndex = 8;
            this.TamanhoLinha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TamanhoLinhaCache_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Quantidade de linhas da memoria cache";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "bytes";
            // 
            // TamanhoBloco
            // 
            this.TamanhoBloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TamanhoBloco.Location = new System.Drawing.Point(15, 155);
            this.TamanhoBloco.Name = "TamanhoBloco";
            this.TamanhoBloco.Size = new System.Drawing.Size(199, 26);
            this.TamanhoBloco.TabIndex = 5;
            this.TamanhoBloco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TamanhoBloco_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tamanho do bloco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "bytes";
            // 
            // TamanhoRam
            // 
            this.TamanhoRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TamanhoRam.Location = new System.Drawing.Point(15, 83);
            this.TamanhoRam.Name = "TamanhoRam";
            this.TamanhoRam.Size = new System.Drawing.Size(199, 26);
            this.TamanhoRam.TabIndex = 2;
            this.TamanhoRam.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TamanhoRam_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamanho da memoria RAM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição da arquitetura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Algoritmo de subtituição";
            // 
            // Algoritimo
            // 
            this.Algoritimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Algoritimo.FormattingEnabled = true;
            this.Algoritimo.Items.AddRange(new object[] {
            "LRU",
            "LFU",
            "FIFO"});
            this.Algoritimo.Location = new System.Drawing.Point(15, 350);
            this.Algoritimo.Name = "Algoritimo";
            this.Algoritimo.Size = new System.Drawing.Size(317, 28);
            this.Algoritimo.TabIndex = 12;
            // 
            // Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 455);
            this.Controls.Add(this.panel1);
            this.Name = "Entradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradas - AOC e AEDII";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TamanhoRam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Tecnica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TamanhoLinha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TamanhoBloco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ErroRam;
        private System.Windows.Forms.Label ErroBlocoRam;
        private System.Windows.Forms.Label ErroLinhaCache;
        private System.Windows.Forms.ComboBox Algoritimo;
        private System.Windows.Forms.Label label8;
    }
}

