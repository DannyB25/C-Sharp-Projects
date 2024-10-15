using Microsoft.Extensions.DependencyInjection;
using University;
using Microsoft.EntityFrameworkCore;

namespace EF6Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<SchoolContext>(options =>
                    options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SchoolDB;Trusted_Connection=True;"))
                .BuildServiceProvider();

            using (var context = serviceProvider.GetService<SchoolContext>())
            {
                
                var stud = new Student() { FirstName = "Bill", LastName = "Johnson" };

                context.Students.Add(stud);
                context.SaveChanges();

                Console.WriteLine("Successful Addition to Database");
                Console.ReadLine();
            }
        }
    }
}