using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Customer : IEntityRepository
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
