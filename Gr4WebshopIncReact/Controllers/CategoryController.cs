using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gr4WebshopIncReact.Services;
using Gr4WebshopIncReact.Models;
using Gr4WebshopIncReact.Models.DTOS;

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

        [Route("getallcategories")]
        public ActionResult GetAllCategories()
        {
            List<Category> categories = _categoryServices.GetAll();
            return Json(PrepareForJSON(categories));
        }

        [Route("getsubcategories")]
        public ActionResult GetSubCategories(Guid categoryId)
        {
            Category category = _categoryServices.FindById(categoryId);
            if (category == null) return BadRequest();
            CategoryDTO categoryDTO = new CategoryDTO(category);
            categoryDTO = PrepareForJSON(category);
            return Json(categoryDTO.SubCategories);
        }

        [Route("getcategory")]
        public ActionResult GetCategory(Guid id)
        {
            Category category = _categoryServices.FindById(id);
            return Json(PrepareForJSON(category));
        }

        [Route("createcategory")]
        public ActionResult CreateCategory(Guid ParentId, string Name, bool isMainCateGory, List<Guid> SubCategories)
        {
            Category category = new Category() {
                Id=Guid.NewGuid(),
                Name=Name,
                isMainCateGory=isMainCateGory
            };
            if (SubCategories != null && SubCategories.Count > 0)
            {
                foreach(Guid guid in SubCategories) {
                    SubCategory subCategory = new SubCategory();
                    subCategory.MainKey = category.Id;
                    subCategory.SubKey = guid;
                    category.SubCategories.Add(subCategory);
                }
                
            }
            if (_categoryServices.CreateCategory(category) != null) { return Json(PrepareForJSON(category)); }
            else return BadRequest();
            
        }

        [Route("editcategory")]

    public ActionResult EditCategory(Guid Id,Guid ParentId, string Name, bool isMainCateGory, List<Guid> SubCategories)
        {
            Category category = _categoryServices.FindById(Id);
            if (category == null) return BadRequest();
            category.Name = Name;
            category.isMainCateGory = isMainCateGory;
            List<SubCategory> subCategories = new List<SubCategory>();
            if (SubCategories != null && SubCategories.Count > 0)
            {
                foreach (Guid id in SubCategories)
                {
                    SubCategory subCategory = new SubCategory()
                    {
                        MainKey = category.Id,
                        SubKey = id
                    };
                    subCategories.Add(subCategory);
                }
                category.SubCategories = subCategories;
            }
            Category returnCat = _categoryServices.Update(category);
            return Json(PrepareForJSON(returnCat));


        }

        private CategoryDTO PrepareForJSON(Category c)
        {
            CategoryDTO categoryDTO = new CategoryDTO(c);
            var subCats = _categoryServices.FindSubCategories(c);
            if (subCats != null && subCats.Count > 0) foreach (Category cat in subCats)
                {
                    categoryDTO.SubCategories.Add(cat.Id);
                }
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
