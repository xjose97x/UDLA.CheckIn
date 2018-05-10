using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace UDLA.Checkin.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class 
    {
        protected readonly ApplicationDbContext context;
        protected readonly DbSet<TEntity> entities;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            entities.Add(entity);
            context.SaveChanges();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            this.entities.AddRange(entities);
            context.SaveChanges();
        }


        public void Update(TEntity entity)
        {
            entities.Update(entity);
            context.SaveChanges();
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            this.entities.UpdateRange(entities);
            context.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            entities.Remove(entity);
            context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            this.entities.RemoveRange(entities);
            context.SaveChanges();
        }

        public int Count()
        {
            return entities.Count();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return entities.Where(predicate);
        }

        public TEntity GetSingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return entities.SingleOrDefault(predicate);
        }

        public TEntity Get(int id)
        {
            return entities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return entities.ToList();
        }
    }
}
