using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } // TODO: learn how to SQL an image
        public double Hours { get; set; }
        public int Servings { get; set; }
        public List<IngredientItem> Ingredients { get; set; }
        public List<DirectionStep> Directions { get; set; }

        public Recipe()
        {

        }
    }
}
