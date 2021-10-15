using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Candles_Database.Models
{
    public class Candles
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 4)]
        [Required]      //I make the name a required string, as well as put both a minimum and maximum length for it.
        public string Name { get; set; }

        [Display(Name = "Candle Type")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(25)]
        public string canType { get; set; }    //Candles have different types and colours, hence I used these as properties. 
        
        [StringLength(20)]
        [Required]
        public string Colour { get; set; }

        [Column(TypeName = "decimal(18, 2)")]   //this is so the price is mapped to currency.
        public decimal Price { get; set; }

        [Display(Name = "User Rating")]
        [Range(1, 5)] //the user rating only has a range from 1 to 5. 
        public decimal UserRating { get; set; } //I'm editing this rating to instead by "UserRating". 

    }
}