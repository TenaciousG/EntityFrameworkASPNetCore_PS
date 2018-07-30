using System.Linq;

namespace ASPNETCoreMVC_PS.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Pies.Any())
            {
                context.AddRange(
                    new Pie {Name = "Apple Pie", Price = 12.95M, ShortDescription="Our famous apple pie", LongDescription="Icing and stuff"},
                    new Pie { Name = "Blueberry Pie", Price = 9.95M, ShortDescription = "Our famous blueberry pie", LongDescription = "Icing and stuff"});
            }

            context.SaveChanges();
        }
    }
}