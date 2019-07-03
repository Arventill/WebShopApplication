using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Name of the category is required!")]
        [StringLength(100)]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Description is required!")]
        public string CategoryDescription { get; set; }
        public string IconFileName { get; set; }

        public virtual ICollection<Cake> Cakes { get; set; }
    }
}