// See https://aka.ms/new-console-template for more information
using MyCafeApp;

//Console.WriteLine("Hello, World!!!");
//SayHello();
var p1 = new ImageConsole();
var a =p1.imageConversion("/Users/muhammedbayindir/desktop/Deneme.png");

foreach (var item in a)
{
    Console.WriteLine(item);
}



static void SayHello()
{
    Console.WriteLine("Hello!!");
    
}





