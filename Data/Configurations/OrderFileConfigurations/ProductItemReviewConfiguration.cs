﻿using E_Commerce.Models.OrderFile;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.Data.Configurations.OrderFileConfigurations
{
    public class ProductItemReviewConfiguration : IEntityTypeConfiguration<ProductItemReview>
    {
        public void Configure(EntityTypeBuilder<ProductItemReview> builder)
        {
            builder.ToTable("ProductItemReviews");

            builder.HasOne(pir => pir.OrderLine)
                .WithMany(ol => ol.ProductItemReviews)
                .HasForeignKey(pir => pir.OrderLineId);

            builder.HasOne(pir => pir.User)
               .WithMany(u => u.ProductItemReviews)
               .HasForeignKey(pir => pir.UserId);

        }
    }
}
