using System.ComponentModel.DataAnnotations;

namespace launchPad.Models
{
    public class Link {

        // ------------------------------------------------------ get/set methods
        [Key]
        public int linkID {get;set;}
        [Required]
        [MaxLength(40)]
        [Display(Name="Category Name")]
        public string category {get;set;}
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
    }
}