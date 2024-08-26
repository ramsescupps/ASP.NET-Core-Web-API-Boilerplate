namespace ECommerceAPI.Models
{
  public class Customer
  {
    public int CustomerId { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public string Address { get; set; } = string.Empty;
    public bool IsDeleted { get; set; }
  }
}