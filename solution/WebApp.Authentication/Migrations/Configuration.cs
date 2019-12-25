using System.Data.Entity.Migrations;

namespace WebApp.Authentication.Migrations
{
	internal sealed class Configuration : DbMigrationsConfiguration<WebApp.Authentication.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApp.Authentication.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

        }
    }
}
