using AluguelFesta.Dominio.ModuloAluguel;

namespace AluguelFesta.Dominio.ModuloCliente
{
    internal class Cliente : EntidadeBase<Cliente>
    {
        public string Nome { get; set; }
        public List<Aluguel> HistoricoAlugueis { get; set; }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.Nome = registroAtualizado.Nome;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrEmpty(Nome))
                erros.Add("O campo 'nome' é obrigatório");
            return erros.ToArray();
        }
    }
}
