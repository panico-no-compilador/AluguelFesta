namespace AluguelFesta.Dominio.Compartilhado
{
    [Serializable]
    internal abstract class EntidadeBase<TEntidade>
    {
        int Id { get; set; }
        public abstract void AtualizarInformacoes(TEntidade registroAtualizado);
        public abstract string[] Validar();
    }
}
