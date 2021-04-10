namespace Busines.Abstract
{
    public class Car
    {
        public string Description { get; set; }
        public object DailyPrice { get; internal set; }
        public object CarName { get; internal set; }
    }
}