using System;
using Bookstore.Domain.Models;

namespace Bookstore.Domain.Master
{
    public class AppSetting : Entity<int>
    {
        /// <summary>
        /// Gets or sets the reference key.
        /// </summary>
        public string ReferenceKey { get; set; } = String.Empty;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string Value { get; set; } = String.Empty;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string DescripTimeOnly { get; set; } = String.Empty;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; } = String.Empty;
    }
}

