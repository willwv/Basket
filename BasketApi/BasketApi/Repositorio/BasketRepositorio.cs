using BasketApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketApi.Repositorio
{
    public class BasketRepositorio : IBasketRepositorio
    {
        private static List<Produto> ListaProdutos = new List<Produto>()
        {
            new Produto()
            {
                Id = 1,
                Nome = "Gabinete",
                Descricao = "MID Tower",
                Preco = 230.00
            }
        };

        public void AdicionarProduto(Produto produto)
        {
            ListaProdutos.Add(produto);
        }

        public Resultado RemoverProdutos(int id)
        {
            bool sucesso;
            string mensagem = string.Empty;

            if(!ListaProdutos.Where(produto => produto.Id.Equals(id)).ToList().Any())
            {
                sucesso = false;
                mensagem = "Produto Não Encontrado na Lista de Produtos.";
            }
            else
            {
                ListaProdutos = ListaProdutos.Where(produto => !produto.Id.Equals(id)).ToList();
                sucesso = true;
                mensagem = "Produto Removido da Lista de Produtos.";
            }

            return new Resultado() { Sucesso = sucesso, Mensagem = mensagem };
        }
    }
}
