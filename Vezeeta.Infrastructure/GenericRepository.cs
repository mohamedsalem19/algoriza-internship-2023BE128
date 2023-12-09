



namespace Vezeeta.Infrastructure
{
    public class GenericRepository<T> : IGRepository<T> where T : BaseEntity
    {
        private readonly VezeetaContext _dbContext;

        public GenericRepository(VezeetaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(T entity)
         => await _dbContext.Set<T>().AddAsync(entity);

        public void Delete(T entity)

             => _dbContext.Set<T>().Remove(entity);


        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)

             => await _dbContext.Set<T>().FindAsync(id);


        public void Update(T entity)

           => _dbContext.Set<T>().Update(entity);

    }

}

