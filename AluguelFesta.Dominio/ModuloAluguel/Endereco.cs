using System.Security.Cryptography;

namespace AluguelFesta.Dominio.ModuloAluguel
{
    [Serializable]
    public class Endereco
    {

        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Endereco()
        {
        }

        public Endereco(string rua, int numero, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
        }
        public virtual void AtualizarInformacoes(Endereco registroAtualizado)
        {
            this.Rua = registroAtualizado.Rua;
            this.Numero = registroAtualizado.Numero;
            this.Cidade = registroAtualizado.Cidade;
            this.Estado = registroAtualizado.Estado;
        }
    }
}
