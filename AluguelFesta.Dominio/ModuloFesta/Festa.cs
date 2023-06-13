namespace AluguelFesta.Dominio.ModuloFesta
{
    [Serializable]
    public class Festa : EntidadeBase<Festa>
    {
        TimeSpan InicioFesta { get; set; }
        TimeSpan TerminoFesta { get; set; }
        public Endereco Endereco { get; set; }

        public override void AtualizarInformacoes(Festa registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
