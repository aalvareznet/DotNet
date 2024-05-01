using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FishesApi.Models
{
    public class FishCategory
    {
            
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FishCategoryId { get; set; }
        public string FishCategoryName { get; set; }
    }
}
