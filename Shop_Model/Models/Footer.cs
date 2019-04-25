using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop_Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Content { get; set; }
    }
}