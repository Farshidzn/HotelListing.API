﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Data.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    Id = 1,
                    Name = "Sweden",
                    ShortName = "SWE"
                },
                 new Country
                 {
                     Id = 2,
                     Name = "Bahamas",
                     ShortName = "BS"
                 },
                  new Country
                  {
                      Id = 3,
                      Name = "Cayman ISland",
                      ShortName = "CI"
                  }
                );
        }
    }
}
