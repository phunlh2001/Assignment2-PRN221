using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment2.Models
{
    public class Category
    {
        [Column("Cat_ID")]
        [Key] public int ID { get; set; }
        [Column("Cat_Name")]
        public string Name { get; set; }

        [ForeignKey("CateID")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
