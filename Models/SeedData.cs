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
                        Rating = 3.5M
                    },

                    new Candles
                    {
                        Name = "Super Mario Birthday Party",
                        canType = "Molded",
                        Colour = "Red",
                        Price = 14.99M,
                        Rating = 4.0M
                    },

                    new Candles
                    {
                        Name = "Stonebriar Unscented",
                        canType = "Tea Light",
                        Colour = "White",
                        Price = 13.56M,
                        Rating = 3.0M
                    },

                    new Candles
                    {
                        Name = "Root Candles 10-Hour",
                        canType = "Votive",
                        Colour = "White",
                        Price = 6.99M,
                        Rating = 4.2M
                    }
                ) ;
                context.SaveChanges();
            }
        }
    }
}
