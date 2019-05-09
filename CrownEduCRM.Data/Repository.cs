using CrownEduCRM.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CrownEduCRM.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext db;
        private readonly DbSet<T> entities;
        public Repository(ApplicationDbContext context)
        {
            this.db = context;
            this.entities = context.Set<T>();
        }
        public void Delete(T entity)
        {
            entities.Remove(entity);
        }

        public T Get(string id)
        {
            return entities.FirstOrDefault(e => e.Id == id);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return entities.FirstOrDefault(where);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> where)
        {
            return entities.Where(where).ToList();
        }

        public void Insert(T entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.CreatedBy = "username";
            entity.UpdatedAt = DateTime.Now;
            entity.UpdatedBy = "username";
            entities.Add(entity);
        }

        public void Update(T entity)
        {
            entity.UpdatedAt = DateTime.Now;
            entity.UpdatedBy = "username";
            entities.Update(entity);
        }
    }
}
