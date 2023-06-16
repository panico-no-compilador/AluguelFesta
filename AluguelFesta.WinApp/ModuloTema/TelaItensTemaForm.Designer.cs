namespace AluguelFesta.WinApp.ModuloTema
{
    partial class TelaItensTemaForm
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
            label1 = new Label();
            tbNomeTema = new TextBox();
            label2 = new Label();
            tbItem = new TextBox();
            label3 = new Label();
            tbValorItem = new TextBox();
            btnAdicionarItem = new Button();
            btnDeletarItem = new Button();
            btnCancelar = new Button();
            btnGravar = new Button();
            gridItens = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridItens).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 42);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Tema:";
            // 
            // tbNomeTema
            // 
            tbNomeTema.Location = new Point(72, 39);
            tbNomeTema.Name = "tbNomeTema";
            tbNomeTema.ReadOnly = true;
            tbNomeTema.Size = new Size(239, 23);
            tbNomeTema.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 86);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 18;
            label2.Text = "Item:";
            // 
            // tbItem
            // 
            tbItem.Location = new Point(72, 83);
            tbItem.Name = "tbItem";
            tbItem.Size = new Size(239, 23);
            tbItem.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 129);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 20;
            label3.Text = "Valor:";
            // 
            // tbValorItem
            // 
            tbValorItem.Location = new Point(72, 126);
            tbValorItem.Name = "tbValorItem";
            tbValorItem.Size = new Size(77, 23);
            tbValorItem.TabIndex = 21;
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.BackColor = Color.PaleGreen;
            btnAdicionarItem.Location = new Point(155, 126);
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Size = new Size(75, 26);
            btnAdicionarItem.TabIndex = 24;
            btnAdicionarItem.Text = "Adicionar";
            btnAdicionarItem.UseVisualStyleBackColor = false;
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // btnDeletarItem
            // 
            btnDeletarItem.BackColor = Color.LightCoral;
            btnDeletarItem.Location = new Point(236, 126);
            btnDeletarItem.Name = "btnDeletarItem";
            btnDeletarItem.Size = new Size(75, 26);
            btnDeletarItem.TabIndex = 25;
            btnDeletarItem.Text = "Deletar";
            btnDeletarItem.UseVisualStyleBackColor = false;
            btnDeletarItem.Click += btnDeletarItem_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(236, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(155, 378);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 27;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // gridItens
            // 
            gridItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridItens.Location = new Point(28, 189);
            gridItens.Name = "gridItens";
            gridItens.RowTemplate.Height = 25;
            gridItens.Size = new Size(283, 163);
            gridItens.TabIndex = 29;
            // 
            // TelaItensTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 440);
            Controls.Add(gridItens);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(btnDeletarItem);
            Controls.Add(btnAdicionarItem);
            Controls.Add(tbValorItem);
            Controls.Add(label3);
            Controls.Add(tbItem);
            Controls.Add(label2);
            Controls.Add(tbNomeTema);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItensTemaForm";
            ShowIcon = false;
            Text = "Cadastro Itens do Tema";
            ((System.ComponentModel.ISupportInitialize)gridItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNomeTema;
        private Label label2;
        private TextBox tbItem;
        private Label label3;
        private TextBox tbValorItem;
        private Button btnAdicionarItem;
        private Button btnDeletarItem;
        private Button btnCancelar;
        private Button btnGravar;
        private DataGridView gridItens;
    }
}