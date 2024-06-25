using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BookProject.Web.Models
{

    [Table("Books")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Author { get; set; } = string.Empty;  // "Possible" Foreign Key (Author Table)

        [Required]
        public string Genre { get; set; } = string.Empty;   // // "Possible" Foreign Key (Genre Table)

        [Required]
        [StringLength(13+4, MinimumLength = 13+4)]
        public string ISBN { get; set; } = string.Empty;    // Assuming for ISBN-13
            // OR
            //[StringLength(10+2, MinimumLength = 10+2)]
            //public string ISBN_10 { get; set; } = string.Empty;

    }

}
