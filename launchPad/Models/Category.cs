using System.ComponentModel.DataAnnotations;

namespace launchPad.Models
{
    public class Category {

        // ------------------------------------------------------ get/set methods
        [Key]
        public int Id {get;set;}
        [Required]
        [MaxLength(40)]
        [Display(Name="Category Name")]
        public string category {get;set;}
        
    }
}