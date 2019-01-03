using BasketApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketApi.Repositorio
{
    interface IBasketRepositorio
    {
        void AdicionarProduto(Produto produto);
        Resultado RemoverProdutos(int id);
    }
}
