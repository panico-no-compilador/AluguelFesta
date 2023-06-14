namespace AluguelFesta.WinApp.ModuloCliente
{
    partial class TabelaClienteControl
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
            tabelaClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaClientes).BeginInit();
            SuspendLayout();
            // 
            // tabelaClientes
            // 
            tabelaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaClientes.Dock = DockStyle.Fill;
            tabelaClientes.Location = new Point(0, 0);
            tabelaClientes.Name = "tabelaClientes";
            tabelaClientes.Size = new Size(356, 326);
            tabelaClientes.TabIndex = 0;
            // 
            // TabelaClienteControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaClientes);
            Name = "TabelaClienteControl";
            Size = new Size(356, 326);
            ((System.ComponentModel.ISupportInitialize)tabelaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaClientes;
    }
}
