namespace AluguelFesta.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            tbDesconto = new MaskedTextBox();
            tbValorEntrada = new MaskedTextBox();
            label2 = new Label();
            tbValorTotal = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            cboxClientes = new ComboBox();
            cboxTema = new ComboBox();
            label5 = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 47);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Desconto: ";
            // 
            // tbDesconto
            // 
            tbDesconto.Location = new Point(296, 44);
            tbDesconto.Mask = "$";
            tbDesconto.Name = "tbDesconto";
            tbDesconto.Size = new Size(113, 23);
            tbDesconto.TabIndex = 1;
            // 
            // tbValorEntrada
            // 
            tbValorEntrada.Location = new Point(76, 41);
            tbValorEntrada.Mask = "$";
            tbValorEntrada.Name = "tbValorEntrada";
            tbValorEntrada.Size = new Size(125, 23);
            tbValorEntrada.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 44);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Entrada:";
            // 
            // tbValorTotal
            // 
            tbValorTotal.Location = new Point(76, 70);
            tbValorTotal.Mask = "$";
            tbValorTotal.Name = "tbValorTotal";
            tbValorTotal.Size = new Size(125, 23);
            tbValorTotal.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 73);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 4;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 18);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 6;
            label4.Text = "Cliente:";
            // 
            // cboxClientes
            // 
            cboxClientes.FormattingEnabled = true;
            cboxClientes.Location = new Point(296, 15);
            cboxClientes.Name = "cboxClientes";
            cboxClientes.Size = new Size(113, 23);
            cboxClientes.TabIndex = 7;
            // 
            // cboxTema
            // 
            cboxTema.FormattingEnabled = true;
            cboxTema.Location = new Point(76, 12);
            cboxTema.Name = "cboxTema";
            cboxTema.Size = new Size(125, 23);
            cboxTema.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 15);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "Tema:";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGravar.Location = new Point(246, 299);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 40);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelar.Location = new Point(327, 299);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 40);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 351);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(cboxTema);
            Controls.Add(label5);
            Controls.Add(cboxClientes);
            Controls.Add(label4);
            Controls.Add(tbValorTotal);
            Controls.Add(label3);
            Controls.Add(tbValorEntrada);
            Controls.Add(label2);
            Controls.Add(tbDesconto);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAluguelForm";
            ShowIcon = false;
            Text = "Cadastro Alugueis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox tbDesconto;
        private MaskedTextBox tbValorEntrada;
        private Label label2;
        private MaskedTextBox tbValorTotal;
        private Label label3;
        private Label label4;
        private ComboBox cboxClientes;
        private ComboBox cboxTema;
        private Label label5;
        private Button btnGravar;
        private Button btnCancelar;
    }
}