using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Warehouse.Webapp.Models;
using Warehouse.Application.Entity;
using Warehouse.Application.Interfaces;

namespace Warehouse.Webapp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //Connectie van View Controller naar Application Interfaces


        public IActionResult Index()
        {
            return View();
        }


        // Methode voegt product toe, neemt de waardes over uit ViewModel, en maakt instantie van de klasse.
        public async Task<IActionResult> AddProduct(ProductViewModel product) 
        {
            Product newProduct = new Product()
            {
                ProductID = Guid.NewGuid(),
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
            };
            
            return Ok(await _productRepository.AddProduct(newProduct));   
        }
    }
}
