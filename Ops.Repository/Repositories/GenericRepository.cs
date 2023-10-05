﻿using Microsoft.EntityFrameworkCore;
using Ops.Core.Intefaces;
using Ops.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Ops.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<bool> Activate(int id)
        {
            T item = await GetByIdAsync(id);
            item.IsActive = true;
            return Update(item);
        }

        public async Task<bool> AddAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> AddRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    foreach (T entity in entities)
                    {
                        await _dbSet.AddRangeAsync(entities);
                    }
                    scope.Complete();
                    return true;
                }

            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression) => await _dbSet.AnyAsync(expression);


        public IQueryable<T> GetAll() =>  _dbSet.AsNoTracking().AsQueryable();


        public async Task<T> GetByIdAsync(int id) => await _dbSet.FindAsync(id);

        public bool Remove(T entity)
        {
            try
            {
                entity.IsActive = false;
                entity.Status = Core.Enums.Status.Deleted;
                return Update(entity);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool RemoveRange(IEnumerable<T> entities)
        {
            try
            {
                using(TransactionScope scope= new TransactionScope())
                {
                    foreach(T entity in entities)
                    {
                        entity.IsActive = false;
                        entity.Status = Core.Enums.Status.Deleted;
                        Update(entity);
                    }
                    scope.Complete();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                entity.Status = Core.Enums.Status.Modified;
                _dbSet.Update(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);    
        }
    }
}
