using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Gr4WebshopIncReact.Services;
using Gr4WebshopIncReact.Models;
using System.Text.Json;
using Gr4WebshopIncReact.Models.DTOS;
using System.ComponentModel.DataAnnotations;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gr4WebshopIncReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        // GET: api/<ProductController>
        [HttpGet]
        [Route("getallproducts")]
        public ActionResult GetAllProducts()
        {
            List<Product> products;
            List<ProductDTO> productDTOs = new List<ProductDTO>();
            products = _productServices.GetAll();
            foreach (var product in products)
            {
                ProductDTO productDTO = new ProductDTO(product);
                productDTOs.Add(productDTO);
            }
            return Json(productDTOs);
        }

        // GET api/<ProductController>/5
        [Route("getproduct")]
        public ActionResult GetProduct(string id)
        {
            var idGuid = Guid.Parse(id);
            Product product = _productServices.GetById(idGuid);
            ProductDTO productDTO = new ProductDTO(product);
            return Json(productDTO);
        }

        [HttpPost]
        [Route("createproduct")]
        public ActionResult CreateProduct(
            [Required] string Name,
            string Description,
            string CoverImageDestination,
            [FromQuery] List<ImageDesitination> ImagesDestination,
            string Type,
            string Details,
            double Price,
            double CurrentPrice,
            double SaleAmount,
            double SalePercentage,
            double Storage,
            DateTime DateStocked,
            string Brand
            )
        {
            Product product = _productServices.CreateProduct(Name);
            if (Description != null) product.Description = Description;
            if (CoverImageDestination != null) product.CoverImageDestination = CoverImageDestination;
            if (ImagesDestination != null) product.ImagesDestination = ImagesDestination;
            if (Details != null) product.Details.Data = Details;
            if (Price != 0) product.Price = Price;
            if (CurrentPrice != 0) product.CurrentPrice = CurrentPrice;
            if (SaleAmount != 0) product.SaleAmount = SaleAmount;
            if (SalePercentage != 0) product.SalePercentage = SalePercentage;
            if (Storage != 0) product.Storage = (int)Storage;
            if (DateStocked != null) product.DateStocked = DateStocked;
            if (Brand != null) product.Brand = Brand;
            return Json(product);
        }

        [HttpPost]
        [Route("editproduct")]
        public ActionResult EditProduct(
            [Required] string id,
            string Name,
            string Description,
            string CoverImageDestination,
            [FromQuery] List<ImageDesitination> ImagesDestination,
            string Type,
            string Details,
            double Price,
            double CurrentPrice,
            double SaleAmount,
            double SalePercentage,
            double Storage,
            DateTime DateStocked,
            string Brand
            )
        {
            Guid guidId = Guid.Parse(id);
            Product productToModify = _productServices.GetById(guidId);
            if(Name!=null)productToModify.Name = Name;
            productToModify.Description = Description;
            productToModify.CoverImageDestination = CoverImageDestination;
            productToModify.ImagesDestination = ImagesDestination;
            productToModify.Details.Data = Details;
            productToModify.Price = Price;
            productToModify.CurrentPrice = CurrentPrice;
            productToModify.SaleAmount = SaleAmount;
            productToModify.SalePercentage = SalePercentage;
            productToModify.Storage = (int)Storage;
            productToModify.DateStocked = DateStocked;
            productToModify.Brand = Brand;
            Product product = _productServices.Update(productToModify);
            return Json(product);
        }

        [Route("deleteproduct")]
        public ActionResult DeleteProduct(string id)
        {
            Guid guidId = Guid.Parse(id);
            if (_productServices.Delete(guidId)) 
                return StatusCode(200);
            else return BadRequest();
        }

        
    }
}
