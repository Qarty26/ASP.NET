using Lab3_2.Data;
using Lab3_2.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Lab3_2.Repository.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly Lab4Context _lab4context;
        protected readonly DbSet<TEntity> _table;

        public GenericRepository(Lab4Context lab4context)
        {
            _lab4context = lab4context;
            _table = _lab4context.Set<TEntity>();
        }

        //get all
        public List<TEntity> GetAll()
        {
            return  _table.AsNoTracking().ToList();
        }
        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _table.AsNoTracking().ToListAsync();
        }

               
       //do not use in repo, in repo only data not queries
        //public IQueryable<TEntity> GetAllAsQueryable() 
        //{
            //return _table.AsNoTracking();

            //var entityList = _table.ToList();
            //var entityListFiltered =_table.Where(x => entityList.Contains(x));

           // or better: 

           // var entityListQuery = _table.AsQueryable();
          //  var entityListQueryFiltered = entityListQuery.Where(x => entityListQuery.Contains(x));
        //    var result = entityListQueryFiltered.ToList();
        //}

        public void Create(TEntity entity)
        {
            _table.Add(entity);
        }
        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            _table.AddRange(entities);
        }
        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }

        //update

        public void Update(TEntity entity)
        {
            _table.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _table.UpdateRange(entities);
        }

        //delete

        public void Delete(TEntity entity) 
        {
            _table.Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }

        //find

        public TEntity FindById(Guid id)
        {
            return _table.Find(id);
        }

        public async Task<TEntity> FindByIdAsync(Guid id)
        {
            return await _table.FindAsync(id);
        }


        //save
        public bool Save()
        {
            return _lab4context.SaveChanges() > 0;
        }
        public async Task<bool> SaveAsync()
        {
            return await _lab4context.SaveChangesAsync() > 0;
        }
    }
}
