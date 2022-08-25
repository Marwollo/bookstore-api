using System;
using Bookstore.Domain.Models;
using Bookstore.Infrastructure.Persistence.Interfaces;
using Bookstore.Infrastructure.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IApplicationDBContext _context;

        public AuthorRepository(IApplicationDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates a new author in the database based on the provided model
        /// </summary>
        /// <param name="author">Object of an author to be added</param>
        /// <returns>Identifier of the author (ID) in the database</returns>
        public async Task<int> CreateAuthorAsync(Author author)
        {
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();

            return author.Id;
        }

        /// <summary>
        /// Deletes an author from the database.
        /// </summary>
        /// <param name="author">Object of an author to be added</param>
        /// <returns></returns>
        public async Task DeleteAuthorAsync(Author author)
        {
            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Gets an author by the identifier / ID, from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Author?> GetAuthorAsync(int id)
        {
            return await _context.Authors.Where(author => author.Id == id).FirstOrDefaultAsync();
        }
    }
}

