using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gr4WebshopIncReact.Models
{
	public class Category
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public bool isMainCateGory { get; set; }
		public List<ProductCategory> Products { get; set; }
		public List<Category> SubCategories { get; set; }

        public Category()
        {
			Products = new List<ProductCategory>();
			SubCategories = new List<Category>();
        }
	}
}

