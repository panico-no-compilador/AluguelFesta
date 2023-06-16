using AluguelFesta.Dominio.ModuloAluguel;
using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.Dominio.ModuloTema;
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
        private IRepositorioTema repositorioTema;
        private TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(
            IRepositorioAluguel repositorioAluguel,
            IRepositorioCliente repositorioCliente,
            IRepositorioTema repositorioTema
            )
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir { get { return "Inserir novo Aluguel"; } }
        public override string ToolTipEditar { get { return "Editar Aluguel existente"; } }
        public override string ToolTipExcluir { get { return "Excluir Aluguel existente"; } }

        public override void Inserir()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();
            List<Tema> temas = repositorioTema.SelecionarTodos();
            TelaAluguelForm telaAluguel = new TelaAluguelForm(clientes,temas);
            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();
                repositorioAluguel.Inserir(aluguel);
            }
            CarregarAlugueis();
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
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();
            List<Tema> temas = repositorioTema.SelecionarTodos();
            TelaAluguelForm telaAluguel = new TelaAluguelForm(clientes, temas);
            telaAluguel.Aluguel = aluguel;

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioAluguel.Editar(aluguel.Id, telaAluguel.ObterAluguel());
            }
            CarregarAlugueis();
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
            }
            CarregarAlugueis();
        }
        private Aluguel ObterClienteSelecionado()
        {
            int id = tabelaAluguel.ObterIdSelecionado();
            return repositorioAluguel.SelecionarPorId(id);
        }
        private void CarregarAlugueis()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();
            tabelaAluguel.AtualizarRegistros(alugueis);
        }
        private void CarregarAlugueis(List<Aluguel> alugueis)
        {
            tabelaAluguel.AtualizarRegistros(alugueis);
        }
        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();
            CarregarAlugueis();
            return tabelaAluguel;
        }
        public override string ObterTipoCadastro()
        {
            return "Cadastro de Alugueis";
        }
    }
}
