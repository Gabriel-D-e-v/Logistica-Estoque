using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica_Estoque
{
    internal interface IEstoque
    {
        void Entrada();
        void Saida();
        void Exibir();
    }
}
