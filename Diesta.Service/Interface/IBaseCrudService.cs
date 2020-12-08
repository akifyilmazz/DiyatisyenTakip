using Diesta.Model.Parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Diesta.Service.Interface
{
    public interface IBaseCrudService<T, TIdType>
    {
        ICollection<T> Find(Expression<Func<T, bool>> filter = null,
            DataPagingOptions dataPagingOptions = null,
            params string[] includes);
        T FindById(TIdType id, params string[] includes);

        T Create(T entity);

        T Update(T entity);

        void UpdateStatusById(TIdType id, bool status);

        void Delete(T entity);

        void DeleteById(TIdType id);

        void SoftDelete(TIdType id);
        void BatchDelete(IEnumerable<T> entities);
        bool Exist(TIdType id);
        bool Exist(Expression<Func<T, bool>> expression);

        int GetTotalRecordCount();
    }
}
