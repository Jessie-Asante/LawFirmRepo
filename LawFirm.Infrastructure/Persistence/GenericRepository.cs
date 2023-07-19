using LawFirm.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawFirm.Infrastructure.Persistence
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DbLawFirmContext _context;
        public GenericRepository(DbLawFirmContext context)
        {
                _context = context;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(string query)
        {
            return await _context.Set<TEntity>().FromSqlRaw(query).ToListAsync();
        }

        public async Task<TEntity> GetById(string query)
        {
            return await _context.Set<TEntity>().FromSqlRaw(query).FirstOrDefaultAsync();
        }

        public async Task<int> AddAsync(string entity)
        {
              _context.Set<TEntity>().FromSqlRaw(entity);
             return await _context.SaveChangesAsync();
            
        }

        public async Task<int> Update(string entity)
        {
            _context.Set<TEntity>().FromSqlRaw(entity);
            return await _context.SaveChangesAsync();
             
        } 
        public async Task<bool> UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
             
        }

        public async Task<bool> DeleteAsync(string query)
        {
           
            _context.Set<TEntity>().FromSqlRaw(query);
            return await _context.SaveChangesAsync() >0;
        }

        public Task<TEntity> AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
