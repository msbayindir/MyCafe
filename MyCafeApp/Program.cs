// See https://aka.ms/new-console-template for more information

using MyCafeBusinessLayer.EFCore.Concrete;
using MyCafeBusinessLayer.ImageConverter;

using MyCafeDAL.Entities;

//Console.WriteLine("Hello, World!!!");
//SayHello();

var x = new ImageToByte();
var a = x.ImageConversion("//Users//muhammedbayindir//desktop//Deneme2.jpg");
try
{
    var pro = new Product() { Id = 3, Price = 25, ProductName = "Deneme2", ProductImage = a };

    var Dal = new ProductDal();

    Dal.Add(pro);
    Console.WriteLine("Hello");
}
catch (Exception ex)
{
    throw new Exception(ex.InnerException.Message);
}






