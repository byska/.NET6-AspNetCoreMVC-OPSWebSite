using Ops.Core.Intefaces;
using Ops.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
        IGenericRepository<T> GetRepository<T>() where T : class, IEntity;
    }
}
