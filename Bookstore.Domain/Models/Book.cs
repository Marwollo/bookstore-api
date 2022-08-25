using System;

namespace Bookstore.Domain.Models
{
    public class Book : Entity<int>
    {
        /// <summary>
        /// Gets and sets the title of the book
        /// </summary>
        public string Title { get; set; } = String.Empty;

        /// <summary>
        /// Gets and sets an object of an author for a book
        /// </summary>
        public Author Author { get; set; } = Author.Empty;

        /// <summary>
        /// Gets and sets the URL where image resource for cover image
        /// should be located
        /// </summary>
        public string CoverImageUrl { get; set; } = String.Empty;
    }
}

