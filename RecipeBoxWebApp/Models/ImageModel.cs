// https://www.youtube.com/watch?v=QpJvqiHl1Fo

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeBoxWebApp.Models
{
    public class ImageModel
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string ImageName { get; set; }
    }
}
