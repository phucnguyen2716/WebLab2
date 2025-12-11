using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Models
{
    class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
