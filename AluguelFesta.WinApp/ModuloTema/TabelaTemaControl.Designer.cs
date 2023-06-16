namespace AluguelFesta.WinApp.ModuloTema
{
    partial class TabelaTemaControl
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
            tabelaTemas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaTemas).BeginInit();
            SuspendLayout();
            // 
            // tabelaTemas
            // 
            tabelaTemas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaTemas.Dock = DockStyle.Fill;
            tabelaTemas.Location = new Point(0, 0);
            tabelaTemas.Name = "tabelaTemas";
            tabelaTemas.RowTemplate.Height = 25;
            tabelaTemas.Size = new Size(291, 274);
            tabelaTemas.TabIndex = 0;
            // 
            // TabelaTemaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaTemas);
            Name = "TabelaTemaControl";
            Size = new Size(291, 274);
            ((System.ComponentModel.ISupportInitialize)tabelaTemas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaTemas;
    }
}
