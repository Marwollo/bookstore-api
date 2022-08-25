using System;
using Bookstore.Domain.Models;

namespace Bookstore.Application.DTO
{
    public class BookCreationDTO
    {
        /// <summary>
        /// Gets and sets the title of the book
        /// </summary>
        public string Title { get; set; } = String.Empty;

        /// <summary>
        /// Gets and sets an object of an author ID for a book
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// Gets and sets the URL where image resource for cover image
        /// should be located
        /// </summary>
        public string CoverImageUrl { get; set; } = String.Empty;

        /// <summary>
        /// Maps book object to a DTO object
        /// </summary>
        /// <param name="book">Book object that should be mapped</param>
        /// <returns>Mapped DTO object</returns>
        public static BookCreationDTO FromEntityModel(Book book)
        {
            return new()
            {
                Title = book.Title,
                AuthorId = book.Author.Id,
                CoverImageUrl = book.CoverImageUrl
            };
        }

        /// <summary>
        /// Maps DTO to the entity model
        /// </summary>
        /// <returns>Book model based on the DTO</returns>
        public Book ToEntityModel()
        {
            return new()
            {
                Title = this.Title,
                Author = new Author() { Id = this.AuthorId },
                CoverImageUrl = this.CoverImageUrl
            };
        }
    }
}

