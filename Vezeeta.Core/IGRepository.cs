

namespace Vezeeta.Core
{
    public interface IGRepository<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}


