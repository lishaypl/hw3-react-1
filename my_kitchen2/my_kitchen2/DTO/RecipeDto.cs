using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace my_kitchen2.DTO
{
    public class RecipeDto
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string CookingMethod { get; set; }
        public string Time { get; set; }
        public List<int> IngredientIds { get; set; }
    }

}