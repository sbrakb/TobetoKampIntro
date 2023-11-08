

using OOP1;

Product product1 = new()
{
    Id = 1,
    CategoryId = 2,
    ProductName = "Fred",
    UnitPrice = 10000000,
    UnitInStock = 3
};

Product product2 = new Product();
product2.Id = 2;
product2.CategoryId = 5;
product2.ProductName = "Cengiz";
product2.UnitInStock = 5;
product2.UnitPrice = 15000000;

ProductManager productManager = new();
productManager.Add(product1);
Console.WriteLine(product1.ProductName);
productManager.Update(product1);
Console.WriteLine(product1.ProductName);



int sayi = 50;
Console.WriteLine(productManager.Test(sayi));
Console.WriteLine(sayi);
