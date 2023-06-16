namespace AluguelFesta.Dominio.ModuloTema
{
    public interface IRepositorioTema
    {
        void Inserir(Tema novoCliente);
        void Editar(int id, Tema cliente);
        void Excluir(Tema clienteSelecionado);
        List<Tema> SelecionarTodos();
        Tema SelecionarPorId(int id);
    }
}
