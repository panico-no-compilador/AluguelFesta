namespace AluguelFesta.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            clienteMenuItem = new ToolStripMenuItem();
            temaMenuItem = new ToolStripMenuItem();
            alugueisMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnInserirItens = new ToolStripButton();
            toolStripTipoCadastro = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            painelRegistros = new Panel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(450, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { clienteMenuItem, temaMenuItem, alugueisMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(99, 20);
            toolStripMenuItem1.Text = "Menu Principal";
            // 
            // clienteMenuItem
            // 
            clienteMenuItem.Name = "clienteMenuItem";
            clienteMenuItem.Size = new Size(186, 22);
            clienteMenuItem.Text = "Cadastro de Cliente";
            clienteMenuItem.Click += clienteMenuItem_Click;
            // 
            // temaMenuItem
            // 
            temaMenuItem.Name = "temaMenuItem";
            temaMenuItem.Size = new Size(186, 22);
            temaMenuItem.Text = "Cadatro de Tema";
            temaMenuItem.Click += temaMenuItem_Click;
            // 
            // alugueisMenuItem
            // 
            alugueisMenuItem.Name = "alugueisMenuItem";
            alugueisMenuItem.Size = new Size(186, 22);
            alugueisMenuItem.Text = "Cadastro de Alugueis";
            alugueisMenuItem.Click += alugueisMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator1, btnInserirItens, toolStripTipoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(450, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Enabled = false;
            btnInserir.Image = (Image)resources.GetObject("btnInserir.Image");
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(23, 22);
            btnInserir.Text = "Inserir";
            btnInserir.ToolTipText = "toolStripInserir";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(23, 22);
            btnEditar.Text = "Editar";
            btnEditar.ToolTipText = "toolStripEditar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(23, 22);
            btnExcluir.Text = "Excluir";
            btnExcluir.ToolTipText = "toolStripExcluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnInserirItens
            // 
            btnInserirItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserirItens.Enabled = false;
            btnInserirItens.Image = (Image)resources.GetObject("btnInserirItens.Image");
            btnInserirItens.ImageTransparentColor = Color.Magenta;
            btnInserirItens.Name = "btnInserirItens";
            btnInserirItens.Size = new Size(23, 22);
            btnInserirItens.Text = "Inserir Item";
            btnInserirItens.ToolTipText = "toolStripInserirItens";
            // 
            // toolStripTipoCadastro
            // 
            toolStripTipoCadastro.Name = "toolStripTipoCadastro";
            toolStripTipoCadastro.Size = new Size(75, 22);
            toolStripTipoCadastro.Text = "tipoCadastro";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 478);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(450, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // painelRegistros
            // 
            painelRegistros.Dock = DockStyle.Fill;
            painelRegistros.Location = new Point(0, 49);
            painelRegistros.Name = "painelRegistros";
            painelRegistros.Size = new Size(450, 429);
            painelRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 500);
            Controls.Add(painelRegistros);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            Text = "Alugueis para Festas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem clienteMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnInserirItens;
        private ToolStripLabel toolStripTipoCadastro;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem temaMenuItem;
        private ToolStripMenuItem alugueisMenuItem;
        private Panel painelRegistros;
    }
}