using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Ops.Core.Entities;
using Ops.Core.Repositories;
using Ops.Core.Result.Abstract;
using Ops.Core.Result.Concrete;
using Ops.Core.Services;
using Ops.Core.UnitOfWorks;
using Ops.Core.VMs;
using Ops.Service.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ops.Service.Services
{
    public class Service<TEntity, TRequest, TResponse> : IService<TEntity,TRequest,TResponse> where TEntity : BaseEntity where TRequest : class where TResponse : class
    {
        protected readonly IUnitOfWork _uow;
        protected readonly IMapper _mapper;
        public Service( IUnitOfWork uow,IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IAppResult<NoContentVM>> Activate(int id)
        {
            var entity = await _uow.GetRepository<TEntity>().GetByIdAsync(id);
           var result=await _uow.GetRepository<TEntity>().Activate(id);
            if (!result)
                return AppResult<NoContentVM>.Fail(StatusCodes.Status404NotFound, $"No data was found with {id} id.");

            return AppResult<NoContentVM>.Success(StatusCodes.Status200OK);
        }

        public async Task<IAppResult<TResponse>> AddAsync(TRequest request)
        {
            var newEntity = _mapper.Map<TEntity>(request);
            await _uow.GetRepository<TEntity>().AddAsync(newEntity);
            await _uow.CommitAsync();

            var newResponse = _mapper.Map<TResponse>(newEntity);
            return AppResult<TResponse>.Success(StatusCodes.Status200OK,newResponse);
        }

        public async Task<IAppResult<IEnumerable<TResponse>>> AddRangeAsync(IEnumerable<TRequest> requests)
        {
            var newEntities = _mapper.Map<IEnumerable<TEntity>>(requests);
            await _uow.GetRepository<TEntity>().AddRangeAsync(newEntities);
            await _uow.CommitAsync();

            var newResponses = _mapper.Map<IEnumerable<TResponse>>(newEntities);
            return AppResult< IEnumerable<TResponse>>.Success(StatusCodes.Status200OK, newResponses);
        }

        public async Task<IAppResult<bool>> AnyAsync(Expression<Func<TEntity, bool>> expression)
        {
            var anyEntity = await _uow.GetRepository<TEntity>().AnyAsync(expression);

            return AppResult<bool>.Success(StatusCodes.Status200OK,anyEntity);

        }

        public async Task<IAppResult<IEnumerable<TResponse>>> GetAllActiveAsync()
        {
            var entities = await _uow.GetRepository<TEntity>().GetAllActive().ToListAsync();
            var responseEntities = _mapper.Map<IEnumerable<TResponse>>(entities);

            return AppResult<IEnumerable<TResponse>>.Success(StatusCodes.Status200OK, responseEntities);
        }

        public async Task<IAppResult<IEnumerable<TResponse>>> GetAllAsync()
        {
            var entities = await _uow.GetRepository<TEntity>().GetAll().ToListAsync();
            var responseEntities = _mapper.Map<IEnumerable<TResponse>>(entities);

            return AppResult<IEnumerable<TResponse>>.Success(StatusCodes.Status200OK, responseEntities);
        }

        public async Task<IAppResult<TResponse>> GetByIdAsync(int id)
        {
           var entity = await _uow.GetRepository<TEntity>().GetByIdAsync(id);
            if (entity == null)
                throw new NotFoundException($"{typeof(TEntity).Name}({id}) does not exist");

           var response = _mapper.Map<TResponse>(entity);

           return AppResult<TResponse>.Success(StatusCodes.Status200OK, response);
        }

        public async Task<IAppResult<NoContentVM>> RemoveAsync(int id)
        {
            var entity = await _uow.GetRepository<TEntity>().GetByIdAsync(id);
             _uow.GetRepository<TEntity>().Remove(entity);
            await _uow.CommitAsync();
            return AppResult<NoContentVM>.Success(StatusCodes.Status204NoContent);

        }

        public async Task<IAppResult<NoContentVM>> RemoveRangeAsync(IEnumerable<int> ids)
        {
            var entities = await _uow.GetRepository<TEntity>().Where(x=>ids.Contains(x.Id)).ToListAsync();
            _uow.GetRepository<TEntity>().RemoveRange(entities);
            await _uow.CommitAsync();
            return AppResult<NoContentVM>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<IAppResult<NoContentVM>> UpdateAsync(TRequest request)
        {
            var entity = _mapper.Map<TEntity>(request);
            _uow.GetRepository<TEntity>().Update(entity);
            await _uow.CommitAsync();

            return AppResult<NoContentVM>.Success(StatusCodes.Status204NoContent);
        }

        public async Task<IAppResult<IEnumerable<TResponse>>> Where(Expression<Func<TEntity, bool>> expression)
        {
            var entities = await _uow.GetRepository<TEntity>().Where(expression).ToListAsync();
            var responses= _mapper.Map<IEnumerable<TResponse>>(entities);

            return AppResult<IEnumerable<TResponse>>.Success(StatusCodes.Status200OK, responses);
        }
    }
}
