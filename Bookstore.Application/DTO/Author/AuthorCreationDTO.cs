using System;
using Bookstore.Domain.Models;

namespace Bookstore.Application.DTO
{
    public class AuthorCreationDTO
    {
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
        public static AuthorCreationDTO FromEntityModel(Author author)
        {
            return new()
            {
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
                FirstName = this.FirstName,
                LastName = this.LastName,
                ProfilePictureUrl = this.ProfilePictureUrl
            };
        }
    }
}

