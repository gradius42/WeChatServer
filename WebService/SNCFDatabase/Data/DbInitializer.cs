using SNCFDatabase.Models;
using System.Linq;

namespace SNCFDatabase.Data
{
    public class DbInitializer
    {
        public static void Initialize(SNCFContext context)
        {
            context.Database.EnsureCreated();

            if (context.Cities.Any())
                return;

            var cities = new City[]
            {
                new City { ID = "0001", Name = "Strasbourg" },
                new City { ID = "0002", Name = "Paris" },
                new City {  ID = "0003", Name = "Lille" }
            };

            foreach (City currentCity in cities)
            {
                context.Cities.Add(currentCity);
            }

            context.SaveChanges();

            var forums = new Forum[]
            {
                new Forum { Name = "Où manger à Strasbourg ?", CityID = "0001" },
                new Forum { Name = "Comment est la gare de Paris", CityID = "0002" }
            };

            foreach (Forum currentForum in forums)
            {
                context.Forums.Add(currentForum);
            }

            context.SaveChanges();
        }
    }
}
