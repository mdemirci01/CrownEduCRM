using System;
using System.Collections.Generic;
using System.Text;

namespace CrownEduCRM.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext db;
        public UnitOfWork(ApplicationDbContext context)
        {
            this.db = context;
        }
        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
