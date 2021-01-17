using DataAccess.TestAlex;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestAlex.DataAccess.Entities;

namespace TestAlex.DataAccess.Services
{
    public class GameService : ICRUDService<Game>
    {
        public async Task Create(Game entity)
        {
            using (var DBContext = new DatabaseContext())
            {
                DBContext.Games.Add(entity);
                await DBContext.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            using (var DBContext = new DatabaseContext())
            {
                var game = await DBContext.Games.SingleAsync(game => game.Id == id);
                DBContext.Games.Remove(game);
                await DBContext.SaveChangesAsync();
            }
        }

        public async Task<Game> Get(int id)
        {
            using (var DBContext = new DatabaseContext())
            {
                return await DBContext.Games.SingleAsync(game => game.Id == id);
            }
        }

        public async Task<IEnumerable<Game>> GetAll()
        {
            using (var DBContext = new DatabaseContext())
            {
                return await DBContext.Games.ToArrayAsync();
            }
        }

        public async Task Update(Game entity)
        {
            using (var DBContext = new DatabaseContext())
            {
                DBContext.Games.Update(entity);
                await DBContext.SaveChangesAsync();
            }
        }
    }
}
