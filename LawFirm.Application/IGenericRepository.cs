namespace LawFirm.Infrastructure.Persistence
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<int> Add(FormattableString sqlQuery);
        Task<int> AddAsync(string entity);
        Task<int> Delete(FormattableString sqlQuery);
        Task<bool> DeleteAsync(string query);
        Task<TEntity> Get(FormattableString sqlQuery);
        Task<IEnumerable<TEntity>> GetAllAsync(string query);
        Task<TEntity> GetById(string query);
        Task<int> Update(FormattableString sqlQuery);
        Task<bool> UpdateAsync(TEntity entity);
    }
}