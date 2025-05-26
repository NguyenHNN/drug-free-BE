using System.Linq.Expressions;

namespace Persistence.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        // Get operations
        Task<T?> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> Find(Expression<Func<T, bool>> expression);
        bool Any(Expression<Func<T, bool>> predicate);

        // Add operations
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        // Update operations
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);

        // Delete operations
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
    }
}
