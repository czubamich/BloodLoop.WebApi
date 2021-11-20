﻿using BloodLoop.Domain;
using BloodLoop.Domain.Accounts;
using BloodLoop.Domain.Donations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BloodLoop.Infrastructure.Persistance.Configurations
{
    public class BloodTypeConfiguration : IEntityTypeConfiguration<BloodType>
    {
        public void Configure(EntityTypeBuilder<BloodType> builder)
        {
            builder
               .ToTable($"{nameof(BloodType)}s");

            builder
                .HasKey(x => x.Label);

            builder
                .HasData(SeedData());
        }

        public BloodType[] SeedData()
        {
            return BloodType.GetBloodTypes();
        }
    }
}