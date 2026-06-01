using SystempucharowyAPI.Data;
using SystempucharowyAPI.Models;
using HotChocolate;

namespace SystempucharowyAPI;

public class Mutation
{
    public Book AddBook(string title, int year, int authorId, [Service] AppDbContext db)
    {
        var book = new Book { Title = title, Year = year, AuthorId = authorId };
        db.Books.Add(book);
        db.SaveChanges();
        return book;
    }

    public Author AddAuthor(string firstName, string lastName, [Service] AppDbContext db)
    {
        var author = new Author { FirstName = firstName, LastName = lastName };
        db.Authors.Add(author);
        db.SaveChanges();
        return author;
    }
}