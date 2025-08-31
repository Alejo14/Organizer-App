using api.Models.DTO;

namespace api.Services.Interfaces
{
  public interface IBucketService
  {
    Task<List<BucketDTO>> GetBuckets();
  }
}
