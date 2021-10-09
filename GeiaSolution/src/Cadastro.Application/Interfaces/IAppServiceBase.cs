using System.Collections.Generic;

namespace Cadastro.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Create(TEntity obj);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Update(TEntity obj);

        void Remove(TEntity obj);
    }
}
