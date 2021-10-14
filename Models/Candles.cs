using System;
using System.ComponentModel.DataAnnotations;

namespace Candles_Database.Models
{
    public class Candles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string canType { get; set; }    //Candles have different types and colours, hence I used these as properties. 
        public string Colour { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
    }
}