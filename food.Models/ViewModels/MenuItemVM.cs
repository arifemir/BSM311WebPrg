using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace food.Models.ViewModels
{
    public class MenuItemVM
    {

        public MenuItem MenuItem { get; set; }

        public IEnumerable<SelectListItem> CategoryList { get; set; }

        public IEnumerable<SelectListItem> FoodTypeList { get; set; }
    }
}
