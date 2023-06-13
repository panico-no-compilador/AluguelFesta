namespace AluguelFesta.Dominio.ModuloTema
{
    [Serializable]
    public abstract class Item : EntidadeBase<Item>
    {
        string Nome { get; set; }
        public double Valor { get; set; }
        public Item()
        {

        }

        public override void AtualizarInformacoes(Item registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
