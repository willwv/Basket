using BasketApi.Model;
using BasketApi.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BasketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private BasketRepositorio basketRepositorio = new BasketRepositorio();
        // POST api/values
        [HttpPost]
        public ActionResult<Resultado> AdicionarProduto([FromBody] Produto produto)
        {
            basketRepositorio.AdicionarProduto(produto);

            return new Resultado() { Sucesso = true, Mensagem = "Produto adicionado com sucesso."};

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Resultado> RemoverProdutoPorId(int id)
        {
            return basketRepositorio.RemoverProdutos(id);
        }
    }
}
