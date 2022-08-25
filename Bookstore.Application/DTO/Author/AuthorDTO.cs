using System;
using Bookstore.Application.DTO;
using Bookstore.Domain.Models;

namespace Bookstore.Application.DTO
{
    public class AuthorDTO
    {
        /// <summary>
        /// Gets and sets the ID of an author
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets and sets the first name of an author
        /// </summary>
        public string FirstName { get; set; } = String.Empty;

        /// <summary>
        /// Gets and sets the last name of an author
        /// </summary>
        public string LastName { get; set; } = String.Empty;

        /// <summary>
        /// Gets and sets the URL where the resource of a profile picture
        /// should be located
        /// </summary>
        public string ProfilePictureUrl { get; set; } = String.Empty;

        /// <summary>
        /// Maps author object to a DTO object
        /// </summary>
        /// <param name="author">Author object that should be mapped</param>
        /// <returns>Mapped DTO object</returns>
        public static AuthorDTO FromEntityModel(Author author)
        {
            return new()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                ProfilePictureUrl = author.ProfilePictureUrl
            };
        }

        /// <summary>
        /// Maps DTO to the entity model
        /// </summary>
        /// <returns>Author model based on the DTO</returns>
        public Author ToEntityModel()
        {
            return new()
            {
                Id = this.Id,
                FirstName = this.FirstName,
                LastName = this.LastName,
                ProfilePictureUrl = this.ProfilePictureUrl
            };
        }
    }
}

