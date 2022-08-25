using Bookstore.Application.Common.Interfaces;
using Bookstore.Application.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Web.Controllers;

[ApiController]
[Route("author")]
public class AuthorController : ControllerBase
{
    private readonly IAuthorService _authorService;
  
    public AuthorController(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(AuthorCreationDTO authorCreation)
    {
        try
        {
            int id = await _authorService.CreateAuthorAsync(authorCreation);
            return new OkResult();
        }
        catch (Exception)
        {
            return new BadRequestResult();
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync(int id)
    {
        try
        {
            AuthorDTO? authorDTO = await _authorService.GetAuthorAsync(id);
            if (authorDTO == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(authorDTO);
        }
        catch (Exception)
        {
            return new BadRequestResult();
        }
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        try
        {
            await _authorService.DeleteAuthorAsync(id);
            return new OkResult();
        }
        catch (Exception)
        {
            return new BadRequestResult();
        }
    }
}

