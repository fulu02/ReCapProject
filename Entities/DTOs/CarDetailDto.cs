using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
   public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public short DailyPrice { get; set; }
    }
}
// CarName, BrandName, ColorName, DailyPrice. (İpucu: IDto oluşturup 3 tabloya join yazınız)
