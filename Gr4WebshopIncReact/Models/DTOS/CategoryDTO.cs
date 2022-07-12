using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Models.DTOS
{
    public class CategoryDTO
    {
		public Guid Id { get; set; }
		public Guid ParentId { get; set; }
		public string Name { get; set; }
		public bool isMainCateGory { get; set; }
		public List<Guid> SubCategories { get; set; }
        public CategoryDTO(Category category)
        {
			Id = category.Id;
			Name = category.Name;
			isMainCateGory = category.isMainCateGory;
			SubCategories = new List<Guid>();
			if(category.SubCategories!=null&&category.SubCategories.Count>0)
				foreach(SubCategory c in category.SubCategories)
                {
					SubCategories.Add(c.SubKey);
                }
        }
	}
}
