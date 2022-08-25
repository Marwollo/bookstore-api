using System;
using Bookstore.Application.DTO;
using Bookstore.Application.Common.Interfaces;
using Bookstore.Domain.Models;
using Bookstore.Infrastructure.Common.Interfaces;

namespace Bookstore.Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<int> CreateAuthorAsync(AuthorCreationDTO author)
        {
            return await _authorRepository.CreateAuthorAsync(author.ToEntityModel());
        }

        public async Task DeleteAuthorAsync(int id)
        {
            Author? author = await _authorRepository.GetAuthorAsync(id);
            if (author == null)
            {
                return;
            }
            await _authorRepository.DeleteAuthorAsync(author);
        }

        public async Task<AuthorDTO?> GetAuthorAsync(int id)
        {
            Author? author = await _authorRepository.GetAuthorAsync(id);
            if (author == null)
            {
                return null;
            }

            return AuthorDTO.FromEntityModel(author);
        }
    }
}

