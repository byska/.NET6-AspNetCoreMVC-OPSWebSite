using Ops.Core.Repositories;
using Ops.Core.UnitOfWorks;
using Ops.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
           _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
           await _context.SaveChangesAsync();
        }

        IGenericRepository<T> IUnitOfWork.GetRepository<T>()
        {
            return new GenericRepository<T>(_context);
        }
    }
}
