using System;
using Bookstore.Application.DTO;
using Bookstore.Domain.Models;

namespace Bookstore.Application.Common.Interfaces
{
    public interface IAuthorService
    {
        public Task<AuthorDTO?> GetAuthorAsync(int id);
        public Task DeleteAuthorAsync(int id);
        public Task<int> CreateAuthorAsync(AuthorCreationDTO author);
    }
}

