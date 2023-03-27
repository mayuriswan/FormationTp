using DAL.Data;
using Formation.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryDb
{
    public class RestaurantRepository : IRepository<Restaurant>
    {
        private readonly RestaurantDbContext _context;
        private readonly DbSet<Restaurant> _dbSet;

        public RestaurantRepository(RestaurantDbContext context)
        {
            _context = context;
            _dbSet = context.Set<Restaurant>();
        }

        public async Task<Restaurant> GetByIdAsync(string id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<Restaurant>> GetAllAsync()
        {
            return await _dbSet.Include(r => r.Cuisines).ToListAsync();

        }

        public async Task<IEnumerable<Restaurant>> FindAsync(Expression<Func<Restaurant, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task AddAsync(Restaurant entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(Restaurant entity)
        {
            _dbSet.Update(entity);
        }

        public void Remove(Restaurant entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<int> CountAsync(Expression<Func<Restaurant, bool>> predicate)
        {
            return await _dbSet.CountAsync(predicate);
        }

        public async Task<bool> AnyAsync(Expression<Func<Restaurant, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }


}
