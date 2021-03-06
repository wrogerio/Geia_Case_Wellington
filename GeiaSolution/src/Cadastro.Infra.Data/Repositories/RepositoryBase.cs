using System;
using System.Collections.Generic;
using System.Linq;
using Cadastro.Domain.Interfaces.Repositories;
using Cadastro.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly GeiaContext _context;

        public RepositoryBase(GeiaContext context)
        {
            _context = context;
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public void Create(TEntity obj)
        {
            _context.Entry(obj).Property("CreatedAt").CurrentValue = DateTime.UtcNow;
            _context.Entry(obj).Property("UpdatedAt").CurrentValue = DateTime.UtcNow;
            _context.Add(obj);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
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
            _context.Entry(obj).Property("Deleted").CurrentValue = 1;
            _context.Update(obj);
            _context.SaveChanges();
        }
    }
}