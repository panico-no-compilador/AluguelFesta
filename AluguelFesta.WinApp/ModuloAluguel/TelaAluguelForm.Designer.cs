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
            tbValorDesconto = new MaskedTextBox();
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tbHorarioInicio = new MaskedTextBox();
            tbHorarioTermino = new MaskedTextBox();
            tbRua = new TextBox();
            tbNumeroCasaApto = new TextBox();
            tbCidade = new TextBox();
            tbEstado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 148);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Desconto: ";
            // 
            // tbValorDesconto
            // 
            tbValorDesconto.Location = new Point(296, 145);
            tbValorDesconto.Mask = "$";
            tbValorDesconto.Name = "tbValorDesconto";
            tbValorDesconto.Size = new Size(113, 23);
            tbValorDesconto.TabIndex = 1;
            tbValorDesconto.TextAlign = HorizontalAlignment.Center;
            // 
            // tbValorEntrada
            // 
            tbValorEntrada.Location = new Point(76, 142);
            tbValorEntrada.Mask = "$";
            tbValorEntrada.Name = "tbValorEntrada";
            tbValorEntrada.Size = new Size(125, 23);
            tbValorEntrada.TabIndex = 3;
            tbValorEntrada.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 145);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Entrada:";
            // 
            // tbValorTotal
            // 
            tbValorTotal.Location = new Point(76, 171);
            tbValorTotal.Mask = "$";
            tbValorTotal.Name = "tbValorTotal";
            tbValorTotal.Size = new Size(125, 23);
            tbValorTotal.TabIndex = 5;
            tbValorTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 174);
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
            btnGravar.Location = new Point(246, 173);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 40);
            btnGravar.TabIndex = 11;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelar.Location = new Point(327, 173);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 40);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 82);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 12;
            label6.Text = "Rua:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 115);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 13;
            label7.Text = "Numero:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(139, 115);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 14;
            label8.Text = "Cidade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(296, 115);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 15;
            label9.Text = "Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 53);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 16;
            label10.Text = "Inicio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(225, 53);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 17;
            label11.Text = "Término: ";
            // 
            // tbHorarioInicio
            // 
            tbHorarioInicio.Location = new Point(76, 50);
            tbHorarioInicio.Mask = "90:00";
            tbHorarioInicio.Name = "tbHorarioInicio";
            tbHorarioInicio.Size = new Size(125, 23);
            tbHorarioInicio.TabIndex = 18;
            tbHorarioInicio.TextAlign = HorizontalAlignment.Center;
            tbHorarioInicio.ValidatingType = typeof(DateTime);
            // 
            // tbHorarioTermino
            // 
            tbHorarioTermino.Location = new Point(296, 50);
            tbHorarioTermino.Mask = "90:00";
            tbHorarioTermino.Name = "tbHorarioTermino";
            tbHorarioTermino.Size = new Size(113, 23);
            tbHorarioTermino.TabIndex = 19;
            tbHorarioTermino.TextAlign = HorizontalAlignment.Center;
            tbHorarioTermino.ValidatingType = typeof(DateTime);
            // 
            // tbRua
            // 
            tbRua.Location = new Point(76, 79);
            tbRua.Name = "tbRua";
            tbRua.Size = new Size(333, 23);
            tbRua.TabIndex = 20;
            tbRua.TextAlign = HorizontalAlignment.Center;
            // 
            // tbNumeroCasaApto
            // 
            tbNumeroCasaApto.Location = new Point(76, 112);
            tbNumeroCasaApto.Name = "tbNumeroCasaApto";
            tbNumeroCasaApto.Size = new Size(57, 23);
            tbNumeroCasaApto.TabIndex = 21;
            tbNumeroCasaApto.TextAlign = HorizontalAlignment.Center;
            // 
            // tbCidade
            // 
            tbCidade.Location = new Point(192, 112);
            tbCidade.Name = "tbCidade";
            tbCidade.Size = new Size(96, 23);
            tbCidade.TabIndex = 22;
            tbCidade.TextAlign = HorizontalAlignment.Center;
            // 
            // tbEstado
            // 
            tbEstado.Location = new Point(347, 112);
            tbEstado.Name = "tbEstado";
            tbEstado.Size = new Size(62, 23);
            tbEstado.TabIndex = 23;
            tbEstado.TextAlign = HorizontalAlignment.Center;
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 225);
            Controls.Add(tbEstado);
            Controls.Add(tbCidade);
            Controls.Add(tbNumeroCasaApto);
            Controls.Add(tbRua);
            Controls.Add(tbHorarioTermino);
            Controls.Add(tbHorarioInicio);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
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
            Controls.Add(tbValorDesconto);
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
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox cboxClientes;
        private ComboBox cboxTema;
        private MaskedTextBox tbValorDesconto;
        private MaskedTextBox tbValorEntrada;
        private MaskedTextBox tbValorTotal;
        private MaskedTextBox tbHorarioInicio;
        private MaskedTextBox tbHorarioTermino;
        private TextBox tbRua;
        private TextBox tbNumeroCasaApto;
        private TextBox tbCidade;
        private TextBox tbEstado;
        private Button btnGravar;
        private Button btnCancelar;
    }
}