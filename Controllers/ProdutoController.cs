using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("produtos")]
public class ProdutoController : ControllerBase
{
    
    [HttpGet]
    [ProducesResponseType(typeof(Produto),StatusCodes.Status200OK)]
    public IActionResult Get()
    {
        return Ok("Nao existem produtos cadastrados.");
    }
    // GET
    [HttpGet("{id:int}")]
    [ProducesResponseType(typeof(Produto),StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetById(int id)
    {
        return Ok(new Produto { Id = 1, Nome = "Iphone 14" });
    }

    [HttpPost]
    [ProducesResponseType(typeof(Produto),StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Post(Produto produto)
    {
        return CreatedAtAction(nameof(Post), new { id = produto.Id},produto);
    }
    
    [HttpPut("{id:int}")]
    [ProducesResponseType(typeof(Produto),StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Put([FromBody] Produto produto,int id)
    {
        if (id != produto.Id)
        {
            return BadRequest();
        }
        return NoContent();
    }
    
    [HttpDelete("{id:int}")]
    [ProducesResponseType(typeof(Produto),StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Delete(int id)
    {
        return NoContent();
    }
    
}