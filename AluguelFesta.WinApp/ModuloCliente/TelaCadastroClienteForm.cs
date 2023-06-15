using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.WinApp.Compartilhado;

namespace AluguelFesta.WinApp.ModuloCliente
{
    public partial class TelaCadastroClienteForm : Form
    {
        Cliente cliente;
        public TelaCadastroClienteForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }
        public Cliente Cliente
        {
            get
            {
                return this.cliente;
            }
            set
            {
                tboxNome.Text = value.Nome;
                tboxTelefone.Text = value.Telefone.ToString();
                tboxEmail.Text = value.Email;
            }

        }
        public Cliente ObterCliente()
        {

            string nome = tboxNome.Text;
            int telefone = (int)Convert.ToInt32(tboxTelefone.Text);
            string email = tboxEmail.Text;
            Cliente cliente = new Cliente(nome, telefone, email);
            return cliente;
        }

        public void ConfigurarTela(Cliente cliente)
        {
            tboxNome.Text = cliente.Nome;
            tboxTelefone.Text = cliente.Telefone.ToString();
            tboxEmail.Text = cliente.Email;
        }
        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            this.cliente = ObterCliente();
            string[] erros = cliente.Validar();

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
