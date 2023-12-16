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
                db.Teams.Add(new Team { Name = "Dynamo", City = "Kyiv", Tie = 1, Win = 6, Lose = 3, ConcededGoals = 4, ConfirmedGoals = 2 });
                db.Teams.Add(new Team { Name = "Chelsea", City = "London", Tie = 0, Win = 5, Lose = 5, ConcededGoals = 4, ConfirmedGoals = 2 });
                db.SaveChanges();
                db.Matches.Add(new Match { GoalGuest = 5, GoalHome = 5, GuestTeam = 2, HomeTeam = 1, Date = DateTime.Now.Date.ToString() });
                db.Matches.Add(new Match { GoalGuest = 5, GoalHome = 5, GuestTeam = 2, HomeTeam = 1, Date = DateTime.Now.Date.ToString() });
                db.Matches.Add(new Match { GoalGuest = 5, GoalHome = 5, GuestTeam = 2, HomeTeam = 1, Date = DateTime.Now.Date.ToString() });
                db.Matches.Add(new Match { GoalGuest = 5, GoalHome = 5, GuestTeam = 2, HomeTeam = 1, Date = DateTime.Now.Date.ToString() });
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
            using (var db = new ApplicationContext())
            {
                var colection = db.Teams.ToList();
                foreach (var team in colection)
                {
                    Console.WriteLine($"{team.Name} | {team.Win - team.Lose}");
                }
            }
            using (var db = new ApplicationContext())
            {

                var colection = db.Matches.Where(u => u.Id == 1).ToList();
                foreach (var match in colection)
                {
                    Console.WriteLine($"{match.Id} | {match.HomeTeam} | {match.GuestTeam} | {match.Date}");
                }
            }
            using (var db = new ApplicationContext())
            {
                string date = DateTime.Now.Date.ToString();
                var colection = db.Matches.Where(u => u.Date == date).ToList();
                foreach (var match in colection)
                {
                    Console.WriteLine($"{match.Id} | {match.HomeTeam} | {match.GuestTeam} | {match.Date}");
                }
            }
            using (var db = new ApplicationContext())
            {
                var colection = db.Matches.Where(u => u.GuestTeam == 1 && u.HomeTeam == 1).ToList();
                foreach (var match in colection)
                {
                    Console.WriteLine($"{match.Id} | {match.HomeTeam} | {match.GuestTeam} | {match.Date}");
                }
            }
            using (var db = new ApplicationContext())
            {

                var colection = db.Goals.Join(db.Matches, d => d.MatchId, p => p.Id, (p, d) => new { PlayerId = p.PlayerId, Date = d.Date }).ToList();
                foreach (var match in colection)
                {
                    Console.WriteLine(123);
                    Console.WriteLine($"{match.PlayerId} | {match.Date}");
                }
            }
            using (var db = new ApplicationContext())
            {
                var element = db.Matches.Where(u => u.Id == 1).FirstOrDefault();
                element.GoalGuest = 100;
                db.SaveChanges();
            }
            using (var db = new ApplicationContext())
            {
                db.Remove(new Match { Id = 2 });
                db.SaveChanges();
            }
        }
    }
}