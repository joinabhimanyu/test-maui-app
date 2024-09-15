using System;

namespace test_maui_app.Models;

public class Dimension
{
    public decimal Width { get; set; }
    public decimal Height { get; set; }
    public decimal Depth { get; set; }
}
public class Review
{
    public int Rating { get; set; }
    public string? Comment { get; set; }
    public DateTime? Date { get; set; }
    public string? ReviewerName { get; set; }
    public string? ReviewerEmail { get; set; }
}
public class Meta
{
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string? Barcode { get; set; }
    public string? QrCode { get; set; }
}
public class Product
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set;}
    public decimal Price { get; set; }
    public decimal DiscountPercentage { get; set; }
    public decimal Rating { get; set; }
    public decimal Stock { get; set; }
    public IList<string>? Tags { get; set; }
    public string? Brand { get; set; }
    public string? Sku { get; set; }
    public decimal Weight { get; set; }
    public Dimension? Dimensions { get; set; }
    public string? WarrantyInformation { get; set; }
    public string? ShippingInformation { get; set; }
    public string? AvailabilityStatus { get; set; }
    public IList<Review>? Reviews { get; set; }
    public string? ReturnPolicy { get; set; }
    public decimal MinimumOrderQuantity { get; set; }
    public Meta? Meta { get; set; }
    public string? Thumbnail { get; set; }
    public IList<string>? Images { get; set; }
}

public class ProductResponse
{
    public ICollection<Product>? Products { get; set; }
    public int Total { get; set; }
    public int Skip { get; set; }
    public int Limit { get; set; }
}