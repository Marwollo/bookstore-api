using System;
using Bookstore.Application.DTO;

namespace Bookstore.Application.Common.Interfaces
{
    public interface IBookService
    {
        public Task<BookDTO?> GetBookAsync(int id);
        public Task<BookDTO> CreateBookAsync(BookCreationDTO bookCreationDTO);
        public Task<List<BookDTO>> SearchBooksAsync(BookDTO filters);
        public Task DeleteBookAsync(int id);
    }
}

