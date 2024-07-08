using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Models {

    [Table("Hamburgers")]
    public class Hamburger {

        [Key]
        public int HamburgerID { get; set; }

        /* ----- */

        [Display(Name = "Hamburguer Name")]
        [Required(ErrorMessage = "The name must be informed")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "The name must have at least {2} characters and not exceed {1} caracters")]
        public string HamburgerName { get; set; }

        /* ----- */

        [Display(Name = "Short Description")]
        [Required(ErrorMessage = "The short description must be informed")]
        [StringLength(100, ErrorMessage = "The short description must not exceed {1} characters")]
        public string ShortDescription { get; set; }

        /* ----- */

        [Display(Name = "Long Description")]
        [Required(ErrorMessage = "The long description must be informed")]
        [StringLength(100, ErrorMessage = "The long description must not exceed {1} characters")]
        public string LongDescription { get; set; }

        /* ----- */

        [Display(Name = "Hamburger Price")]
        [Required(ErrorMessage = "The hamburger price must be informed")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "The price must be between ${1} and ${2}")]
        public decimal Price { get; set; }

        /* ----- */

        [Display(Name = "Image URL Path")]
        [StringLength(200, ErrorMessage = "The image URL path must not exceed {1} characters")]
        public string ImageURL { get; set; }

        /* ----- */

        [Display(Name = "Thumb Image URL Path")]
        [StringLength(200, ErrorMessage = "The thumb image URL path must not exceed {1} characters")]
        public string ImageThumbURL { get; set; }

        /* ----- */

        [Display(Name = "Is Prefered?")]
        public bool IsFavorite { get; set; }

        /* ----- */

        [Display(Name = "Has in Stock?")]
        public bool HasInStock { get; set; }

        /* ----- */

        /* 1 to N relation */
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
