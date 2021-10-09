using System;
using System.Collections.Generic;
using System.Linq;
using Cadastro.Domain.Interfaces.Repositories;
using Cadastro.Infra.Data.Context;

namespace Cadastro.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly GeiaContext _context;

        public RepositoryBase(GeiaContext context)
        {
            _context = context;
        }

        public void Create(TEntity obj)
        {
            _context.Entry(obj).Property("CreatedAt").CurrentValue = DateTime.UtcNow;
            _context.Add(obj);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).Property("UpdatedAt").CurrentValue = DateTime.UtcNow;
            _context.Update(obj);
            _context.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            _context.Entry(obj).Property("Deleted").CurrentValue = true;
            _context.Update(obj);
            _context.SaveChanges();
        }
    }
}