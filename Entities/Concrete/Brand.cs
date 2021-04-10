using Core.DataAccess;

namespace Entities.Concrete
{
    public class Brand : IEntityRepository
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
    }
}
