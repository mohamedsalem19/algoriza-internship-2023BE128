

namespace Vezeeta.Core
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IGRepository<TEntity>? Repository<TEntity>() where TEntity : BaseEntity;

        Task<int> Complete();

    }
}
