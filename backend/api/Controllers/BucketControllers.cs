using api.Models.DTO;
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
    public async Task<ActionResult> GetBuckets()
    {
      try
      {
        var bucketReadDTOList = await _service.GetBuckets();
        return Ok(bucketReadDTOList);
      }
      catch (Exception ex)
      {
        return BadRequest(ex);
      }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetBucket([FromRoute] int id)
    {
      try
      {
        var bucketReadDTO = await _service.GetBucket(id);
        if (bucketReadDTO == null) return NotFound($"Bucket not found for id {id}");
        return Ok(bucketReadDTO);
      }
      catch (Exception ex)
      {
        return BadRequest(ex);
      }
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] BucketCreateDTO bucketCreateDTO)
    {
      try
      {
        var bucketReadDTO = await _service.CreateBucket(bucketCreateDTO);
        return CreatedAtAction(nameof(GetBucket), new { id = bucketReadDTO.Id }, bucketReadDTO);
      }
      catch (Exception ex)
      {
        return BadRequest(ex);
      }
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Put([FromRoute] int id, [FromBody] BucketUpdateDTO bucketUpdateDTO)
    {
      try
      {
        var updated = await _service.UpdateBucket(id, bucketUpdateDTO);
        if (!updated) return NotFound($"Bucket not found for id {id}");
        return NoContent();
      }
      catch (Exception ex)
      {
        return BadRequest(ex);
      }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete([FromRoute] int id)
    {
      try
      {
        var deleted = await _service.DeleteBucket(id);
        if (!deleted) return NotFound($"Bucket not found for id {id}");
        return NoContent();
      }
      catch (Exception ex)
      {
        return BadRequest(ex);
      }
    }
  }
}
