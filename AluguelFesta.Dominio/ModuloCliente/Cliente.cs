using AluguelFesta.Dominio.ModuloAluguel;

namespace AluguelFesta.Dominio.ModuloCliente
{
    internal class Cliente : EntidadeBase<Cliente>
    {
        public string Nome { get; set; }
        public List<Aluguel> HistoricoAlugueis { get; set; }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
