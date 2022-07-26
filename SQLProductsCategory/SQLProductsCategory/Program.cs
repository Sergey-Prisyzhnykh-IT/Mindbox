// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using SQLProductsCategory;

using (ApplicationContext db = new ApplicationContext())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    Products bread = new Products { Name = "Хлеб" };
    Products potato = new Products { Name = "картошка" };
    Products feri = new Products { Name = "Feri" };
    db.Products.AddRange(bread, potato, feri);

    Category products = new Category { Name = "Продукты" };
    Category chemistry = new Category { Name = "Химия" };
    db.Category.AddRange(products, chemistry);

    bread.Category.Add(products);
    potato.Category.Add(products);
    feri.Category.Add(chemistry);
    db.SaveChanges();
}
 
using (ApplicationContext db = new ApplicationContext())
{
    var shop = db.Category.Include(x => x.Products).ToList();

    foreach (var s in shop)
    {
        Console.WriteLine($"Категория - {s.Name}");
        foreach (var p in s.Products) 
        {
            Console.WriteLine($"Название - {p.Name}");
        }
    }
}
Console.ReadLine();
