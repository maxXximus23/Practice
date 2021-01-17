using DataAccess.TestAlex;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAlex.DataAccess.Entities;

namespace TestAlex.DataAccess.Services
{
    public class CategoryService : ICRUDService<Category>
    {
        public async Task Create(Category entity)
        {
            using (var DBContext = new DatabaseContext())
            {
                DBContext.Categories.Add(entity);
                await DBContext.SaveChangesAsync(); 
            }
        }

        public async Task Delete(int id)
        {
            using (var DBContext = new DatabaseContext())
            {
                var category = await DBContext.Categories.SingleAsync(category => category.Id == id);
                DBContext.Categories.Remove(category);
                await DBContext.SaveChangesAsync(); 
            }
        }

        public async Task<Category> Get(int id)
        {
            using (var DBContext = new DatabaseContext())
            {
                return await DBContext.Categories.SingleAsync(category => category.Id == id); 
            }
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            using (var DBContext = new DatabaseContext())
            {
                return await DBContext.Categories.ToArrayAsync(); 
            }
        }

        public async Task Update(Category entity)
        {
            using (var DBContext = new DatabaseContext())
            {
                DBContext.Categories.Update(entity);
                await DBContext.SaveChangesAsync(); 
            }
        }
    }
}
