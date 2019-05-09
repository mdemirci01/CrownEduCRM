using System;
using System.Collections.Generic;
using System.Text;

namespace CrownEduCRM.Model
{
    public class Customer:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
