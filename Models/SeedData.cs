using System;
using System.Linq;
using Candles_Database.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Candles_Database.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Candles_DatabaseContext(          //I connect to the Candles Database that we created earlier.
                serviceProvider.GetRequiredService<
                    DbContextOptions<Candles_DatabaseContext>>()))
            {
                
                if (context.Candles.Any())          //We look in the Candles class that we created earlier.
                {
                    return;   
                }

                context.Candles.AddRange(
                    new Candles
                    {
                        Name = "5 Year Birthday",
                        canType = "Molded",
                        Colour = "White",
                        Price = 6.99M,
                        UserRating = 3
                    },

                    new Candles
                    {
                        Name = "Super Mario Birthday Party",
                        canType = "Molded",
                        Colour = "Red",
                        Price = 14.99M,
                        UserRating = 4
                    },

                    new Candles
                    {
                        Name = "Stonebriar Unscented",
                        canType = "Tea Light",
                        Colour = "White",
                        Price = 13.56M,
                        UserRating = 3
                    },

                    new Candles
                    {
                        Name = "Root Candles 10-Hour",
                        canType = "Votive",
                        Colour = "White",
                        Price = 6.99M,
                        UserRating = 4
                    },

                    new Candles
                    {
                        Name = "Red Currant No. 96",
                        canType = "Votive",
                        Colour = "Brown",
                        Price = 45.42M,
                        UserRating = 5
                    },

                    new Candles
                    {
                        Name = "Unscented Black Wax",
                        canType = "Votive",
                        Colour = "Black",
                        Price = 3.22M,
                        UserRating = 3
                    },

                    new Candles
                    {
                        Name = "Cathedral Stearine",
                        canType = "Molded",
                        Colour = "Off White",
                        Price = 6.65M,
                        UserRating = 2
                    },

                    new Candles
                    {
                        Name = "Root Candles 10-Hour",
                        canType = "Votive",
                        Colour = "White",
                        Price = 6.99M,
                        UserRating = 4
                    },

                    new Candles
                    {
                        Name = "Hello Kitty Balloon Dreams",
                        canType = "Molded",
                        Colour = "Pink",
                        Price = 10.42M,
                        UserRating = 1
                    },

                    new Candles
                    {
                        Name = "Ikea Sinnlig Scented",
                        canType = "Tea Light",
                        Colour = "Green",
                        Price = 14.09M,
                        UserRating = 4
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}
