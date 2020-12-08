using Diesta.Model.Parameter;
using Diesta.Repository.Interface;
using Diesta.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Diesta.Service.Base
{
    public abstract class BaseCrudService<T, TId> : IBaseCrudService<T, TId>, IDisposable
    {
        protected readonly IBaseCrudRepository<T, TId> repository;

        protected BaseCrudService(IBaseCrudRepository<T, TId> repository)
        {
            this.repository = repository;
        }

        public ICollection<T> Find(
            Expression<Func<T, bool>> filter = null,
            DataPagingOptions pagingOptions = null,
            params string[] includes)
        {
            return repository.Find(filter, pagingOptions, includes);
        }

        public T FindById(TId id, params string[] includes)
        {
            return repository.FindById(id, includes);
        }

        public virtual T Create(T entity)
        {
            return repository.Create(entity);
        }

        public virtual T Update(T entity)
        {
            return repository.Update(entity);
        }

        public virtual void UpdateStatusById(TId id, bool status)
        {
            repository.UpdateStatusById(id, status);
        }

        public virtual void Delete(T entity)
        {
            repository.Delete(entity);
        }

        public virtual void DeleteById(TId id)
        {
            repository.DeleteById(id);
        }

        public virtual void SoftDelete(TId id)
        {
            repository.SoftDelete(id);
        }

        public void BatchDelete(IEnumerable<T> entities)
        {
            repository.BatchDelete(entities);
        }

        public bool Exist(TId id)
        {
            return repository.Exist(id);
        }

        public bool Exist(Expression<Func<T, bool>> expression)
        {
            return repository.Exist(expression);
        }

        public int GetTotalRecordCount()
        {
            return repository.GetTotalRecordCount();
        }

        public void Dispose()
        {
            repository.Dispose();
        }

        public virtual void BatchUpdateStatusById(IEnumerable<T> entities, bool status)
        {
            repository.BatchUpdateStatusById(entities, status);
        }
    }

}
