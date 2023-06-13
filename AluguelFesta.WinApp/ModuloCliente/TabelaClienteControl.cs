using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.WinApp.Compartilhado;

namespace AluguelFesta.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            gridClientes.ConfigurarGridZebrado();
            gridClientes.ConfigurarGridSomenteLeitura();
        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "telefone",
                    HeaderText = "Telefone"
                }
            };

            gridClientes.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Cliente> contatos)
        {
            gridClientes.Rows.Clear();
            foreach (Cliente contato in contatos)
            {
                gridClientes.Rows.Add(contato.Id, contato.Nome, contato.Telefone);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(gridClientes.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
