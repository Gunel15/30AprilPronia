using _30AprilClassTaskPronia.Models;
using System.ComponentModel.DataAnnotations;

namespace _30AprilClassTaskPronia.ViewModels.categories
{
    public class CategoryUpdateVM
    {
        public int Id { get; set; }
        [MinLength(3), MaxLength(64)]
        public string Name { get; set; }
        public IEnumerable<Product>? Products { get; set; }
    }
}
