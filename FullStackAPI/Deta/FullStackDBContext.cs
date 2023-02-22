using FullStackAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System.Runtime;

namespace FullStackAPI.Deta
{
    public class FullStackDBContext : DbContext
    {
        public FullStackDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Cars> Cars { get; set; }
    }
}
