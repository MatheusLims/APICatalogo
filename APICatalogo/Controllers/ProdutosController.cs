using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> Get2() 
        {
            //var produtos = _context.Produtos.Take(10).ToList(); -> Retorna um valor máximo da requisição sem necessitar retornar TODOS os produtos
            return await _context.Produtos.AsNoTracking().ToListAsync();
        }

        [HttpGet("{id:int:min(1)}", Name ="ObterProduto")]
        public async Task<ActionResult<Produto>> Get(int id)
        {
            var produto = await _context.Produtos.AsNoTracking().
                FirstOrDefaultAsync(p => p.ProdutoId == id);
            if(produto is null)
            {
                return NotFound($"Produto com id={id} não encontrado.");
            }
            return produto;
        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            if (produto is null)
                return BadRequest("Dados inválidos");

            _context.Produtos.Add(produto); // adicionar produto ao contexto
            _context.SaveChanges(); //persistir no banco de dados

            return new CreatedAtRouteResult("ObterProduto", // Adiciona o Status 201 - Created
                new { id = produto.ProdutoId }, produto);
        }

        [HttpPut("{id:int:min(1)}")]
        public ActionResult Put(int id, Produto produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest("Dados inválidos");
            }

            _context.Entry(produto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return Ok(produto);
        }

        [HttpDelete("{id:int:min(1)}")]
        public ActionResult Delete(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);

            if (produto is null)
            {
                return NotFound($"Produto com id={id} não encontrado.");
            }

            _context.Produtos.Remove(produto);
            _context.SaveChanges();

            return Ok(produto);
        }
    }
}
