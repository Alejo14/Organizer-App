using api.Data;
using api.Models.Entities;
using api.Models.DTO;
using api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api.Services.Implementations
{
  public class BucketService(ToDoAppDBContext _dbContext) : IBucketService
  {
    private readonly ToDoAppDBContext _db = _dbContext;

    public async Task<IEnumerable<BucketReadDTO>> GetBuckets()
    {
      var bucketReadDTOList = await _db.Buckets
        .AsNoTracking()
        .Select(b => new BucketReadDTO
          {
            Id = b.Id,
            Title = b.Title,
            Description = b.Description,
            Items = new BucketItemsDTO { Opened = b.OpenedTasks, Closed = b.ClosedTasks }
          })
        .ToListAsync();
      return bucketReadDTOList;
    }

    public async Task<BucketReadDTO?> GetBucket(int id)
    {
      var bucket = await _db.Buckets.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
      if (bucket == null) return null;
      var bucketReadDTO = new BucketReadDTO
        {
          Id = bucket.Id,
          Title = bucket.Title,
          Description = bucket.Description,
          Items = new BucketItemsDTO { Opened = bucket.OpenedTasks, Closed = bucket.ClosedTasks }
        };
      return bucketReadDTO;
    }

    public async Task<BucketReadDTO> CreateBucket(BucketCreateDTO bucketCreateDTO)
    {
      var bucket = new Bucket
        {
          Title = bucketCreateDTO.Title,
          Description = bucketCreateDTO.Description,
          OpenedTasks = bucketCreateDTO.Items.Opened,
          ClosedTasks = bucketCreateDTO.Items.Closed
        };
      _db.Buckets.Add(bucket);
      await _db.SaveChangesAsync();
      var bucketReadDTO = new BucketReadDTO
        {
          Id = bucket.Id,
          Title = bucket.Title,
          Description = bucket.Description,
          Items = new BucketItemsDTO { Opened = bucket.OpenedTasks, Closed = bucket.ClosedTasks }
        };
      return bucketReadDTO;
    }

    public async Task<bool> UpdateBucket(int id, BucketUpdateDTO bucketUpdateDTO)
    {
      var bucket = await _db.Buckets.FindAsync(id);
      if (bucket == null) return false;
      bucket.Title = bucketUpdateDTO.Title;
      bucket.Description = bucketUpdateDTO.Description;
      bucket.OpenedTasks = bucketUpdateDTO.Items.Opened;
      bucket.ClosedTasks = bucketUpdateDTO.Items.Closed;
      await _db.SaveChangesAsync();
      return true;
    }

    public async Task<bool> DeleteBucket(int id)
    {
      var bucket = await _db.Buckets.FindAsync(id);
      if (bucket == null) return false;
      _db.Buckets.Remove(bucket);
      await _db.SaveChangesAsync();
      return true;
    }
  }
}
