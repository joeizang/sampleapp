using System;
using System.Data.Entity.ModelConfiguration;
using samplemvcapp.Models;

namespace samplemvcapp.Data.EntityTypeConfigurations
{
    public class MovieTypeConfiguration : EntityTypeConfiguration<Movie>
    {
        public MovieTypeConfiguration()
        {
            this.HasKey(m => m.MovieId);
            this.HasIndex(m => m.MovieTitle);
            this.Property(m => m.MovieTitle).HasMaxLength(100)
                .IsRequired();
            this.Property(m => m.MovieLength).IsRequired();
            this.Property(m => m.MovieReleaseDate).IsRequired();
            //Property(m => m.MovieGenres).IsRequired();
        }
    }
}
