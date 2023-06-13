using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.WinApp.Compartilhado;

namespace AluguelFesta.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;
        public TelaClienteForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }
        public Cliente Cliente 
        {
            get
            {
                return this.cliente;
            }            
            set
            {
                txtNome.Text = value.Nome;
                txtTelefone.Text = value.Telefone.ToString();
                txtEmail.Text = value.Email;
            }
        
        }
        public Cliente ObterCliente()
        {

            string nome = txtNome.Text;
            int telefone = Convert.ToInt32(txtTelefone.Text);
            string email = txtEmail.Text;
            Cliente cliente = new Cliente(nome, telefone, email);
            return cliente;
        }

        public void ConfigurarTela(Cliente cliente)
        {
            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone.ToString();
            txtEmail.Text = cliente.Email;
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int telefone = Convert.ToInt32(txtTelefone.Text);
            string email = txtEmail.Text;
            cliente = new Cliente(nome, telefone, email);
        }
    }
}
