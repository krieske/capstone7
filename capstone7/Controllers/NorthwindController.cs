using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using capstone7.Models;

namespace capstone7.Controllers
{
    public class NorthwindController : ApiController
    {
        [HttpGet]
        public List<Products> GetAllProducts()
        {
            // URL: http://localhost:54659/api/Northwind/GetAllProducts

            // create ORM
            northwindEntities ORM = new northwindEntities();


            // get all products from ORM
            List<Products> prod = ORM.Products.ToList();


            // return all products
            return prod;
        }

        [HttpGet]
        public List<Products> GetProductID(int prodID)
        {
            // URL: http://localhost:54659/api/Northwind/GetProductID?prodID={prodID}

            // create ORM
            northwindEntities ORM = new northwindEntities();


            // get and return products with productID
            return ORM.Products.Where(x => x.ProductID.ToString() == prodID.ToString()).ToList();  
        }


        //[HttpGet]
        //public List<Products> GetProductNull()
        //{
        //    // URL:


        //    // create ORM
        //    northwindEntities ORM = new northwindEntities();


        //    // search for productID, does not exist



        //    // return productID NULL value

        //}

        //[HttpGet]
        //public List<Products> GetProdcutCategory()
        //{
        //    // URL:


        //    // create ORM
        //    northwindEntities ORM = new northwindEntities();



        //}




    }
}