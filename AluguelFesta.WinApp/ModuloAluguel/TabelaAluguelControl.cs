using AluguelFesta.Dominio.ModuloAluguel;
using AluguelFesta.WinApp.Compartilhado;

namespace AluguelFesta.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            tabelaAlugueis.ConfigurarGridZebrado();
            tabelaAlugueis.ConfigurarGridSomenteLeitura();
        }


        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "Id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Desconto",
                    HeaderText = "Desconto"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "ValorEntrada",
                    HeaderText = "ValorEntrada"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "ValorTotal",
                    HeaderText = "ValorTotal"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Cliente",
                    HeaderText = "Cliente"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Tema",
                    HeaderText = "Tema"
                }
            };
            tabelaAlugueis.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            tabelaAlugueis.Rows.Clear();

            foreach (Aluguel aluguel in alugueis)
            {
                tabelaAlugueis.Rows.Add(
                    aluguel.Id,
                    aluguel.Desconto,
                    aluguel.ValorEntrada,
                    aluguel.ValorTotal,
                    aluguel.Cliente.Nome,
                    aluguel.Tema.Nome
                    );
            }
        }

        public int ObterIdSelecionado()
        {
            int id;
            try
            {
                id = Convert.ToInt32(tabelaAlugueis.SelectedRows[0].Cells["Id"].Value);
            }
            catch
            {
                id = -1;
            }
            return id;
        }
    }
}
