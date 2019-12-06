namespace HarveyGigCF.Migrations.Jobs
{
    using HarveyGigCF.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HarveyGigCF.Data.JobsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Jobs";
        }

        protected override void Seed(HarveyGigCF.Data.JobsContext context)
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

            context.Apps.AddOrUpdate(
                a => a.AppId, DummyData.getApps().ToArray());
            context.SaveChanges();

            context.Jobs.AddOrUpdate(
                    j => j.JobId, DummyData.getJobs(context).ToArray());
            context.SaveChanges();

        }   
    }
}
