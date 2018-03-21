namespace BrnoMvc1.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BrnoMvc1.Web.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BrnoMvc1.Web.Models.ApplicationDbContext";
        }

        protected override void Seed(BrnoMvc1.Web.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Movies.AddOrUpdate(
                p => p.Id,
                new Models.Movie { Id = 1, Title = "Homer", Desription = "animák", SelectGenres = Models.Genres.Comedy },
                new Models.Movie { Id = 2, Title = "Pelišky", Desription = "animák",SelectGenres=Models.Genres.Comedy }
                );
        }
    }
}
