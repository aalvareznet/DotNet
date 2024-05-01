using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FishesApi.Models
{
    public class Fish
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FishId { get; set; }
        public string FishName { get; set; }
        public string FishDescription { get; set; }
        public int FishWeight { get; set; }
        public int FishLength { get; set; }
        public string FishColor { get; set; }
        public string PlaceOfCapture { get; set; }
        public int FishCategoryId { get; set; }
        [ForeignKey("FishCategoryId")]
        public virtual FishCategory FishCategory { get; set; }
    }
}
