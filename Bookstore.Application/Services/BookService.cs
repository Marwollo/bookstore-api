using System;
using Bookstore.Application.Common.Interfaces;
using Bookstore.Application.DTO;
using Bookstore.Domain.Models;
using Bookstore.Infrastructure.Common.Interfaces;

namespace Bookstore.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<BookDTO> CreateBookAsync(BookCreationDTO bookCreationDTO)
        {
            Book book = await _bookRepository.CreateBookAsync(bookCreationDTO.ToEntityModel());
            return BookDTO.FromEntityModel(book);
        }

        public async Task DeleteBookAsync(int id)
        {
            Book? book = await _bookRepository.GetBookAsync(id);
            if (book == null)
            {
                return;
            }
            await _bookRepository.DeleteBookAsync(book);
        }

        public async Task<BookDTO?> GetBookAsync(int id)
        {
            Book? book = await _bookRepository.GetBookAsync(id);
            if (book == null)
            {
                return null;
            }

            return BookDTO.FromEntityModel(book);
        }

        public async Task<List<BookDTO>> SearchBooksAsync(BookDTO filters)
        {
            List<Book> books = await _bookRepository.SearchBooksAsync(filters.ToEntityModel());

            return books.Select(book => BookDTO.FromEntityModel(book)).ToList();
        }
    }
}

