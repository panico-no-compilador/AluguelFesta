namespace AluguelFesta.WinApp.ModuloTema
{
    partial class TelaCadastroTemaForm
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
            lblNomeTema = new Label();
            textBox1 = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtItemPrincipal = new TextBox();
            SuspendLayout();
            // 
            // lblNomeTema
            // 
            lblNomeTema.AutoSize = true;
            lblNomeTema.Location = new Point(49, 32);
            lblNomeTema.Name = "lblNomeTema";
            lblNomeTema.Size = new Size(46, 15);
            lblNomeTema.TabIndex = 2;
            lblNomeTema.Text = "Nome :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(101, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 3;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGravar.Location = new Point(263, 99);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(61, 40);
            btnGravar.TabIndex = 4;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelar.Location = new Point(353, 99);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(61, 40);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 67);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 6;
            label1.Text = "Item Principal :";
            // 
            // txtItemPrincipal
            // 
            txtItemPrincipal.Location = new Point(132, 64);
            txtItemPrincipal.Name = "txtItemPrincipal";
            txtItemPrincipal.Size = new Size(189, 23);
            txtItemPrincipal.TabIndex = 7;
            // 
            // TelaCadastroTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 162);
            Controls.Add(txtItemPrincipal);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(textBox1);
            Controls.Add(lblNomeTema);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroTemaForm";
            Text = "Cadastro Tema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeTema;
        private TextBox textBox1;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtItemPrincipal;
    }
}