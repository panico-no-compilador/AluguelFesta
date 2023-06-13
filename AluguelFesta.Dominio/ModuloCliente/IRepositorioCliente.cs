﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelFesta.Dominio.ModuloCliente
{
    public interface IRepositorioCliente
    {
        void Inserir(Cliente novoCliente);
        void Editar(int id, Cliente cliente);
        void Excluir(Cliente clienteSelecionado);
        List<Cliente> SelecionarTodos();
        Cliente SelecionarPorId(int id);
    }
}
