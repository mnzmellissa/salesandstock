using System.Xml.Linq;

namespace SalesAndStock;

public class ReportHelper
{
    public void PrintProductsInStock()
    {
        var filePath = Path.GetFullPath("Sales_Stock.xml");
        var document = XDocument.Load(filePath);
        var products = document.Descendants("Product");
        var distinctProducts = products.GroupBy(x => x.Attribute("id")?.Value).Select(group => group.MaxBy(x => x.Element("ModificationDate")?.Value));
        const int nameColumnSize = -30;

        Console.WriteLine($"\n{"Name",nameColumnSize}Quantity");

        foreach (var product in distinctProducts)
        {
            if (product ==  null) 
                continue;

            string name = product.Element("Name")?.Value ?? "";
            int stockQuantity =
                int.Parse(product.Element("SalesInformation")?.Element("InStockQuantity")?.Value ?? "0");

            Console.WriteLine($"{name,nameColumnSize}{stockQuantity}");
        }
    }
}