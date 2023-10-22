using Ops.Core.Intefaces;
using Ops.Core.Result.Abstract;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Core.Services
{
    public interface IService<TEntity,TRequest,TResponse> where TEntity : IEntity where TRequest:class where TResponse : class
    {
        Task<IAppResult<TResponse>> GetByIdAsync(int id);
        Task<IAppResult<IEnumerable<TResponse>>> GetAllAsync();
        Task<IAppResult<IEnumerable<TResponse>>> GetAllActiveAsync();
        Task<IAppResult<IEnumerable<TResponse>>> GetAllByIncludeParametersAsync(Expression<Func<TEntity, object>> include, params Expression<Func<TEntity, bool>>[] exps);
        Task<IAppResult<IEnumerable<TResponse>>> Where(Expression<Func<TEntity, bool>> expression);
        Task<IAppResult<NoContentVM>> Activate(int id);
        Task<IAppResult<bool>> AnyAsync(Expression<Func<TEntity, bool>> expression);
        Task<IAppResult<TResponse>> AddAsync(TRequest request);
        Task<IAppResult<IEnumerable<TResponse>>> AddRangeAsync(IEnumerable<TRequest> requests);
        Task<IAppResult<NoContentVM>> UpdateAsync(TRequest request);
        Task<IAppResult<NoContentVM>> RemoveAsync(int id);
        Task<IAppResult<NoContentVM>> RemoveRangeAsync(IEnumerable<int> ids);
    }
}
