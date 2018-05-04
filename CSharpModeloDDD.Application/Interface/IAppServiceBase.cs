using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpModeloDDD.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        Task<IEnumerable<TEntity>> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}