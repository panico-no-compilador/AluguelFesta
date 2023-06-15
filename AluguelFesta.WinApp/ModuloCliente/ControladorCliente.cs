using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.WinApp.Compartilhado;

namespace AluguelFesta.WinApp.ModuloCliente
{
    internal class ControladorCliente : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private TabelaClienteControl tabelaCliente;

        public ControladorCliente(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public override string ToolTipInserir { get { return "Inserir novo Cliente"; } }
        public override string ToolTipEditar { get { return "Editar Cliente existente"; } }
        public override string ToolTipExcluir { get { return "Excluir Cliente existente"; } }

        public override void Inserir()
        {
            TelaCadastroClienteForm telaCliente = new TelaCadastroClienteForm();
            DialogResult opcaoEscolhida = telaCliente.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = telaCliente.ObterCliente();
                repositorioCliente.Inserir(cliente);
                CarregarClientes();
            }
        }
        public override void Editar()
        {
            Cliente cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show(
                    $"Selecione um cliente primeiro!",
                    "Edição de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaCadastroClienteForm telaCliente = new TelaCadastroClienteForm();
            telaCliente.Cliente = cliente;

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCliente.Editar(cliente.Id, telaCliente.ObterCliente());
                CarregarClientes();
            }
        }
        public override void Excluir()
        {
            Cliente cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show(
                    $"Selecione um cliente primeiro!",
                    "Exclusão de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show(
                $"Deseja excluir o cliente {cliente.Nome}?",
                "Exclusão de Clientes",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCliente.Excluir(cliente);
                CarregarClientes();
            }
        }
        private Cliente ObterClienteSelecionado()
        {
            int id = tabelaCliente.ObterIdSelecionado();
            return repositorioCliente.SelecionarPorId(id);
        }
        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);
        }
        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();
            CarregarClientes();
            return tabelaCliente;
        }
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Clientes";
        }
    }
}

