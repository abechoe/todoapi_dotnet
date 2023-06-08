using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoController : ControllerBase
{

  private readonly TodoContext _context;

  public TodoController(TodoContext context)
  {
    _context = context;
  }

  [HttpGet]
  public string GetTodoItems()
  {
    // _context.TodoItems.Select(item => ItemToDTO)
    return "Hello World!";
  }
}