namespace AOC.view
{
    partial class Relatorio
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
            this.Relatos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Relatos
            // 
            this.Relatos.Location = new System.Drawing.Point(12, 12);
            this.Relatos.Name = "Relatos";
            this.Relatos.Size = new System.Drawing.Size(776, 426);
            this.Relatos.TabIndex = 0;
            this.Relatos.Text = "";
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Relatos);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Relatos;
    }
}