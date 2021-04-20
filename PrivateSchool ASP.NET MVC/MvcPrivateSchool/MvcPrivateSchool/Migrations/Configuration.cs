namespace MvcPrivateSchool.Migrations
{
    using MvcPrivateSchool.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcPrivateSchool.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcPrivateSchool.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            var trainers = new List<Trainer>
            {
                new Trainer
                {
                    ID = 1,
                    FirstName = "Nikos",
                    LastName = "Oikonomou",
                    Subject = "Csharp"
                },
                new Trainer
                {
                    ID = 2,
                    FirstName = "Panos",
                    LastName = "Konstantinidis",
                    Subject = "Csharp"
                },
                new Trainer
                {
                    ID = 3,
                    FirstName = "Giannis",
                    LastName = "Dedes",
                    Subject = "Csharp"
                },
                new Trainer
                {
                    ID = 4,
                    FirstName = "Fotis",
                    LastName = "Pantazis",
                    Subject = "Java"
                },
                new Trainer
                {
                    ID = 5,
                    FirstName = "Manolis",
                    LastName = "Georgiou",
                    Subject = "Java"
                },
                new Trainer
                {
                    ID = 6,
                    FirstName = "Vasilis",
                    LastName = "Sotiriou",
                    Subject = "Java"
                },
                new Trainer
                {
                    ID = 7,
                    FirstName = "Dimitris",
                    LastName = "Papadopoulos",
                    Subject = "HTML"
                },
                new Trainer
                {
                    ID = 8,
                    FirstName = "Leonidas",
                    LastName = "Karadimas",
                    Subject = "HTML"
                }
            };

            trainers.ForEach(t => context.Trainers.AddOrUpdate(t));
            context.SaveChanges();
        }
    }
}
