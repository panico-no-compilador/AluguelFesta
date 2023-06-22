using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.Dominio.ModuloTema;
using AluguelFesta.WinApp.Compartilhado;
using System.Linq;

namespace AluguelFesta.WinApp.ModuloTema
{
    public partial class TelaItensTemaForm : Form
    {
        Item item;
        Tema tema;
        public TelaItensTemaForm(Tema tema)
        {
            this.tema = tema;
            InitializeComponent();
            ConfigurarTela(tema);
            ConfigurarColunas();
            gridItens.ConfigurarGridSomenteLeitura();
            gridItens.ConfigurarGridZebrado();
            AtualizarRegistros(Tema.Itens);
        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "Nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Valor",
                    HeaderText = "Valor"
                }
            };
            gridItens.Columns.AddRange(colunas);
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
        public Item Item
        {
            get
            {
                return this.item;
            }
            set
            {
                tbItem.Text = value.Nome;
                tbValorItem.Text = value.Valor.ToString();
            }
        }
        public string ObterItemSelecionado()
        {
            string nome;
            try
            {
                nome = gridItens.SelectedRows[0].Cells["Nome"].Value.ToString();
            }
            catch
            {
                nome = "";
            }
            return nome;
        }
        private void ConfigurarTela(Tema tema)
        {
            tbNomeTema.Text = tema.Nome;
        }
        public Item ObterItem()
        {
            string item = tbItem.Text;
            decimal valor = Convert.ToDecimal(tbValorItem.Text);
            return new Item(item, valor);
        }
        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            this.item = ObterItem();
            string[] erros = item.Validar();
            Tema.Itens.Add(this.item);
            AtualizarRegistros(Tema.Itens);
        }
        public void AtualizarRegistros(List<Item> itens)
        {
            gridItens.Rows.Clear();

            foreach (Item item in itens)
            {
                gridItens.Rows.Add(
                    item.Nome,
                    item.Valor
                    );
            }
        }
        private void btnDeletarItem_Click(object sender, EventArgs e)
        {
            string nomeSelecionado = ObterItemSelecionado();
            if (nomeSelecionado != "")
            {
                Item itemSelecionado = Tema.Itens.FirstOrDefault(i => i.Nome == nomeSelecionado);
                if (itemSelecionado != null)
                {
                    Tema.Itens.Remove(itemSelecionado);
                    AtualizarRegistros(Tema.Itens);
                }
            }
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            string[] erros = this.item.Validar();

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
