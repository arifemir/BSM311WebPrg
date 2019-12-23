using System.ComponentModel.DataAnnotations;

namespace food.Models
{
    public class FoodType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Food Type Name")]
        public string Name { get; set; }
    }
}
