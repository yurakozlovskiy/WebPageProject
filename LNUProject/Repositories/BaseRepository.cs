using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LNUProject.Entities;
using LNUProject.Repositories.Interfaces;
using System.Data.Entity;

namespace LNUProject.Repositories
{
    public class BaseRepository<T>:IRepository<T> where T:class
    {
       protected readonly LNUProjectContext Context;
       public BaseRepository(LNUProjectContext context)
       {
            Context = context;
       }

       public IEnumerable<T> GetAll()
       {
            return Context.Set<T>();
       }
       
       public void Add(T item)
       {
            Context.Set<T>().Add(item);
       }
    
       public void Update(T item)
       {
            Context.Entry(item).State = EntityState.Modified;
       }
       
       public void Remove(T item)
        {
            Context.Set<T>().Remove(item);
        }

    }
}
