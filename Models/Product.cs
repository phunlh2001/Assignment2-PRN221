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
        [StringLength(50, ErrorMessage = "Product name cannot greater than 50 words")]
        public string Name { get; set; }


        [Column("pro_quantity")]
        [Required(ErrorMessage = "Product quantity must be greater than zero!")]
        public int Quantity { get; set; }


        [Column("pro_price")]
        [Required(ErrorMessage = "Product price must be greater than zero!")]
        public long Price { get; set; }

        [Column("pro_description")]
        [Required(ErrorMessage = "Product description cannot be empty!")]
        [StringLength(50, ErrorMessage = "Description cannot greater than 50 words")]
        public string Description { get; set; }

        [Column("likes")]
        public int Likes { get; set; } = 0;

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }


        [Column("cat_id")]
        public int CateID { get; set; }
        public virtual Category Category { get; set; }

    }
}
