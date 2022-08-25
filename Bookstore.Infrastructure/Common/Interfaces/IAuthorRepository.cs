using System;
using Bookstore.Domain.Models;

namespace Bookstore.Infrastructure.Common.Interfaces
{
    public interface IAuthorRepository
    {
        public Task<Author?> GetAuthorAsync(int id);
        public Task<int> CreateAuthorAsync(Author author);
        public Task DeleteAuthorAsync(Author author);
    }
}

