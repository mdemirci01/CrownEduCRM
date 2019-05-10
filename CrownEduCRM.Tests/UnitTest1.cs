using CrownEduCRM.Data;
using CrownEduCRM.Model;
using CrownEduCRM.Service;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        private ApplicationDbContext db;
        private IRepository<Customer> customerRepository;
        private IUnitOfWork unitOfWork;
        private ICustomerService customerService;
        // testimiz baþlarken ilk yapýlacak iþlemler için
        [SetUp]
        public void Setup()
        {
            var connectionstring = "Server=.;Database=CrownEduCRM;User Id=sa;Password=Wissen2018;MultipleActiveResultSets=true";

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(connectionstring);
            this.db = new ApplicationDbContext(optionsBuilder.Options);
            this.customerRepository = new Repository<Customer>(this.db);
            this.unitOfWork = new UnitOfWork(this.db);
            this.customerService = new CustomerService(customerRepository, unitOfWork);
        }

        // içinde yazýlan testi yapan metot
        [Test]
        public void Test1()
        {
            var result = customerService.GetAll().ToList();
            Assert.IsTrue(result.Count() > 10, "Yeterli kayýt yok!");            
        }

        // testler bittikten sonra çýkýþta çalýþan metot
        [TearDown]
        public void TearDown()
        {

        }
    }
}