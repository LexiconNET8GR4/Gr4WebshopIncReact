using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Gr4WebshopIncReact.Services;
using Gr4WebshopIncReact.Models;
using System.Text.Json;
using Gr4WebshopIncReact.Models.DTOS;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gr4WebshopIncReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;
        private readonly IImageDestinationServices _imageDestinationServices;
        private readonly ICategoryServices _categoryServices;

        public ProductController(IProductServices productServices,IImageDestinationServices imageDestinationServices,ICategoryServices categoryServices)
        {
            _productServices = productServices;
            _imageDestinationServices = imageDestinationServices;
            _categoryServices = categoryServices;
        }
        // GET: api/<ProductController>
        [HttpGet]
        [Route("getallproducts")]
        public ActionResult GetAllProducts()
        {
            List<Product> products;
            products = _productServices.GetAll();
            if (products == null) return null;
            return Json(PrepareForJson(products));
        }

        // GET api/<ProductController>/5
        [Route("getproduct")]
        public ActionResult GetProduct(string id)
        {
            Guid idGuid;
            if(!Guid.TryParse(id,out idGuid))return BadRequest();
            Product product = _productServices.GetById(idGuid);
            if (product == null) return BadRequest();
            
            return Json(PrepareForJson(product));
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [Route("createproduct")]
        public ActionResult CreateProduct(
            [Required] string Name,
            string Description,
            string CoverImageDestination,
            string ImagesDestination,
            string Details,
            string Categories,
            double Price,
            double SaleAmount,
            double SalePercentage,
            double Stock,
            DateTime DateStocked,
            string Brand
            )
        {
            Product product = _productServices.CreateProduct(Name);
            if (Description != null) product.Description = Description;
            if (CoverImageDestination != null) product.CoverImageDestination = CoverImageDestination;
            
            List<string> imageDes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(ImagesDestination);
            if (imageDes != null&& imageDes.Count>0) {
                foreach(string i in imageDes)
                {
                    _imageDestinationServices.AddImageDestination(product, i);
                }
            }
            
            if (Details != null) product.Details.Data = Details;
            if (Price != 0) product.Price = Price;
            if (SaleAmount != 0) product.SaleAmount = SaleAmount;
            if (SalePercentage != 0) product.SalePercentage = SalePercentage;
            if (Stock != 0) product.Stock = Stock;
            if (DateStocked != null) product.DateStocked = DateStocked;
            if (Brand != null) product.Brand = Brand;
            
            List<Guid> cats = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Categories);
            if (cats != null && cats.Count > 0) {
                product.Categories = new List<ProductCategory>();
                foreach(Guid id in cats)
                {
                    ProductCategory productCategory = new ProductCategory()
                    {
                        ProductKey = product.Id,
                        CategoryKey = id
                    };
                    product.Categories.Add(productCategory);
                }
            } 
            _productServices.Update(product);
           

            return Json(PrepareForJson(product));
        }

        [HttpPost]
        [Route("editproduct")]
        [Authorize(Roles = "Admin")]
        public ActionResult EditProduct(
            [Required] string id,
            string Name,
            string Description,
            string CoverImageDestination,
            string ImagesDestination,
            string Details,
            string Categories,
            double Price,
            double SaleAmount,
            double SalePercentage,
            double Stock,
            DateTime DateStocked,
            string Brand
            )
        {
            Guid guidId = Guid.Parse(id);
            
            Product productToModify = _productServices.GetById(guidId);
            if (productToModify == null) return BadRequest();
            if(Name!=null)productToModify.Name = Name;
            productToModify.Description = Description;
            productToModify.CoverImageDestination = CoverImageDestination;
            productToModify.Details.Data = Details;
            productToModify.Price = Price;
            productToModify.SaleAmount = SaleAmount;
            productToModify.SalePercentage = SalePercentage;
            productToModify.Stock = Stock;
            productToModify.DateStocked = DateStocked;
            productToModify.Brand = Brand;
            productToModify.Categories = new List<ProductCategory>();

            List<Guid> cats = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(Categories);
            if (cats != null && cats.Count > 0)
            {
                foreach (Guid catid in cats)
                {
                    ProductCategory productCategory = new ProductCategory()
                    {
                        ProductKey = productToModify.Id,
                        CategoryKey = catid
                    };
                    productToModify.Categories.Add(productCategory);
                }
            }
            productToModify.ImagesDestination = new List<ImageDestination>();
            List<string> imageDes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(ImagesDestination);
            if (imageDes != null && imageDes.Count > 0)
            {
                foreach(string imdes in imageDes)
                {
                    var imagedes=_imageDestinationServices.AddImageDestination(productToModify, imdes);
                    productToModify.ImagesDestination.Add(imagedes);
                }
                
            }


            Product product = _productServices.Update(productToModify);
            
            return Json(PrepareForJson(product));
        }

        [Route("deleteproduct")]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteProduct(Guid id)
        {
            if (_productServices.Delete(id)) 
                return StatusCode(200);
            else return BadRequest();
        }

        [Route("findproduct")]

        public ActionResult FindProduct(string searchPhrase)
        {
            List<Product> productsByName = _productServices.FindByName(searchPhrase);
            List<Product> productsByBrand = _productServices.FindByBrand(searchPhrase);
            List<Product> productsByDescription = _productServices.FindByDescription(searchPhrase);
            List<Product> productsByDetails = _productServices.FindByDetails(searchPhrase);
            List<Product> products=productsByName;
            if(productsByBrand!=null) foreach(Product p in productsByBrand)
            {
                if (!products.Contains(p)) products.Add(p);
            }
            if (productsByDescription != null) foreach (Product p in productsByDescription)
            {
                if (!products.Contains(p)) products.Add(p);
            }
            if (productsByDetails != null) foreach (Product p in productsByDetails)
            {
                if (!products.Contains(p)) products.Add(p);
            }
            if (products == null || products.Count == 0) return Json("");
            return Json(PrepareForJson(products));
        }

        [Route("getproductsbycategory")]
        public ActionResult GetProductsByCategory(Guid CategoryId)
        {
            List<Product> products = _productServices.FindByCategory(CategoryId);
            return Json(PrepareForJson(products));
        }

        private ProductDTO PrepareForJson (Product product)
        {
            ProductDTO productDTO = new ProductDTO(product);
            return productDTO;
        }
        private List<ProductDTO> PrepareForJson(List<Product> products)
        {
            List<ProductDTO> productDTOs = new List<ProductDTO>();
            foreach(Product p in products)
            {
                productDTOs.Add(new ProductDTO(p));

            }
            return productDTOs;
        }


    }
}
