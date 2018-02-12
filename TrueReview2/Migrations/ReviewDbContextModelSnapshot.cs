﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TrueReview2.Data;
using TrueReview2.Models;

namespace TrueReview2.Migrations
{
    [DbContext(typeof(ReviewDbContext))]
    partial class ReviewDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrueReview2.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BookId");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("TrueReview2.Models.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GenreId");

                    b.Property<string>("GenreName");

                    b.HasKey("ID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("TrueReview2.Models.Profile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProfileId");

                    b.HasKey("ID");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("TrueReview2.Models.Rating", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RatingId");

                    b.Property<int>("RatingNumber");

                    b.HasKey("ID");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("TrueReview2.Models.Review", b =>
                {
                    b.Property<int>("GenreId");

                    b.Property<int>("RatingId");

                    b.Property<string>("BookReview");

                    b.Property<int>("GenreName");

                    b.Property<int>("ID");

                    b.Property<int>("RatingNumber");

                    b.Property<int?>("ReviewGenreId");

                    b.Property<int>("ReviewId");

                    b.Property<int?>("ReviewRatingId");

                    b.Property<string>("Title");

                    b.HasKey("GenreId", "RatingId");

                    b.HasIndex("ReviewGenreId", "ReviewRatingId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("TrueReview2.Models.Review", b =>
                {
                    b.HasOne("TrueReview2.Models.Review")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewGenreId", "ReviewRatingId");
                });
#pragma warning restore 612, 618
        }
    }
}
