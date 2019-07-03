namespace WebApplication1.Models
{
    public class OrderPosition
    {
        public int OrderPositionId { get; set; }
        public int OrderId { get; set; }
        public int CakeId { get; set; }
        public int Quantity { get; set; }

        public virtual Cake Cake { get; set; }
        public virtual Order Order { get; set; }
    }
}