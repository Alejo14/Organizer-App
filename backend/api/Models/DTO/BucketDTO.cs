namespace api.Models.DTO
{
  public record BucketItemsDTO
  {
    public int Opened { get; set; }
    public int Closed { get; set; }
  }

  public record BucketReadDTO
  {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public BucketItemsDTO Items { get; set; } = new BucketItemsDTO();
    public bool IsEditable { get; set; } = false;
  }

  public record BucketCreateDTO
  {
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public BucketItemsDTO Items { get; set; } = new BucketItemsDTO();
  }

  public record BucketUpdateDTO
  {
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public BucketItemsDTO Items { get; set; } = new BucketItemsDTO();
  }
}
