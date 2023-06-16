using AluguelFesta.Dominio.ModuloTema;
using AluguelFesta.WinApp.Compartilhado;

namespace AluguelFesta.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            tabelaTemas.ConfigurarGridSomenteLeitura();
            tabelaTemas.ConfigurarGridZebrado();
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
                    Name = "Nome",
                    HeaderText = "Nome"
                }
            };
            tabelaTemas.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Tema> temas)
        {
            tabelaTemas.Rows.Clear();

            foreach (Tema tema in temas)
            {
                tabelaTemas.Rows.Add(
                    tema.Id,
                    tema.Nome
                    );
            }
        }
        public int ObterIdSelecionado()
        {
            int id;
            try
            {
                id = Convert.ToInt32(tabelaTemas.SelectedRows[0].Cells["Id"].Value);
            }
            catch
            {
                id = -1;
            }
            return id;
        }
    }
}
