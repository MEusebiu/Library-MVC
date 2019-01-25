namespace CityLibrary.MVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CityLibrary.MVC.DbContext.CityLibraryDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CityLibrary.MVC.DbContext.CityLibraryDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Books.AddOrUpdate(
                new Models.Book { Id = 1, AuthorId = 1, GenreId = 1, Description = "These new beginnings", Name = "2012 - The movie" },
                new Models.Book { Id = 1, AuthorId = 2, GenreId = 2, Description = "These new sunsets", Name = "Morning everyone" },
                new Models.Book { Id = 1, AuthorId = 1, GenreId = 1, Description = "These new moons", Name = "Skylight" },
                new Models.Book { Id = 1, AuthorId = 3, GenreId = 3, Description = "These new circumstances", Name = "Cornered" },
                new Models.Book { Id = 1, AuthorId = 4, GenreId = 4, Description = "These new friends", Name = "Antouraje" }
                );

            context.Authors.AddOrUpdate(
                new Models.Author { Id = 1, AuthorName = "Lowan Cors" },
                new Models.Author { Id = 2, AuthorName = "Gor Cis" },
                new Models.Author { Id = 3, AuthorName = "Maria Turret" },
                new Models.Author { Id = 4, AuthorName = "Lowan Star" },
                new Models.Author { Id = 5, AuthorName = "Lowan Cors" }
                );

            context.Genres.AddOrUpdate(
                new Models.Genre { Id = 1, Type = "Drama"},
                new Models.Genre { Id = 2, Type = "Horror" },
                new Models.Genre { Id = 3, Type = "Comedy" },
                new Models.Genre { Id = 4, Type = "Mistery" },
                new Models.Genre { Id = 5, Type = "Sci-Fi" }
                );
        }
    }
}
