using SystempucharowyAPI.Data;
using SystempucharowyAPI.Models;

public class Mutation
{
    public Tournament AddTournament(string name, [Service] AppDbContext db)
    {
        var tournament = new Tournament { Name = name, StartDate = DateTime.Now };
        db.Tournaments.Add(tournament);
        db.SaveChanges();
        return tournament;
    }
}