using LawFirm.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
            _context.Database.SetCommandTimeout(TimeSpan.FromSeconds(1200));
        }

        
        public async Task<IEnumerable<TEntity>> GetAllAsync(string query)
        {
            return await _context.Set<TEntity>().FromSqlRaw(query).ToListAsync();
        }

        public async Task<TEntity> Get(FormattableString sqlQuery)
        {
            List<TEntity> query= await _context.Set<TEntity>().FromSqlInterpolated(sqlQuery).AsNoTracking().ToListAsync();
            return query.FirstOrDefault()!;
        }
        public async Task<TEntity> GetById(string query)
        {
            var result = await _context.Set<TEntity>().FromSqlRaw(query).FirstOrDefaultAsync();
            return result;
        }

        public async Task<int> Add(FormattableString sqlQuery)
        {
            var result = _context.Database.SqlQuery<int>(sqlQuery).FirstOrDefaultAsync();
            await _context.SaveChangesAsync();
            if (result==null)
                return 0;
            return 1;                      
        }

        public async Task<int> AddAsync (string entity)
        {
            _context.Set<TEntity>().FromSqlRaw(entity);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Update(FormattableString sqlQuery)
        {
            var result = _context.Database.ExecuteSqlInterpolatedAsync(sqlQuery);
            await _context.SaveChangesAsync();
            return 1;                       
        } 
        public async Task<bool> UpdateAsync(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;            
        }

        public async Task<int> Delete(FormattableString sqlQuery)
        {
            var result = _context.Database.ExecuteSqlInterpolatedAsync(sqlQuery);
            await _context.SaveChangesAsync();
            return 1;
        }

        public async Task<bool> DeleteAsync(string query)
        {
           
            _context.Set<TEntity>().FromSqlRaw(query);
            return await _context.SaveChangesAsync() >0;
        }

    }
}
