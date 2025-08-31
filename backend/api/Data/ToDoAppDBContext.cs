using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
  public class ToDoAppDBContext(DbContextOptions<ToDoAppDBContext> dbContextOptions) : DbContext(dbContextOptions)
  {
    public DbSet<Bucket> Buckets { get; set; }
  }
}
