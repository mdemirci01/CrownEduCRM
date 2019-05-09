using System;
using System.Collections.Generic;
using System.Text;

namespace CrownEduCRM.Data
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}
