using AluguelFesta.Dominio.ModuloAluguel;
using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.Dominio.ModuloTema;
using AluguelFesta.WinApp.Compartilhado;

namespace AluguelFesta.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        Aluguel aluguel;
        public TelaAluguelForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }
        public Aluguel Aluguel
        {
            get
            {
                return this.aluguel;
            }
            set
            {
                //cboxTema.Text = value.Tema.ToString();
                //txtTelefone.Text = value.Telefone.ToString();
                //txtEmail.Text = value.Email;
            }

        }
        public Aluguel ObterAluguel()
        {
            Tema tema = null; //funcao para obter lista de tema
            Cliente cliente = null; //funcao para obter lista de tema
            decimal entrada = Convert.ToDecimal(tbValorEntrada.Text);
            decimal total = Convert.ToDecimal(tbValorTotal.Text);
            decimal desconto = Convert.ToInt32(tbValorTotal.Text);
            aluguel = new Aluguel(desconto, entrada, total, cliente, tema);
            return aluguel;
        }

        public void ConfigurarTela(Aluguel cliente)
        {
            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone.ToString();
            txtEmail.Text = cliente.Email;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Tema tema = cboxTema.SelectedItem as Tema;
            Cliente cliente = cboxClientes.SelectedItem as Cliente;
            decimal entrada = 500; //40 ou 50% do total
            decimal total = 1000;

            decimal desconto = (Convert.ToDecimal(cliente.HistoricoAlugueis.Count) / 100) * total;
            aluguel = new Aluguel(desconto, entrada, total, cliente, tema);
        }
    }
}
