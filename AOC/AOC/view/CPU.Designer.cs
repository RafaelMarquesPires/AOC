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
            ((System.ComponentModel.ISupportInitialize)(this.MemoriaCache)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoriaRam)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MemoriaCache
            // 
            this.MemoriaCache.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemoriaCache.Location = new System.Drawing.Point(2, 161);
            this.MemoriaCache.Name = "MemoriaCache";
            this.MemoriaCache.Size = new System.Drawing.Size(502, 452);
            this.MemoriaCache.TabIndex = 0;
            // 
            // MemoriaRam
            // 
            this.MemoriaRam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemoriaRam.Location = new System.Drawing.Point(510, 161);
            this.MemoriaRam.Name = "MemoriaRam";
            this.MemoriaRam.Size = new System.Drawing.Size(502, 452);
            this.MemoriaRam.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.TamanhoTAG);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TamanhoCache);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TamanhoRAM);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 134);
            this.panel1.TabIndex = 2;
            // 
            // TamanhoTAG
            // 
            this.TamanhoTAG.AutoSize = true;
            this.TamanhoTAG.Location = new System.Drawing.Point(247, 79);
            this.TamanhoTAG.Name = "TamanhoTAG";
            this.TamanhoTAG.Size = new System.Drawing.Size(74, 13);
            this.TamanhoTAG.TabIndex = 5;
            this.TamanhoTAG.Text = "TamanhoTAG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tamanho da TAG";
            // 
            // TamanhoCache
            // 
            this.TamanhoCache.AutoSize = true;
            this.TamanhoCache.Location = new System.Drawing.Point(247, 45);
            this.TamanhoCache.Name = "TamanhoCache";
            this.TamanhoCache.Size = new System.Drawing.Size(83, 13);
            this.TamanhoCache.TabIndex = 3;
            this.TamanhoCache.Text = "TamanhoCache";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tamanho da memoria CACHE:";
            // 
            // TamanhoRAM
            // 
            this.TamanhoRAM.AutoSize = true;
            this.TamanhoRAM.Location = new System.Drawing.Point(247, 15);
            this.TamanhoRAM.Name = "TamanhoRAM";
            this.TamanhoRAM.Size = new System.Drawing.Size(76, 13);
            this.TamanhoRAM.TabIndex = 1;
            this.TamanhoRAM.Text = "TamanhoRAM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamanho da memoria RAM:";
            // 
            // CargaBloco
            // 
            this.CargaBloco.Location = new System.Drawing.Point(18, 45);
            this.CargaBloco.Name = "CargaBloco";
            this.CargaBloco.Size = new System.Drawing.Size(155, 20);
            this.CargaBloco.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Carga de bloco";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.CargaBloco);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(483, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 134);
            this.panel2.TabIndex = 3;
            // 
            // CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1020, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MemoriaRam);
            this.Controls.Add(this.MemoriaCache);
            this.Name = "CPU";
            this.Text = "CPU";
            ((System.ComponentModel.ISupportInitialize)(this.MemoriaCache)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoriaRam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}