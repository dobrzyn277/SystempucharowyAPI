using SystempucharowyAPI.Data;
using SystempucharowyAPI.Models;

public class Query
{
    public List<Tournament> GetTournaments([Service] AppDbContext db) => db.Tournaments.ToList();
}