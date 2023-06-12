using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.Dominio.ModuloFesta;

namespace AluguelFesta.Dominio.ModuloAluguel
{
    [Serializable]
    internal class Aluguel : EntidadeBase<Aluguel>
    {
        public int Desconto { get; set; }
        public decimal ValorEntrada { get; set; }
        public decimal ValorTotal { get; set; }
        public Cliente Cliente { get; set; }
        public Tema Tema { get; set; }

        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
