using AluguelFesta.Dominio.ModuloAluguel;
using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.WinApp.Compartilhado;
using AluguelFesta.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelFesta.WinApp.ModuloAluguel
{
    internal class ControladorAluguel : ControladorBase
    {
        private IRepositorioAluguel repositorioCliente;
        private TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(IRepositorioAluguel repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public override string ToolTipInserir { get { return "Inserir novo Cliente"; } }
        public override string ToolTipEditar { get { return "Editar Cliente existente"; } }
        public override string ToolTipExcluir { get { return "Excluir Cliente existente"; } }

        public override void Inserir()
        {
            TelaAluguelForm telaCliente = new TelaAluguelForm();
            DialogResult opcaoEscolhida = telaCliente.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel cliente = telaCliente.ObterAluguel();
                repositorioCliente.Inserir(cliente);
                CarregarClientes();
            }
        }
        public override void Editar()
        {
            Aluguel cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show(
                    $"Selecione um aluguel primeiro!",
                    "Edição de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaAluguelForm telaCliente = new TelaAluguelForm();
            telaCliente.Cliente = cliente;

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCliente.Editar(cliente.Id, telaCliente.ObterAluguel());
                CarregarClientes();
            }
        }
        public override void Excluir()
        {
            Aluguel cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show(
                    $"Selecione um aluguel primeiro!",
                    "Exclusão de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation
                    );

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show(
                $"Deseja excluir o aluguel {cliente.Nome}?",
                "Exclusão de Alugueis",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCliente.Excluir(cliente);
                CarregarClientes();
            }
        }
        private Aluguel ObterClienteSelecionado()
        {
            int id = tabelaAluguel.ObterIdSelecionado();
            return repositorioCliente.SelecionarPorId(id);
        }
        private void CarregarClientes()
        {
            List<Aluguel> clientes = repositorioCliente.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(clientes);
        }
        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();
            CarregarClientes();
            return tabelaAluguel;
        }
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Alugueis";
        }
    }
}
}
