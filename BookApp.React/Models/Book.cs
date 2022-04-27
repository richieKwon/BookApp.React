using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookApp.React.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [MaxLength(255)]
        [Required(ErrorMessage = "Enter your book name!")]
        [Column(TypeName = "Varchar(255)")]
        public string Title { get; set; }
        
        public string Description { get; set; }
    }
}    