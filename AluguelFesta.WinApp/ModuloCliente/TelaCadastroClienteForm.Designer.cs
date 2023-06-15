namespace AluguelFesta.WinApp.ModuloCliente
{
    partial class TelaCadastroClienteForm
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
            tboxNome = new TextBox();
            lblNomeCliente = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            lblTelefone = new Label();
            lblEmail = new Label();
            tboxTelefone = new TextBox();
            tboxEmail = new TextBox();
            SuspendLayout();
            // 
            // tboxNome
            // 
            tboxNome.Location = new Point(106, 32);
            tboxNome.Name = "tboxNome";
            tboxNome.Size = new Size(162, 23);
            tboxNome.TabIndex = 0;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(30, 35);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(43, 15);
            lblNomeCliente.TabIndex = 1;
            lblNomeCliente.Text = "Nome:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelar.Location = new Point(397, 114);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 40);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGravar.Location = new Point(316, 114);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 40);
            btnGravar.TabIndex = 3;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(30, 76);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 4;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 114);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // tboxTelefone
            // 
            tboxTelefone.Location = new Point(106, 73);
            tboxTelefone.Name = "tboxTelefone";
            tboxTelefone.Size = new Size(162, 23);
            tboxTelefone.TabIndex = 6;
            // 
            // tboxEmail
            // 
            tboxEmail.Location = new Point(106, 114);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(162, 23);
            tboxEmail.TabIndex = 7;
            // 
            // TelaCadastroClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 166);
            Controls.Add(tboxEmail);
            Controls.Add(tboxTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            Controls.Add(lblNomeCliente);
            Controls.Add(tboxNome);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroClienteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Cliente";
            Load += TelaCadastroClienteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxNome;
        private Label lblNomeCliente;
        private Button btnCancelar;
        private Button btnGravar;
        private Label lblTelefone;
        private Label lblEmail;
        private TextBox tboxTelefone;
        private TextBox tboxEmail;
    }
}