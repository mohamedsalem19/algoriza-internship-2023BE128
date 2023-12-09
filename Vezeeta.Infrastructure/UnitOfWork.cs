



namespace Vezeeta.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VezeetaContext _dbcontext;

        private Hashtable _repositories;

        public UnitOfWork(VezeetaContext dbcontext)
        {
            _dbcontext = dbcontext;

        }

        public IGRepository<TEntity>? Repository<TEntity>() where TEntity : BaseEntity
        {
            if (_repositories is null)
                _repositories = new Hashtable();

            var type = typeof(TEntity).Name;
            if (!_repositories.ContainsKey(type))
            {
                var repository = new GenericRepository<TEntity>(_dbcontext);

                _repositories.Add(type, repository);
            }

            return _repositories[type] as IGRepository<TEntity>;
        }

        public async Task<int> Complete()
             => await _dbcontext.SaveChangesAsync();

        public async ValueTask DisposeAsync()
             => await _dbcontext.DisposeAsync();



    }
}
