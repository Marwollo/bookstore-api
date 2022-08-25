using System;
using Bookstore.Domain.Models;

namespace Bookstore.Infrastructure.Common.Interfaces
{
    public interface IBookRepository
    {
        public Task<Book?> GetBookAsync(int id);
        public Task<List<Book>> SearchBooksAsync(Book filters);
        public Task DeleteBookAsync(Book book);
        public Task<Book> CreateBookAsync(Book book);
    }
}

