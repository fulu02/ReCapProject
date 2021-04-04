using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color : IEntityRepository
    {
        public int ColorID { get; set; }
        public string ColorName { get; set; }
    }
}
