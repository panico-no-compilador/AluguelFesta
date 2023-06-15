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
        private IRepositorioAluguel repositorioAluguel;
        private IRepositorioCliente repositorioCliente;
        private TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(
            IRepositorioAluguel repositorioAluguel,
            IRepositorioCliente repositorioCliente
            )
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioCliente = repositorioCliente;
        }

        public override string ToolTipInserir { get { return "Inserir novo Aluguel"; } }
        public override string ToolTipEditar { get { return "Editar Aluguel existente"; } }
        public override string ToolTipExcluir { get { return "Excluir Aluguel existente"; } }

        public override void Inserir()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm(repositorioCliente);
            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();
                repositorioAluguel.Inserir(aluguel);
                CarregarClientes();
            }
        }
        public override void Editar()
        {
            Aluguel aluguel = ObterClienteSelecionado();

            if (aluguel == null)
            {
                MessageBox.Show(
                    $"Selecione um aluguel primeiro!",
                    "Edição de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaAluguelForm telaAluguel = new TelaAluguelForm(repositorioCliente);
            telaAluguel.Aluguel = aluguel;

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioAluguel.Editar(aluguel.Id, telaAluguel.ObterAluguel());
                CarregarClientes();
            }
        }
        public override void Excluir()
        {
            Aluguel aluguel = ObterClienteSelecionado();

            if (aluguel == null)
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
                $"Deseja excluir o aluguel do Sr(a). {aluguel.Cliente.Nome}?",
                "Exclusão de Alugueis",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioAluguel.Excluir(aluguel);
                CarregarClientes();
            }
        }
        private Aluguel ObterClienteSelecionado()
        {
            int id = tabelaAluguel.ObterIdSelecionado();
            return repositorioAluguel.SelecionarPorId(id);
        }
        private void CarregarClientes()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);
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
