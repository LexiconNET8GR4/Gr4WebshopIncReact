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
            if (products == null) return null;
            foreach (var product in products)
            {
                ProductDTO productDTO = new ProductDTO(product);
                productDTOs.Add(productDTO);

            }
            products = PrepareForJson(products);
            return Json(productDTOs);
        }

        // GET api/<ProductController>/5
        [Route("getproduct")]
        public ActionResult GetProduct(string id)
        {
            var idGuid = Guid.Parse(id);
            Product product = _productServices.GetById(idGuid);
            if (product == null) return BadRequest();
            product = PrepareForJson(product);
            return Json(product);
        }

        [HttpPost]
        [Route("createproduct")]
        public ActionResult CreateProduct(
            [Required] string Name,
            string Description,
            string CoverImageDestination,
            [FromQuery] List<ImageDestination> ImagesDestination,
            string Type,
            [FromQuery] Details Details,
            [FromQuery] List<ProductCategory> Categories,
            double Price,
            double SaleAmount,
            double SalePercentage,
            double Storage,
            DateTime DateStocked,
            string Brand
            )
        {
            ProductDTO productDTO;
            Product product = _productServices.CreateProduct(Name);
            if (Description != null) product.Description = Description;
            if (CoverImageDestination != null) product.CoverImageDestination = CoverImageDestination;
            if (ImagesDestination != null) product.ImagesDestination = ImagesDestination;
            if (Details != null) product.Details.Data = Details.Data;
            if (Price != 0) product.Price = Price;
            if (SaleAmount != 0) product.SaleAmount = SaleAmount;
            if (SalePercentage != 0) product.SalePercentage = SalePercentage;
            if (Storage != 0) product.Storage = (int)Storage;
            if (DateStocked != null) product.DateStocked = DateStocked;
            if (Brand != null) product.Brand = Brand;
            _productServices.Update(product);
            if (product.Details != null)
            {
                productDTO = new ProductDTO(product);
            }
            else 
            { 
                productDTO = new ProductDTO(); 
            }

            return Json(productDTO);
        }

        [HttpPost]
        [Route("editproduct")]
        public ActionResult EditProduct(
            [Required] string id,
            string Name,
            string Description,
            string CoverImageDestination,
            [FromQuery] List<ImageDestination> ImagesDestination,
            string Type,
            [FromQuery] Details Details,
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
            productToModify.Details.Data = Details.Data;
            productToModify.Price = Price;
            productToModify.SaleAmount = SaleAmount;
            productToModify.SalePercentage = SalePercentage;
            productToModify.Storage = (int)Storage;
            productToModify.DateStocked = DateStocked;
            productToModify.Brand = Brand;
            Product product = _productServices.Update(productToModify);
            DetailsDTO detailsDTO = new DetailsDTO(Details);
            productToModify.Details = detailsDTO;
            List<ImageDestinationDTO> imageDestinationDTOs = new List<ImageDestinationDTO>();
            product = PrepareForJson(product);
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

        private Product PrepareForJson (Product product)
        {
            foreach (ImageDestination imageDestination in product.ImagesDestination)
            {
                imageDestination.ProductKey = Guid.Empty;
                imageDestination.Product = null;

            }
            if(product.Categories!=null)foreach(ProductCategory category in product.Categories)
            {
                category.ProductKey = Guid.Empty;
                category.Product = null;
            }
            if (product.Details != null) 
            {
                product.Details.ProductKey = Guid.Empty;
                product.Details.Product = null;
            }
            return product;
        }
        private List<Product> PrepareForJson(List<Product> products)
        {
            foreach (Product product in products)
            {
                foreach (ImageDestination imageDestination in product.ImagesDestination)
                {
                    imageDestination.ProductKey = Guid.Empty;
                    imageDestination.Product = null;

                }
                if (product.Categories != null) foreach (ProductCategory category in product.Categories)
                    {
                        category.ProductKey = Guid.Empty;
                        category.Product = null;
                    }
                if (product.Details != null)
                {
                    product.Details.ProductKey = Guid.Empty;
                    product.Details.Product = null;
                }
            }
            return products;
        }


    }
}
