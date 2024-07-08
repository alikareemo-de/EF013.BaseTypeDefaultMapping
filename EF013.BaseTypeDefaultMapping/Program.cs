using EF010.CodeFirstMigration.Data;
using EF013.BaseTypeDefaultMapping.Entities;

namespace EF013.BaseTypeDefaultMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var particpant1 = new Individual()
            {
                Id = 3,
                FName = "Ali",
                LName = "Kareemo",
                University = "SVU",
                YearOfGreaduation = 2025,
                IsIntern = true
            };
            var particpant2 = new Coporate()
            {
                Id = 4,
                FName = "Ahmad",
                LName = "Kareemo",
                CompanyName = "SVU",
                JopTitle = "Developer"
            };

            using (var context = new AppDbContext())
            {
                context.Particpants.Add(particpant1);
                context.Particpants.Add(particpant2);
                context.SaveChanges();
            }

            using (var context = new AppDbContext())
            {
                Console.WriteLine("Coporate Particoants");

                foreach (var particpant in context.Set<Particpant>().OfType<Coporate>())
                {
                    Console.WriteLine(particpant);
                }
                Console.WriteLine("Individual Particoants");

                foreach (var particpant in context.Set<Particpant>().OfType<Individual>())
                {
                    Console.WriteLine(particpant);
                }

            }
            Console.WriteLine("Hello, World!");
        }
    }
}
