using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelFesta.WinApp.Compartilhado
{
    internal abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipExcluir { get; }


        public virtual void Filtrar() { }
        public virtual void Adicionar() { }
        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Excluir();
        public abstract UserControl ObterListagem();
        public abstract string ObterTipoCadastro();
    }
}
