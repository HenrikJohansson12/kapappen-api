public class StoreInventoryDTO
{
    public long Id { get; set; }
    public int StoreId { get; set; }
    public int ProductId { get; set; }
    public int Length { get; set; }
    public string? StoreName { get; set; }
    public string? GoogleMapsId { get; set; }
}