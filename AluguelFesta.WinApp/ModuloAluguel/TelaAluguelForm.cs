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
        public TelaAluguelForm(List<Cliente> clientes)
        {
            //this.repositorioCliente = _repositorioCliente;
            InitializeComponent();
            this.ConfigurarDialog();
            PopularComboBox(clientes);
        }
        private void PopularComboBox(List<Cliente> clientes)
        {
            cboxClientes.Items.Clear();
            foreach (Cliente cliente in clientes)
            {
                cboxClientes.Items.Add(cliente);
            }
            //cboxClientes.DataSource = repositorioCliente.SelecionarTodos();
            //cboxTema.DataSource = repositorioTema.SelecionarTodos();
            cboxClientes.DisplayMember = "Nome";
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
            //txtNome.Text = cliente.Nome;
            //txtTelefone.Text = cliente.Telefone.ToString();
            //txtEmail.Text = cliente.Email;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Tema tema = (Tema)cboxTema.SelectedValue;
            Cliente cliente = (Cliente)cboxClientes.SelectedValue;
            decimal entrada = 500;
            decimal total = 1000;
            Festa festa = new Festa(
                Convert.ToDateTime(tbHorarioInicio.Text),
                Convert.ToDateTime(tbHorarioTermino.Text),
                new Endereco(
                    tbRua.Text,
                    Convert.ToInt32(tbNumeroCasaApto.Text),
                    tbCidade.Text,
                    tbEstado.Text)
                );

            decimal desconto = (Convert.ToDecimal(cliente.HistoricoAlugueis.Count) / 100) * total;
            aluguel = new Aluguel(desconto, entrada, total, cliente, festa);
        }
    }
}
