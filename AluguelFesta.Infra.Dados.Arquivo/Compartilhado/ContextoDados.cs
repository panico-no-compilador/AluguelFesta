using System.Text.Json.Serialization;
using System.Text.Json;
using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.Dominio.ModuloAluguel;
using AluguelFesta.Dominio.ModuloTema;

namespace AluguelFesta.Infra.Dados.Arquivo.Compartilhado
{
    public class ContextoDados
    {
        private const string NOME_ARQUIVO = "e-Agenda.json";
        public List<Cliente> clientes;
        public List<Aluguel> alugueis;
        public List<Item> itens;

        public ContextoDados()
        {
            clientes = new List<Cliente>();
            alugueis = new List<Aluguel>();
            itens = new List<Item>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();
            string registrosJson = JsonSerializer.Serialize(this, config);
            File.WriteAllText(NOME_ARQUIVO, registrosJson);
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();
            if (File.Exists(NOME_ARQUIVO))
            {
                string registrosJson = File.ReadAllText(NOME_ARQUIVO);
                if (registrosJson.Length > 0)
                {
                    ContextoDados contextoDo = JsonSerializer.Deserialize<ContextoDados>(registrosJson, config);
                    this.clientes = contextoDo.clientes;
                    this.alugueis = contextoDo.alugueis;
                    this.itens = contextoDo.itens;
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;
            return opcoes;
        }
    }
}
