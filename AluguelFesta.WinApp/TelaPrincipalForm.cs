using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.Infra.Dados.Arquivo.Compartilhado;
using AluguelFesta.Infra.Dados.Arquivo.ModuloTema;
using AluguelFesta.WinApp.Compartilhado;
using AluguelFesta.WinApp.ModuloCliente;
using AluguelFesta.Infra.Dados.Arquivo.ModuloCliente;
using AluguelFesta.WinApp.ModuloAluguel;
using AluguelFesta.Dominio.ModuloAluguel;
using AluguelFesta.Infra.Dados.Arquivo.ModuloAluguel;
using AluguelFesta.WinApp.ModuloTema;
using AluguelFesta.Dominio.ModuloTema;
using System;

namespace AluguelFesta.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private static TelaPrincipalForm telaPrincipal;
        private ControladorBase controlador;
        private static ContextoDados contextoDados = new ContextoDados(carregarDados: true);
        private IRepositorioCliente repositorioCliente = new RepositorioClienteArquivo(contextoDados);
        private IRepositorioAluguel repositorioAluguel = new RepositorioAluguelArquivo(contextoDados);
        private IRepositorioTema repositorioTema = new RepositorioTemaArquivo(contextoDados);
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
        private void temaMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema(repositorioTema);
            ConfigurarTelaPrincipal(controlador);
            HabilitarBotoesCrud(true);
        }
        private void alugueisMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorAluguel(repositorioAluguel, repositorioCliente, repositorioTema);
            ConfigurarTelaPrincipal(controlador);
            HabilitarBotoesCrud(false);
        }
        private void clienteMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente(repositorioCliente);
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }
        private void btnInserirItens_Click(object sender, EventArgs e)
        {
            controlador.AdicionarItens();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();

        }
    }
}