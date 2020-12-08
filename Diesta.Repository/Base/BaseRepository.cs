using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diesta.Repository.Base
{
    public abstract class BaseRepository<T, TId> : IBaseCrudRepository<T, TId>
         where T : class, IBaseEntity<TId>
    {
        protected BaseRepository(AerotiveDbContext dbContext)
        {
            CurrentDbcontext = dbContext;
        }

        public AerotiveDbContext CurrentDbcontext { get; }

        public ICollection<T> Find(Expression<Func<T, bool>> filter = null,
            DataPagingOptions pagingOptions = null,
            params string[] includes)
        {
            IQueryable<T> queryable = CurrentDbcontext.Set<T>();

            if (includes.Any()) includes.ToList().ForEach(i => { queryable = queryable.Include(i); });

            if (filter != null) queryable = queryable.Where(filter);

            if (pagingOptions != null && (pagingOptions.PageSize.HasValue ||
                                          pagingOptions.PageSize.GetValueOrDefault() > 0 &&
                                          pagingOptions.PageNumber.GetValueOrDefault() > 0))
                queryable = queryable
                    .Skip(pagingOptions.PageNumber.GetValueOrDefault() * pagingOptions.PageSize.GetValueOrDefault())
                    .Take(pagingOptions.PageSize.GetValueOrDefault());

            return queryable.AsNoTracking().ToList();
        }


        public T FindById(TId id, params string[] includes)
        {
            IQueryable<T> queryable = CurrentDbcontext.Set<T>();
            if (includes.Any()) includes.ToList().ForEach(i => { queryable = queryable.Include(i); });
            return queryable.AsNoTracking().FirstOrDefault(e => e.Id.Equals(id));
        }

        public T Create(T entity)
        {
            CurrentDbcontext.Set<T>().Add(entity);
            entity.CreatedAt = ZonedDateTime.FromDateTimeOffset(DateTimeOffset.Now);
            CurrentDbcontext.SaveChanges();
            return entity;
        }

        public virtual T Update(T entity, params string[] excludingFields)
        {
            CurrentDbcontext.Set<T>().Update(entity);
            entity.UpdatedAt = ZonedDateTime.FromDateTimeOffset(DateTimeOffset.Now);
            excludingFields.AsParallel().ForAll(t => CurrentDbcontext.Entry(entity).Property(t).IsModified = false);
            CurrentDbcontext.Entry(entity).Property(p => p.CreatedAt).IsModified = false;
            CurrentDbcontext.SaveChanges();
            return entity;
        }

        public void UpdateStatusById(TId id, bool status)
        {
            var entity = FindById(id);
            entity.IsActive = status;
            entity.UpdatedAt = ZonedDateTime.FromDateTimeOffset(DateTimeOffset.Now);
            CurrentDbcontext.Set<T>().Update(entity);
            CurrentDbcontext.SaveChanges();
        }

        public void BatchUpdateStatusById(IEnumerable<T> entities, bool status)
        {
            Parallel.ForEach(entities, e =>
            {
                e.IsActive = status;
                e.UpdatedAt = ZonedDateTime.FromDateTimeOffset(DateTimeOffset.Now);
            });
            CurrentDbcontext.Set<T>().UpdateRange(entities);
            CurrentDbcontext.SaveChanges();
        }

        public void Delete(T entity)
        {
            CurrentDbcontext.Set<T>().Remove(entity);
            entity.DeletedAt = ZonedDateTime.FromDateTimeOffset(DateTimeOffset.Now);
            CurrentDbcontext.SaveChanges();
        }

        public void DeleteById(TId id)
        {
            CurrentDbcontext.Set<T>().Remove(FindById(id));
            CurrentDbcontext.SaveChanges();
        }

        public void SoftDelete(TId id)
        {
            var item = FindById(id);
            item.IsDeleted = true;
            item.DeletedAt = ZonedDateTime.FromDateTimeOffset(DateTimeOffset.Now);
            CurrentDbcontext.Set<T>().Update(item);
            CurrentDbcontext.SaveChanges();
        }

        public void BatchDelete(IEnumerable<T> entities)
        {
            if (entities == null) return;
            CurrentDbcontext.Set<T>().RemoveRange(entities);
            CurrentDbcontext.SaveChanges();
        }

        public void BatchSoftDelete(IEnumerable<T> entities)
        {
            if (entities == null) return;
            Parallel.ForEach(entities, t => t.IsDeleted = true);
            CurrentDbcontext.Set<T>().UpdateRange(entities);
            CurrentDbcontext.SaveChanges();
        }

        public bool Exist(TId id)
        {
            return CurrentDbcontext.Set<T>().Any(e => e.Id.Equals(id) && !e.IsDeleted);
        }

        public bool Exist(Expression<Func<T, bool>> predicate)
        {
            return CurrentDbcontext.Set<T>().Where(entity => !entity.IsDeleted).Any(predicate);
        }

        public int GetTotalRecordCount()
        {
            return CurrentDbcontext.Set<T>().Count(entity => !entity.IsDeleted);
        }

        public void Dispose()
        {
            CurrentDbcontext.Dispose();
        }
    }
}
