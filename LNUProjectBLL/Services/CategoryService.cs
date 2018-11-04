using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProjectBLL.Interfaces;
using LNUProjectDTO;
using LNUProject.UnitOfWork;

namespace LNUProjectBLL.Services
{
    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(IUnitOfWork db) : base(db)
        {
        }

        public CategoryDTO Get(int id)
        {
            var category = db.Categories.Get(id);
            if (category == null)
                return null;
            else
                return new CategoryDTO(category.Id,
                                       category.Name);
        }

        public List<CategoryDTO> GetAllCategories()
        {
            var categories = db.Categories.GetAll();
            if (categories == null)
                return null;
            var dtos = new List<CategoryDTO>();
            foreach (var category in categories)
                dtos.Add(new CategoryDTO(category.Id,
                                         category.Name));
            return dtos;
        }

        public CategoryDTO GetByName(string name)
        {
            var category = db.Categories.TryGetByName(name);
            if (category == null)
                return null;
            else
                return new CategoryDTO(category.Id, category.Name);
        }
    }
}
