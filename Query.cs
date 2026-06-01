using SystempucharowyAPI.Data;
using SystempucharowyAPI.Models;

namespace SystempucharowyAPI;

public class Query
{
    public List<Book> GetBooks([Service] AppDbContext db) => db.Books.ToList();
}