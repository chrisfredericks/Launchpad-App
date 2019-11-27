using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace launchPad.Models
{
    public class Link {

        // ------------------------------------------------------ get/set methods
        [Key]
        public int Id {get;set;}
        [Required]
        [MaxLength(100)]
        [Display(Name="Link Name")]
        public string label {get;set;}
        [Required]
        [Url]
        [MaxLength(100)]
        [Display(Name="Link Address")]
        public string href {get;set;}
        public string pinned {get;set;}
        [ForeignKey("Category")]
        public int categoryId {get;set;}
    }
}