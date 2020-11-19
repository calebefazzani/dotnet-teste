using Movie.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Movie.Data.Configurations 
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.Id);

            builder
            .Property(m => m.Id)
            .UseIdentityColumn();

            builder
            .Property(m => m.Title)
            .HasMaxLength(60);

            builder
            .ToTable("Movies");

        }
    }
}