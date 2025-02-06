using DesafioPratico_Rocketseat_GestaoDeLivaria.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace DesafioPratico_Rocketseat_GestaoDeLivaria.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookstoreController : ControllerBase
{
  private static List<Book> books = [];

  [HttpPost]
  [ProducesResponseType(typeof(Book), StatusCodes.Status201Created)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public IActionResult Post([FromBody] Book newBook)
  {
    if (newBook == null)
      return BadRequest();

    books.Add(newBook);
    return Created();
  }

  [HttpPut]
  [Route("{id}")]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  [ProducesResponseType(StatusCodes.Status400BadRequest)]
  public IActionResult Update([FromRoute] int id, [FromBody] Book newBook)
  {
    if (newBook == null)
      return BadRequest();

    books[id] = newBook;
    return NoContent();
  }

  [HttpGet]
  public IActionResult Get()
  {
    return Ok(books);
  }

  [HttpDelete]
  [Route("{id}")]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  [ProducesResponseType(StatusCodes.Status404NotFound)]
  public IActionResult Delete([FromRoute] int id)
  {
    if (!books.Any(book => book.Id == id))
      return NotFound();

    books.RemoveAt(id);
    return NoContent();
  }
}
