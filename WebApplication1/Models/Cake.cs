namespace WebApplication1.Models
{
    public class Cake
    {
        public int CakeId { get; set; }
        public int CategoryId { get; set; }
        public string CakeName { get; set; }
        public string CakeMainIngredient { get; set; }
        public string CakeDescription { get; set; }
        public bool isHidden { get; set; }

        public virtual Category Category { get; set; }
    }
}