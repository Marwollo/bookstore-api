using System;
using Microsoft.EntityFrameworkCore;
using Bookstore.Domain.Models;
using Bookstore.Domain.Master;

namespace Bookstore.Infrastructure.Persistence.Interfaces
{
    public interface IApplicationDBContext
    {
        DbSet<AppSetting> AppSettings { get; set; }
        DbSet<Author> Authors { get; set; }
        DbSet<Book> Books { get; set; }

        Task<int> SaveChangesAsync();
    }
}

