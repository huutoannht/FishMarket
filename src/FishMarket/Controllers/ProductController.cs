using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FishMarket.Entities;
using FishMarket.Interfaces;
using FishMarket.BLO;
using AutoMapper;

namespace FishMarket.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductDataService _productDataService;
        private readonly IMapper _mapper;
        public ProductController(IProductDataService productDataService, IMapper mapper)
        {
            _productDataService = productDataService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ProductBusinessService productBusinessService = new ProductBusinessService(_productDataService, _mapper);
            TransactionalInformation transaction;
            List<Product> listProduct = productBusinessService.GetProducts(0,0,"","", out transaction);
            return View(listProduct);
        }
      

        public IActionResult ListProduct()
        {
    
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
