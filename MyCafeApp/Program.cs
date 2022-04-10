// See https://aka.ms/new-console-template for more information
using MyCafeApp;
using MyCafeDAL.Concrete.EF;
using MyCafeDAL.Entities;

//Console.WriteLine("Hello, World!!!");
//SayHello();
var p1 = new ImageConsole();
var a = p1.imageConversion("/Users/muhammedbayindir/desktop/Deneme.png");

//try
//{
//    var pro = new Product() { Id = 2, Price = 25.99, ProductName = "Deneme1", ProductImage = a };

//    var Dal = new ProductDal();

//    Dal.Add(pro);
//    Console.WriteLine("Hello");
//}
//catch (Exception ex)
//{
//    throw new Exception(ex.InnerException.Message);
//}

var b = new MyCafeDbContext();
var gelen = b.Products.ToList();
foreach (var item in gelen)
{
    Console.WriteLine(item.ProductName);
}




