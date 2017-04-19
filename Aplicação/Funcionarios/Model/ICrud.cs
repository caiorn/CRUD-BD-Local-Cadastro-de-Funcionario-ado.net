using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.Others
{
    interface ICrud<T>
    {
        void Inserir();
        void Alterar();
        void Excluir();
    }
}
