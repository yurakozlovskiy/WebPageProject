using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;

namespace LNUProject.Repositories.Interfaces
{
    public interface ICategoryRepository: IRepository<Category>
    {
        Category Get(int id);
        Category TryGetByName(string name);
    }
}
