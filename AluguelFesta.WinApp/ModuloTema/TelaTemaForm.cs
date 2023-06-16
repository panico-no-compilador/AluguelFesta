using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.Dominio.ModuloTema;
using AluguelFesta.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluguelFesta.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        Tema tema;
        public TelaTemaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }
        public Tema Tema
        {
            get
            {
                return this.tema;
            }
            set
            {
                tbNomeTema.Text = value.Nome;
            }

        }
        public void ConfigurarTelaDeEdicao(Tema temaSelecionado)
        {
            tbNomeTema.Text = temaSelecionado.Nome;
        }
        public Tema Tema 
        {
            get 
                { 
                    return tema;
                } 
            set
            {
                tbNomeTema.Text = value.Nome;
            }
        }
        public Tema ObterTema()
        {
            string nome = tbNomeTema.Text;
            return new Tema(nome);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.tema = ObterTema();
            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                DialogResult = DialogResult.None;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
