using System;

namespace test_maui_app.Models;

public class Dimension
{
    public decimal width { get; set; }
    public decimal height { get; set; }
    public decimal depth { get; set; }
}
public class Review
{
    public int rating { get; set; }
    public string? comment { get; set; }
    public DateTime? date { get; set; }
    public string? reviewerName { get; set; }
    public string? reviewerEmail { get; set; }
}
public class Meta
{
    public DateTime? createdAt { get; set; }
    public DateTime? updatedAt { get; set; }
    public string? barcode { get; set; }
    public string? qrCode { get; set; }
}
public class Product
{
    public int id { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
    public string? category { get; set;}
    public decimal price { get; set; }
    public decimal discountPercentage { get; set; }
    public decimal rating { get; set; }
    public decimal stock { get; set; }
    public IList<string>? tags { get; set; }
    public string? brand { get; set; }
    public string? sku { get; set; }
    public decimal weight { get; set; }
    public Dimension? dimensions { get; set; }
    public string? warrantyInformation { get; set; }
    public string? shippingInformation { get; set; }
    public string? availabilityStatus { get; set; }
    public IList<Review>? reviews { get; set; }
    public string? returnPolicy { get; set; }
    public decimal minimumOrderQuantity { get; set; }
    public Meta? meta { get; set; }
    public string? thumbnail { get; set; }
    public IList<string>? images { get; set; }
}

public class ProductResponse
{
    public ICollection<Product>? products { get; set; }
    public int total { get; set; }
    public int skip { get; set; }
    public int limit { get; set; }
}