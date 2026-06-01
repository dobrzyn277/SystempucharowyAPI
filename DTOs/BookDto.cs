using SystempucharowyAPI.Models;
public class BookDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int Year { get; set; }
    public Author Author { get; set; } = null!;
}