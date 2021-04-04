using System.Collections.Generic;

namespace Busines.Concrete
{
    public class CarManagerBase
    {
        public List<Car> GetCarsByCarName(string) => _carDal.GetAll(c => c.CarName == "");
    }
}