using Core.DataAccess;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand : IEntityRepository
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }
}
