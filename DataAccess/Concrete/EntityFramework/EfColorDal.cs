using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RentCarContext>, IColorDal
    {
    }
}
