using System;
public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public double Price { get; set; }

    public int InStock { get; set; }

    public int Sold { get; set; }

    public DateTime ModificationDate { get; set; }
}
