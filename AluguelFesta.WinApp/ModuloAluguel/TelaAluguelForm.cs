using AluguelFesta.Dominio.ModuloAluguel;
using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.Dominio.ModuloTema;
using AluguelFesta.WinApp.Compartilhado;
using System.Collections;

namespace AluguelFesta.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        Aluguel aluguel;
        IRepositorioCliente repositorioCliente;
        List<Cliente> clientes;
        List<Tema> temas;
        public TelaAluguelForm(List<Cliente> clientes, List<Tema> temas)
        {
            this.clientes = clientes;
            this.temas = temas;
            InitializeComponent();
            this.ConfigurarDialog();
            PopularComboBox(temas);
            PopularComboBox(clientes);
        }
        private void PopularComboBox(List<Cliente> clientes)
        {
            cboxClientes.Items.Clear();
            foreach (Cliente cliente in clientes)
            {
                cboxClientes.Items.Add(cliente);
            }
            cboxClientes.DisplayMember = "Nome";
        }
        private void PopularComboBox(List<Tema> temas)
        {
            cboxClientes.Items.Clear();
            foreach (Tema tema in temas)
            {
                cboxTema.Items.Add(tema);
            }
            cboxTema.DisplayMember = "Nome";
        }
        public Aluguel Aluguel
        {
            get
            {
                return this.aluguel;
            }
            set
            {
                cboxClientes.DataSource = repositorioCliente.SelecionarTodos();
                //TO-DO
            }

        }
        public Aluguel ObterAluguel()
        {
            decimal entrada = Convert.ToDecimal(tbValorEntrada.Text);
            decimal total = Convert.ToDecimal(tbValorTotal.Text);
            decimal desconto = Convert.ToInt32(tbValorTotal.Text);
            Cliente cliente = (Cliente)cboxClientes.SelectedItem;
            Tema tema = (Tema)cboxTema.SelectedItem;
            Festa festa = new Festa(
                Convert.ToDateTime(tbHorarioInicio.Text),
                Convert.ToDateTime(tbHorarioTermino.Text),
                new Endereco(
                    tbRua.Text,
                    Convert.ToInt32(tbNumeroCasaApto.Text),
                    tbCidade.Text,
                    tbEstado.Text
                    )
                );
            aluguel = new Aluguel(desconto, entrada, total, cliente, festa, tema);
            return aluguel;
        }

        public void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            cboxClientes.DataSource = this.clientes;
            cboxTema.DataSource = this.temas;
            tbRua.Text = aluguelSelecionado.Festa.Endereco.Rua;
            tbNumeroCasaApto.Text = aluguelSelecionado.Festa.Endereco.Numero.ToString();
            tbCidade.Text = aluguelSelecionado.Festa.Endereco.Cidade;
            tbEstado.Text = aluguelSelecionado.Festa.Endereco.Estado;
            tbValorEntrada.Text = aluguelSelecionado.Tema.CalcularTotal().ToString();
            //tbValorDesconto.Text = aluguelSelecionado.CalcularDesconto().ToString();
            //tbValorTotal.Text = aluguelSelecionado.CalcularDesconto().ToString();
        }
        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            this.aluguel = ObterAluguel();
            string[] erros = aluguel.Validar();

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
