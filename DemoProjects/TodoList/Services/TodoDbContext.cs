using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace TodoList.Services
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options) { }
    }
}
