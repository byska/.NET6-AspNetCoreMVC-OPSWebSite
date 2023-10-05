using Microsoft.EntityFrameworkCore;
using Ops.Core.Entities;
using Ops.Core.Repositories;
using Ops.Core.Services;
using Ops.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Services
{
    public class Service<T> : IService<T> where T : BaseEntity
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _uow;
        public Service(IGenericRepository<T> repository, IUnitOfWork uow)
        {
            _repository = repository;
            _uow = uow;
        }

        public async Task<bool> Activate(int id)
        {
            if (id == 0 || await _repository.GetByIdAsync(id) == null)
                return false;
            else
                return await _repository.Activate(id);
        }

        public async Task<T> AddAsync(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.CreatedBy = "admin";

            await _repository.AddAsync(entity);
            await _uow.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                entity.CreatedDate= DateTime.Now;
                entity.CreatedBy = "admin";
            }
            await _repository.AddRangeAsync(entities);
            await _uow.CommitAsync();
            return entities;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression) => await _repository.AnyAsync(expression);

        public async Task<IEnumerable<T>> GetAllAsync() => await _repository.GetAll().ToListAsync();

        public async Task<T> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public async Task RemoveAsync(T entity)
        {
           _repository.Remove(entity);
            await _uow.CommitAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
           _repository.RemoveRange(entities);
           await _uow.CommitAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            entity.ModifiedBy = "admin";
            entity.ModifiedDate = DateTime.Now;
            _repository.Update(entity);
            await _uow.CommitAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
          return _repository.Where(expression);
        }
    }
}
