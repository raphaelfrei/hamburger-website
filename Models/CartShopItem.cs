using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Models {

    [Table("CartShopItems")]
    public class CartShopItem {

        /* ----- */

        [Key]
        [Display (Name = "Cart Shop Item ID")]
        public int CartShopItemID { get; set; }

        /* ----- */

        public Hamburger Hamburger { get; set; }

        /* ----- */

        [Required(ErrorMessage = "The quantity must be set")]
        [Range(0, 99, ErrorMessage = "The quantity must be between {1} and {2}")]
        public int Quantity { get; set; }

        /* ----- */

        [StringLength(200)]
        public string CartShopId { get; set; }

    }
}
