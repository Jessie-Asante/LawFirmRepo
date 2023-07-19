namespace LawFirm.Infrastructure.Persistence
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetById(int id);
        Task<bool> UpdateAsync(TEntity entity);
    }
}