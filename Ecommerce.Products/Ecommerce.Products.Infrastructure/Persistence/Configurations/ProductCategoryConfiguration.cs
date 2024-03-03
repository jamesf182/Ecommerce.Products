using Ecommerce.Products.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Products.Infrastructure.Persistence.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(pc => new { pc.ProductId, pc.CategoryId });

            builder.Property(pc => pc.ProductId).IsRequired();
            builder.Property(pc => pc.CategoryId).IsRequired();

            builder
                .HasOne(pc => pc.Product)
                .WithMany(c => c.Categories)
                .HasForeignKey(pc => pc.ProductId);

            builder
                .HasOne(c => c.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
