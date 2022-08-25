using System;
using Bookstore.Domain.Models;
using Bookstore.Infrastructure.Common.Interfaces;
using Bookstore.Infrastructure.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IApplicationDBContext _context;

        public BookRepository(IApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Book> CreateBookAsync(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return book;
        }

        public async Task DeleteBookAsync(Book book)
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }

        public async Task<Book?> GetBookAsync(int id)
        {
            return await _context.Books.Where(book => book.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Book>> SearchBooksAsync(Book filters)
        {
            return await _context.Books.Where(book => book == filters).ToListAsync();
        }
    }
}

