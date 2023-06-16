namespace AluguelFesta.Dominio.ModuloAluguel
{
    [Serializable]
    public class Festa : EntidadeBase<Festa>
    {
        DateTime InicioFesta { get; set; }
        DateTime TerminoFesta { get; set; }
        public Endereco Endereco { get; set; }
        public Festa()
        {
            
        }

        public Festa(DateTime inicioFesta, DateTime terminoFesta, Endereco endereco)
        {
            InicioFesta = inicioFesta;
            TerminoFesta = terminoFesta;
            Endereco = endereco;
        }

        public override void AtualizarInformacoes(Festa registroAtualizado)
        {
            InicioFesta = registroAtualizado.InicioFesta;
            TerminoFesta = registroAtualizado.TerminoFesta;
            Endereco = registroAtualizado.Endereco;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (InicioFesta == null)
                erros.Add("O campo 'InicioFesta' é obrigatório");
            if (TerminoFesta == null)
                erros.Add("O campo 'TerminoFesta' é obrigatório");
            if (this.Endereco.Rua == null)
                erros.Add("O campo 'Rua' é obrigatório");
            if (this.Endereco.Numero == null)
                erros.Add("O campo 'Numero' é obrigatório");
            if (this.Endereco.Cidade == null)
                erros.Add("O campo 'Cidade' é obrigatório");
            if (this.Endereco.Estado == null)
                erros.Add("O campo 'Cidade' é obrigatório");
            return erros.ToArray();
        }
    }
}
