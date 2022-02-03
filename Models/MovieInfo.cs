using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FilmCollectionMission4.Models
{
    public class MovieInfo : DbContext
    {
        public MovieInfo (DbContextOptions<MovieInfo> options) : base (options)
        {
            //leave blank for now
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<CategoryList> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<CategoryList>().HasData(
                new CategoryList { CategoryID=1, Category="Action/Adventure"},
                new CategoryList { CategoryID = 2, Category = "Comedy" },
                new CategoryList { CategoryID = 3, Category = "Drama" },
                new CategoryList { CategoryID = 4, Category = "Family" },
                new CategoryList { CategoryID = 5, Category = "Horror/Suspense" },
                new CategoryList { CategoryID = 6, Category = "Miscellaneous" },
                new CategoryList { CategoryID = 7, Category = "Television" },
                new CategoryList { CategoryID = 8, Category = "VHS" }
            );


            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Title = "Captain America: The First Avenger",
                    Year = 2011,
                    DirectorFirst = "Joe",
                    DirectorLast = "Johnston",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "",
                },
                new ApplicationResponse
                {
                    MovieID = 2,
                    CategoryID = 1,
                    Title = "Captain America: Civil War",
                    Year = 2016,
                    DirectorFirst = "Joe",
                    DirectorLast = "Russo",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "",
                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    CategoryID = 1,
                    Title = "Captain America: Winter Soldier",
                    Year = 2014,
                    DirectorFirst = "Joe",
                    DirectorLast = "Russo",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = "",
                }
            );
        }
    }
}
