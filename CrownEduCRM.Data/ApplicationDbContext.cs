using Microsoft.EntityFrameworkCore;
using System;

namespace CrownEduCRM.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options) { }
    }
}
