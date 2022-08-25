using System;
using Bookstore.Infrastructure.Persistence.Interfaces;
using Bookstore.Domain.Master;
using Bookstore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Infrastructure.Persistence
{
    public class ApplicationDBContext : DbContext, IApplicationDBContext 
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> contextOptions)
            : base(contextOptions)
        {
        }

        /// <summary>
        /// Entity database set for storing important application settings
        /// and values.
        /// </summary>
        public DbSet<AppSetting> AppSettings { get; set; }

        /// <summary>
        /// Entity database set for storing authors
        /// </summary>
        public DbSet<Author> Authors { get; set; }

        /// <summary>
        /// Entity database set for storing books
        /// </summary>
        public DbSet<Book> Books { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}

