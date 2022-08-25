using System;

namespace Bookstore.Domain.Models
{
    public abstract class Entity<T>
    {
        public virtual T Id { get; set; }
    }
}

