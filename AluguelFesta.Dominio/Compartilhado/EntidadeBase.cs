namespace AluguelFesta.Dominio.Compartilhado
{
    [Serializable]
    public abstract class EntidadeBase<TEntidade>
    {
        public int Id { get; set; }
        public abstract void AtualizarInformacoes(TEntidade registroAtualizado);
        public abstract string[] Validar();
    }
}
