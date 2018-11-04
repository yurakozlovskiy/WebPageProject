using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;
using LNUProject.Repositories.Interfaces;

namespace LNUProject.Repositories
{
    public class CategoryRepository: BaseRepository<Category>,ICategoryRepository
    {
        public CategoryRepository(LNUProjectContext context) : base(context) { }

        public Category Get(int id)
        {
            return Context.Categories.FirstOrDefault(r => r.Id == id);
        }

        public Category TryGetByName(string name)
        {
            return Context.Categories.FirstOrDefault(r => r.Name == name);
        }
    }
}
