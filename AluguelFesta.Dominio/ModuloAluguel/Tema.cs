using AluguelFesta.Dominio.Compartilhado;
using AluguelFesta.Dominio.ModuloAluguel;

namespace AluguelFesta.Dominio.ModuloFesta
{
    internal class Tema : EntidadeBase<Tema>
    {
        public string Nome { get; set; }
        public List<Item> Itens { get; set; }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public decimal CalcularTotal()
        {
            return 2;
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
