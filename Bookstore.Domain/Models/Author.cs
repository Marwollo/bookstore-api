using System;

namespace Bookstore.Domain.Models
{
    public class Author : Entity<int>
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
        /// Static field for accessing an empty instance of an Author to
        /// prevent null exceptions and warnings
        /// </summary>
        public static readonly Author Empty = new();
    }
}

