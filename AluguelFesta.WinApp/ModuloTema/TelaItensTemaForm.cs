using AluguelFesta.Dominio.ModuloTema;
using AluguelFesta.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            CarregarItem();
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
        public void AtualizarRegistros(List<Item> itens)
        {
            gridItens.Rows.Clear();

            foreach (Item item in itens)
            {
                gridItens.Rows.Add(
                    item.Id,
                    item.Nome,
                    item.Valor
                    );
            }
        }
        public int ObterIdSelecionado()
        {
            int id;
            try
            {
                id = Convert.ToInt32(gridItens.SelectedRows[0].Cells["Id"].Value);
            }
            catch
            {
                id = -1;
            }
            return id;
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
            CarregarItem();
        }

        private void CarregarItem()
        {
            gridItens.Rows.Clear();
            foreach (Item item in Tema.Itens)
            {
                gridItens.Rows.Add(
                    item.Nome,
                    item.Valor
                    );
            }
        }

        private void btnDeletarItem_Click(object sender, EventArgs e)
        {

        }
        //public List<Item> ObterItensCadastrados()
        //{
        //    return tabelaItens.Items.Cast<Item>().ToList();
        //}
    }
}
