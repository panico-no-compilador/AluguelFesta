using AluguelFesta.Dominio.ModuloCliente;
using AluguelFesta.Dominio.ModuloTema;

namespace AluguelFesta.Dominio.ModuloAluguel
{
    [Serializable]
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public decimal Desconto { get; set; }
        public decimal ValorEntrada { get; set; }
        public decimal ValorTotal { get; set; }
        public Cliente Cliente { get; set; }
        public Tema Tema { get; set; }
        public Aluguel()
        {
            
        }

        public Aluguel(decimal desconto, decimal valorEntrada, decimal valorTotal, Cliente cliente, Tema tema)
        {
            this.Desconto = desconto;
            this.ValorEntrada = valorEntrada;
            this.ValorTotal = valorTotal;
            this.Cliente = cliente;
            this.Tema = tema;
        }

        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
            this.Desconto = registroAtualizado.Desconto;
            this.ValorEntrada = registroAtualizado.ValorEntrada;
            this.ValorTotal = registroAtualizado.ValorTotal;
            this.Cliente = registroAtualizado.Cliente;
            this.Tema = registroAtualizado.Tema;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (ValorEntrada == null)
                erros.Add("O campo 'ValorEntrada' é obrigatório");
            if (Cliente == null)
                erros.Add("O campo 'Cliente' é obrigatório");
            if (Tema == null)
                erros.Add("O campo 'Tema' é obrigatório");
            return erros.ToArray();
        }
    }
}
