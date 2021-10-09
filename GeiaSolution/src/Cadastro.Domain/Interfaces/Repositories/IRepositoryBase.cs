using System;
using System.Collections.Generic;

namespace Cadastro.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Create(TEntity obj);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(Guid id);

        void Update(TEntity obj);

        void Remove(TEntity obj);
    }
}