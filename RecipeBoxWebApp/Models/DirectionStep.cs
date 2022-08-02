using System.ComponentModel.DataAnnotations;

namespace RecipeBox.Models
{
    public class DirectionStep
    {
        [Key]
        public int Id { get; set; }
        public string Direction { get; set; }

        public DirectionStep()
        {

        }
    }
}
