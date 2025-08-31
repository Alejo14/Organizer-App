using System.ComponentModel.DataAnnotations;

namespace api.Models.DTO
{
  public record BucketDTO
  {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public BucketItemsDTO Items { get; set; } = new BucketItemsDTO();
    public bool IsEditable { get; set; } = false;
  }

  public record BucketItemsDTO
  {
    public int Opened { get; set; }
    public int Closed { get; set; }
  }
}
