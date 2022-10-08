using Boilerplate.Libraries.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Boilerplate.Libraries.Data
{
    public class Context : DbContext
    {
        public DbSet<Todo>? Todos { get; set; } = null!;
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}