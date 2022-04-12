// See https://aka.ms/new-console-template for more information

using MyCafeBusinessLayer.EFCore.Concrete;


using MyCafeDAL.Entities;

Console.WriteLine("Hello, World!!!");
//SayHello();
var p1 = new Product();
var a =p1.ImageToByte("//Users//muhammedbayindir//desktop//Deneme3.png");
    
//var x = new ImageToByte();


//var y = new ProductDal();
//var Liste = y.GetAll();

//foreach (var item in Liste)
//{
//    Console.WriteLine(item);
//}

try
{
    var pro = new Product() { Id = 4, Price = 27, ProductName = "Deneme3", ProductImage = a };

    var Dal = new ProductDal();

    Dal.Add(pro);
    Console.WriteLine("Hello");
}
catch (Exception ex)
{
    throw new Exception(ex.InnerException.Message);
}






