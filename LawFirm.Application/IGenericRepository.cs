namespace LawFirm.Infrastructure.Persistence
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task<int> AddAsync(string entity);
        Task<bool> DeleteAsync(string query);
        Task<IEnumerable<TEntity>> GetAllAsync(string query);
        Task<TEntity> GetById(string query);
        Task<int> Update(string entity);
        Task<bool> UpdateAsync(TEntity entity);
    }
}