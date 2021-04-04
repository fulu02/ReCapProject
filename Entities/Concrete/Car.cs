using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand:IEntityRepository
    {
        public Brand(int carID, int brandID, int brandId, string carName, int colorID, int modelYear, int dailyPrice, string description, object brandName)
        {
            CarID = carID;
            BrandID = brandID;
            BrandId = brandId;
            CarName = carName;
            ColorID = colorID;
            ModelYear = modelYear;
            DailyPrice = dailyPrice;
            Description = description;
            BrandName = brandName;
        }

        public int CarID { get; set; }
        public int BrandID { get; set; }
        public int BrandId { get; set; }
        public string CarName { get; set; }

        public int ColorID { get; set; }
        public int ModelYear { get; set; }

        public int DailyPrice { get; set; }
        public string Description { get; set; }
        public object BrandName { get; set; }
    }
}
