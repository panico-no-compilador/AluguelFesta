using AluguelFesta.Dominio.ModuloAluguel;
using System.Runtime.CompilerServices;

namespace AluguelFesta.Dominio.ModuloCliente
{
    [Serializable]
    public class Cliente : EntidadeBase<Cliente>
    {
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public List<Aluguel> HistoricoAlugueis { get; set; }
        public Cliente()
        {
            
        }
        public Cliente(string nome, int telefone, string email)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }
        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.Nome = registroAtualizado.Nome;
            this.Telefone = registroAtualizado.Telefone;
            this.Email = registroAtualizado.Email;
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
