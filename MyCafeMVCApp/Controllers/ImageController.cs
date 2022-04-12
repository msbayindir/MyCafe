using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCafeApp;
using MyCafeBusinessLayer.EFCore.Concrete;

using MyCafeDAL.Concrete.EF;
using MyCafeDAL.Entities;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyCafeMVCApp.Controllers
{


    public class ImageController : Controller
    {


        public async Task<ActionResult> ImageSef()
        {


           // var Image1 = new ByteToImage();
            
            var b1 = new ProductDal();
            
            //var gelen = b1.GetSingle(b=>b.Id==3);
            var Liste = b1.GetAll();
            
            
            //var imgDataURL = Image1.ByteConversion(gelen.ProductImage);

            


            //Passing image data in viewbag to view  
            //ViewBag.ImageData = imgDataURL;
            return View(Liste);

            //<img src="@ViewBag.ImageData" width="500" height="500">  

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


       
    }
}

