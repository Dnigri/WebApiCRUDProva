namespace ProvaProgram.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProvaProgram.Data.ProvaProgramContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProvaProgram.Data.ProvaProgramContext context)
        {
            context.Students.AddOrUpdate(x => x.Id,
        new Models.Student() { Id = 1, Name = "Jane", Telephone = "879879879", Email = "adm@hotmail.com" },
        new Models.Student() { Id = 2, Name = "Charles", Telephone = "33333333", Email = "333333306@hotmail.com" },
        new Models.Student() { Id = 3, Name = "Miguel", Telephone = "969261307", Email="tigre06@hotmail.com"}
        );




            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
