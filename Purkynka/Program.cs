using Microsoft.EntityFrameworkCore;
using Purkynka.DAL;
using Purkynka.DAL.Models;

namespace Purkynka
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using(var ctx = new DatabaseContext())
            {
                ctx.Database.Migrate();

                ctx.Users.Add(new User() { FirstName = "Tomáš", LastName = "Caha", DateOfBirth = DateTime.Today.AddDays(-10292) });
                ctx.SaveChanges();

                var user = ctx.Users.FirstOrDefault();
                Console.WriteLine(user?.FullName);
            }

            Console.ReadLine();
        }
    }
}