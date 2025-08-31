using api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BucketController(IBucketService _bucketService) : ControllerBase
  {
    private readonly IBucketService _service = _bucketService;

    [HttpGet]
    public async Task<ActionResult> Get()
    {
      var result = await _service.GetBuckets();
      return Ok(result);
    }
  }
}
