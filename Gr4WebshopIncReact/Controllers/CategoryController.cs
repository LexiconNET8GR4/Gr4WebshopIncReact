using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Services;
using Gr4WebshopIncReact.Models;
using Gr4WebshopIncReact.Models.DTOS;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;

namespace Gr4WebshopIncReact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _categoryServices;
        private readonly IProductServices _productServices;

        public CategoryController(ICategoryServices categoryServices,IProductServices productServices)
        {
            _categoryServices = categoryServices;
            _productServices = productServices;
        }
        /// <summary>
        /// Get all categories in the database
        /// </summary>
        /// <returns>
        /// JSON of all categories
        /// </returns>
        [Route("getallcategories")]
        public ActionResult GetAllCategories()
        {
            List<Category> categories = _categoryServices.GetAll();
            return Json(PrepareForJSON(categories));
        }


        /// <summary>
        /// Get subcategories for a given category id
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>List of Guid for the subcategories</returns>
        [Route("getsubcategories")]
        public ActionResult GetSubCategories(Guid categoryId)
        {
            Category category = _categoryServices.FindById(categoryId);
            if (category == null) return BadRequest();
            CategoryDTO categoryDTO = new CategoryDTO(category);
            categoryDTO = PrepareForJSON(category);
            return Json(categoryDTO.SubCategories);
        }


        /// <summary>
        /// Get a category with the given id
        /// </summary>
        /// <param name="id">
        /// Category id
        /// </param>
        /// <returns>
        /// if successful: JSON of the given category<br></br>
        /// If failed: HTTP 400 Bad Request
        /// </returns>
        [Route("getcategory")]
        public ActionResult GetCategory([Required]Guid id)
        {
            Category category = _categoryServices.FindById(id);
            if (category == null) return BadRequest();
            return Json(PrepareForJSON(category));
        }


        /// <summary>
        /// Add a subcategory to a parent category
        /// </summary>
        /// <param name="parentId">Parent id</param>
        /// <param name="subcatId">Subcategory id</param>
        /// <returns>
        /// If successful: JSON for the parent category<br></br>
        /// If failed: HTTP 400 Bad Request
        /// </returns>
        [Route("addsubcategory")]
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult AddSubcategory([Required]Guid parentId, [Required]Guid subcatId)
        {
            Category category = _categoryServices.FindById(parentId);
            Category subcat = _categoryServices.FindById(subcatId);
            if (category == null || subcat == null) return BadRequest();
            if(!category.SubCategories.Contains(subcat)) category.SubCategories.Add(subcat);
            category = _categoryServices.Update(category);
            return Json(PrepareForJSON(category));
        }


        /// <summary>
        /// Create a new category
        /// </summary>
        /// <param name="ParentId">Optional parent category id</param>
        /// <param name="Name">Required</param>
        /// <param name="isMainCateGory"></param>
        /// <param name="SubCategories"></param>
        /// <returns>
        /// If successful: JSON for created category<br></br>
        /// If failed: HTTP 400 Bad Request
        /// </returns>
        [Route("createcategory")]
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult CreateCategory(
            Guid ParentId, 
            [Required]string Name, 
            bool isMainCateGory, 
            string SubCategories)
        {
            Category category = new Category() {
                Id=Guid.NewGuid(),
                Name=Name,
                isMainCateGory=isMainCateGory
            };
            var subCategoryList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(SubCategories);
            if (subCategoryList != null && subCategoryList.Count > 0)
            {
                foreach(Guid guid in subCategoryList) {
                    Category subCategory = _categoryServices.FindById(guid);
                    category.SubCategories.Add(subCategory);
                }
                
            }
            if (_categoryServices.CreateCategory(category) != null) { return Json(PrepareForJSON(category)); }
            else return BadRequest();
            
        }


        /// <summary>
        /// Edit a category<br></br>
        /// Optional values not set will be set to null or 0
        /// </summary>
        /// <param name="Id">Required</param>
        /// <param name="Name">Optional</param>
        /// <param name="isMainCateGory">Optional</param>
        /// <param name="SubCategories">Optional</param>
        /// <returns>
        /// If successful: JSON for the category<br></br>
        /// If failed: HTTP 400 Bad Request
        /// </returns>
        [Route("editcategory")]
        [Authorize(Roles = "Admin")]

        public ActionResult EditCategory([Required] Guid Id, 
                                            string Name, 
                                            bool isMainCateGory, 
                                            string SubCategories)
        {
            // Check for valid Category-to-Edit Id
            if (Id.ToString() == "")
                return BadRequest();

            if (_categoryServices.FindById(Id) == null)
                return BadRequest();

            // Recieve list of category IDs and find their corresponding categories
            List<Guid> recievedCategoryIds = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Guid>>(SubCategories);
            List<Category> subCategoryList = new List<Category>(); 
            foreach (Guid id in recievedCategoryIds)
            {
                subCategoryList.Add(_categoryServices.FindById(id));
            }

            // Update the category in question
            Category category = _categoryServices.FindById(Id);
            if (category == null) return BadRequest();
            category.Name = Name;
            category.isMainCateGory = isMainCateGory;
            category.SubCategories = subCategoryList;
            Category returnCat = _categoryServices.Update(category);
            if (returnCat == null) return BadRequest();
            return Json(PrepareForJSON(returnCat));
        }

        [Route("removecategory")]
        [Authorize(Roles = "Admin")]
        public ActionResult RemoveCategory([Required] Guid Id)
        {
            if (_categoryServices.Delete(Id)) return StatusCode(200);
            else return BadRequest();
        }

        private CategoryDTO PrepareForJSON(Category c)
        {
            CategoryDTO categoryDTO = new CategoryDTO(c);
            return categoryDTO;
        }

        private List<CategoryDTO> PrepareForJSON(List<Category> categories)
        {
            List<CategoryDTO> categoryDTOs = new List<CategoryDTO>();
            foreach(Category c in categories)
            {
                categoryDTOs.Add(PrepareForJSON(c));
            }
            return categoryDTOs;
        }


    }
}
