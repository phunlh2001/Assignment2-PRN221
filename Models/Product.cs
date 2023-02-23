using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2.Models
{
    public class Product
    {
        [Column("pro_id")]
        [Key] public int ID { get; set; }
        [Column("pro_name")]
        [Required(ErrorMessage = "Product Name cannot be empty!")]
        public string Name { get; set; }
        [Column("pro_quantity")]
        [Required(ErrorMessage = "Product quantity must be greater than zero!")]
        public int Quantity { get; set; }
        [Column("pro_price")]
        [Required(ErrorMessage = "Product price must be greater than zero!")]
        public long Price { get; set; }
        [Column("pro_description")]
        public string Description { get; set; }

        [Column("cat_id")]
        public int CateID { get; set; }
        public virtual Category Category { get; set; }

    }
}
