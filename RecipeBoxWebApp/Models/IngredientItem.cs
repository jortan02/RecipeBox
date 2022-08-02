using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
    public class IngredientItem
    {
        [Key]
        public int Id { get; set; }
        public string Ingredient { get; set; }

        public IngredientItem()
        {

        }
    }
}

