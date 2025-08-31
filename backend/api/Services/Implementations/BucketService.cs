using api.Data;
using api.Models.DTO;
using api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api.Services.Implementations
{
  public class BucketService(ToDoAppDBContext _dbContext) : IBucketService
  {
    private readonly ToDoAppDBContext _db = _dbContext;

    public async Task<List<BucketDTO>> GetBuckets()
    {
      var buckets = await _db.Buckets.Select(b => new BucketDTO
      {
        Id = b.Id,
        Title = b.Title,
        Description = b.Description,
        Items = new BucketItemsDTO { Opened = b.OpenedTasks, Closed = b.ClosedTasks }
      }).ToListAsync();

      return buckets;
    }
  }
}
