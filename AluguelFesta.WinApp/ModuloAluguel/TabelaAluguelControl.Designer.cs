namespace AluguelFesta.WinApp.ModuloAluguel
{
    partial class TabelaAluguelControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabelaAlugueis = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaAlugueis).BeginInit();
            SuspendLayout();
            // 
            // tabelaAlugueis
            // 
            tabelaAlugueis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaAlugueis.Dock = DockStyle.Fill;
            tabelaAlugueis.Location = new Point(0, 0);
            tabelaAlugueis.Name = "tabelaAlugueis";
            tabelaAlugueis.RowTemplate.Height = 25;
            tabelaAlugueis.Size = new Size(317, 270);
            tabelaAlugueis.TabIndex = 0;
            // 
            // TabelaAluguelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaAlugueis);
            Name = "TabelaAluguelControl";
            Size = new Size(317, 270);
            ((System.ComponentModel.ISupportInitialize)tabelaAlugueis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaAlugueis;
    }
}
