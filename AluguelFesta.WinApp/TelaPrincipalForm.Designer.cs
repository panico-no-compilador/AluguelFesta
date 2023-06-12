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
            toolStrip1 = new ToolStrip();
            toolStripInserir = new ToolStripButton();
            toolStripEditar = new ToolStripButton();
            toolStripDeletar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripInserirItens = new ToolStripButton();
            toolStripTipoCadastro = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            dataGridView1 = new DataGridView();
            cadatroDeTemaToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeAlugueisToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { clienteMenuItem, cadatroDeTemaToolStripMenuItem, cadastroDeAlugueisToolStripMenuItem });
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripInserir, toolStripEditar, toolStripDeletar, toolStripSeparator1, toolStripInserirItens, toolStripTipoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(450, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripInserir
            // 
            toolStripInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripInserir.Image = (Image)resources.GetObject("toolStripInserir.Image");
            toolStripInserir.ImageTransparentColor = Color.Magenta;
            toolStripInserir.Name = "toolStripInserir";
            toolStripInserir.Size = new Size(23, 22);
            toolStripInserir.Text = "btnInserir";
            toolStripInserir.ToolTipText = "toolStripInserir";
            // 
            // toolStripEditar
            // 
            toolStripEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripEditar.Image = (Image)resources.GetObject("toolStripEditar.Image");
            toolStripEditar.ImageTransparentColor = Color.Magenta;
            toolStripEditar.Name = "toolStripEditar";
            toolStripEditar.Size = new Size(23, 22);
            toolStripEditar.Text = "btnEditar";
            toolStripEditar.ToolTipText = "toolStripEditar";
            // 
            // toolStripDeletar
            // 
            toolStripDeletar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDeletar.Image = (Image)resources.GetObject("toolStripDeletar.Image");
            toolStripDeletar.ImageTransparentColor = Color.Magenta;
            toolStripDeletar.Name = "toolStripDeletar";
            toolStripDeletar.Size = new Size(23, 22);
            toolStripDeletar.Text = "btnDeletar";
            toolStripDeletar.ToolTipText = "toolStripDeletar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripInserirItens
            // 
            toolStripInserirItens.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripInserirItens.Image = (Image)resources.GetObject("toolStripInserirItens.Image");
            toolStripInserirItens.ImageTransparentColor = Color.Magenta;
            toolStripInserirItens.Name = "toolStripInserirItens";
            toolStripInserirItens.Size = new Size(23, 22);
            toolStripInserirItens.Text = "btnInserirItem";
            toolStripInserirItens.ToolTipText = "toolStripInserirItens";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(450, 429);
            dataGridView1.TabIndex = 3;
            // 
            // cadatroDeTemaToolStripMenuItem
            // 
            cadatroDeTemaToolStripMenuItem.Name = "cadatroDeTemaToolStripMenuItem";
            cadatroDeTemaToolStripMenuItem.Size = new Size(186, 22);
            cadatroDeTemaToolStripMenuItem.Text = "Cadatro de Tema";
            // 
            // cadastroDeAlugueisToolStripMenuItem
            // 
            cadastroDeAlugueisToolStripMenuItem.Name = "cadastroDeAlugueisToolStripMenuItem";
            cadastroDeAlugueisToolStripMenuItem.Size = new Size(186, 22);
            cadastroDeAlugueisToolStripMenuItem.Text = "Cadastro de Alugueis";
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 500);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem clienteMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripInserir;
        private ToolStripButton toolStripEditar;
        private ToolStripButton toolStripDeletar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripInserirItens;
        private ToolStripLabel toolStripTipoCadastro;
        private StatusStrip statusStrip1;
        private DataGridView dataGridView1;
        private ToolStripMenuItem cadatroDeTemaToolStripMenuItem;
        private ToolStripMenuItem cadastroDeAlugueisToolStripMenuItem;
    }
}