namespace AluguelFesta.Dominio.ModuloTema
{
    [Serializable]
    public class Item : EntidadeBase<Item>
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Item()
        {

        }

        public Item(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public override void AtualizarInformacoes(Item registroAtualizado)
        {
            Nome = registroAtualizado.Nome;
            Valor = registroAtualizado.Valor;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrEmpty(Nome))
                erros.Add("O campo 'nome' é obrigatório"); 
            if (this.Valor == null)
                erros.Add("O campo 'Valor' é obrigatório");
            return erros.ToArray();
        }
    }
}
