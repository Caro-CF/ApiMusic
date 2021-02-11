using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMusic.Models
{
    public class Music
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3), Required]
        public string Title { get; set; }

        
        [StringLength(60)]
        public string Artist { get; set; }

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(30)]
        [Required]
        public string Genre { get; set; }


        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        /*[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]*/
        [StringLength(5), Required]
        public string Rating { get; set; }

        public bool isValidate { get; set; }

    }
}