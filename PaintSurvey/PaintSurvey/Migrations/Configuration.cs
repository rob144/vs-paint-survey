namespace PaintSurvey.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Collections;
    using System.Data.Entity.Migrations;
    using System.Collections.Generic;
    using PaintSurvey.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<PaintSurvey.DAL.PaintSurveyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PaintSurvey.DAL.PaintSurveyContext context)
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

            
        }
    }
}
