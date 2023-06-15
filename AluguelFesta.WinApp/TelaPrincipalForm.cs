using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.Infra.Dados.Arquivo.Compartilhado;
using AluguelFesta.WinApp.Compartilhado;
using AluguelFesta.WinApp.ModuloCliente;
using AluguelFesta.Infra.Dados.Arquivo.ModuloCliente;
using System.Xml.Serialization;

namespace AluguelFesta.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private static TelaPrincipalForm telaPrincipal;
        private ControladorBase controlador;
        private static ContextoDados contextoDados = new ContextoDados(carregarDados: true);
        private IRepositorioCliente repositorioCliente = new RepositorioClienteArquivo(contextoDados);
        
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }
        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();
                return telaPrincipal;
            }
        }
        private void clienteMenuItem_Click(object sender, EventArgs e)
        {
            
            ConfigurarTelaPrincipal(controlador);
            HabilitarBotoesCrud(false);
        }

        


        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            toolStripTipoCadastro.Text = controladorBase.ObterTipoCadastro();
            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
        }
        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }
        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            painelRegistros.Controls.Clear();
            painelRegistros.Controls.Add(listagem);
        }
        private void HabilitarBotoesCrud(bool temItem)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnInserir.Enabled = true;

            if (temItem)
            {
                btnInserirItens.Enabled = true;
            }
            else
            {
                btnInserirItens.Enabled = false;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }
    }
}