using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Models {

    [Table("Categories")]
    public class Category {

        [Key]
        public int CategoryID { get; set; }

        /* ----- */

        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "The name must be informed")]
        [StringLength(100, ErrorMessage = "The name must not exceed {1} characters")]
        public string CategoryName { get; set; }

        /* ----- */

        [Display(Name = "Description")]
        [Required(ErrorMessage = "The description must be informed")]
        [StringLength(100, ErrorMessage = "Description must not exceed {1} characters")]
        public string CategoryDescription { get; set; }

        /* ----- */

        public List<Hamburger> Hamburgers { get; set; }

    }
}
