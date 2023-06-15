using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            tabelaClientes.ConfigurarGridZebrado();
            tabelaClientes.ConfigurarGridSomenteLeitura();
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
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Telefone",
                    HeaderText = "Telefone"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Email",
                    HeaderText = "Email"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "HistoricoAlugueis",
                    HeaderText = "HistoricoAlugueis"
                }
            };
            tabelaClientes.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Cliente> cloientes)
        {
            tabelaClientes.Rows.Clear();

            foreach (Cliente cliente in cloientes)
            {
                tabelaClientes.Rows.Add(cliente.Id, cliente.Nome, cliente.Telefone, cliente.Email, cliente.HistoricoAlugueis);
            }
        }
        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(tabelaClientes.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}

