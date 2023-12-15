using DataAccess;
using Entities;

namespace EFCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ApplicationContext())
            {
                db.Teams.Add(new Team { Name = "Dynamo", City = "Kyiv", Tie = 1, Win = 6, Lose = 3 });
                db.Teams.Add(new Team { Name = "Chelsea", City = "London", Tie = 0, Win = 5, Lose = 5 });
                db.SaveChanges();
            }
            using (var db = new ApplicationContext())
            {
                var colection = db.Teams.ToList();
                foreach (var team in colection)
                {
                    Console.WriteLine($"{team.Id} | {team.Name} | {team.Win} | {team.Lose} | {team.Tie}");
                }
            }

        }
    }
}