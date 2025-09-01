using api.Models.DTO;

namespace api.Services.Interfaces
{
  public interface IBucketService
  {
    Task<IEnumerable<BucketReadDTO>> GetBuckets();
    Task<BucketReadDTO?> GetBucket(int id);
    Task<BucketReadDTO> CreateBucket(BucketCreateDTO bucketDTO);
    Task<bool> UpdateBucket(int id, BucketUpdateDTO bucketDTO);
    Task<bool> DeleteBucket(int id);
  }
}
