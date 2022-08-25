using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Application.Common.Interfaces;
using Bookstore.Application.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bookstore.Web.Controllers
{
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(BookCreationDTO bookCreation)
        {
            try
            {
                await _bookService.CreateBookAsync(bookCreation);
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
                BookDTO? bookDTO = await _bookService.GetBookAsync(id);
                if (bookDTO == null)
                {
                    return new NotFoundResult();
                }
                return new OkObjectResult(bookDTO);
            }
            catch (Exception)
            {
                return new BadRequestResult();
            }
        }
    }
}

