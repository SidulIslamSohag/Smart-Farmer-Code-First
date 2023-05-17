namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.FarmerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.FarmerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            for (int i = 1; i <= 10; i++)
            {
                context.Orders.AddOrUpdate(new Models.Order
                {
                    Id = i,
                    ProductId = i,
                    Quantity = i,
                    Category = "Vegetable",
                    Date = DateTime.Now,
                    CustomerId = i,
                    Status = "Pending"
                });
            }
        }
    }
}
