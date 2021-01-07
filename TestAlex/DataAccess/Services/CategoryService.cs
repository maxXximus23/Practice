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
        private readonly DatabaseContext _databaseContext;
        public CategoryService()
        {
            _databaseContext = new DatabaseContext();
        }
        public async Task Create(Category entity)
        {
            _databaseContext.Categories.Add(entity);
            await _databaseContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var category = await _databaseContext.Categories.SingleAsync(category => category.Id == id);
            _databaseContext.Categories.Remove(category);
            await _databaseContext.SaveChangesAsync();
        }

        public async Task<Category> Get(int id)
        {
            return await _databaseContext.Categories.SingleAsync(category => category.Id == id);
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
           return await _databaseContext.Categories.ToArrayAsync();
        }

        public async Task Update(Category entity)
        {
           _databaseContext.Categories.Update(entity);
           await _databaseContext.SaveChangesAsync();
        }
    }
}
