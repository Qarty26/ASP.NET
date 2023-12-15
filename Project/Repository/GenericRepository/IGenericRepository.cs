﻿using Roads.Models.Base;

namespace Roads.Repository.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        //get all
        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();

        //create
        void Create(TEntity entity);
        Task CreateAsync(TEntity entity);
        void CreateRange(IEnumerable<TEntity> entitites);
        Task CreateRangeAsync(IEnumerable<TEntity> entitites);

        //update
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entitites);

        //delete

        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entitites);

        //find

        TEntity FindById(Guid id);
        Task<TEntity> FindByIdAsync(Guid id);

        //save

        bool Save();
        Task<bool> SaveAsync();

    }
}
