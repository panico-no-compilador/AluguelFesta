namespace AluguelFesta.WinApp.ModuloTema
{
    partial class TabelaTemaControl
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            TabelaTema = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)TabelaTema).BeginInit();
            SuspendLayout();
            // 
            // TabelaTema
            // 
            TabelaTema.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelaTema.Dock = DockStyle.Fill;
            TabelaTema.Location = new Point(0, 0);
            TabelaTema.Name = "TabelaTema";
            TabelaTema.RowTemplate.Height = 25;
            TabelaTema.Size = new Size(421, 404);
            TabelaTema.TabIndex = 0;
            // 
            // TabelaTemaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TabelaTema);
            Name = "TabelaTemaControl";
            Size = new Size(421, 404);
            ((System.ComponentModel.ISupportInitialize)TabelaTema).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView TabelaTema;
    }
}
