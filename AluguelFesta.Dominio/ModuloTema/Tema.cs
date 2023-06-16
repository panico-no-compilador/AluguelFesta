namespace AluguelFesta.Dominio.ModuloTema
{
    [Serializable]
    public class Tema : EntidadeBase<Tema>
    {
        public string Nome { get; set; }
        public List<Item> Itens { get; set; }
        public Tema()
        {
            
        }

        public Tema(string nome)
        {
            Nome = nome;
            Itens = new List<Item>();
        }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
            Nome = registroAtualizado.Nome;
        }

        public decimal CalcularTotal()
        {
            return 2;
        }
        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
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
