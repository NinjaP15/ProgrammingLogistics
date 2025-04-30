using System;

class Book
{
    private string title;
    private string author;

    // Default Constructor
    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author";
    }

    // Constructor with title parameter
    public Book(string title)
    {
        this.title = title;
        author = "Unknown Author";
    }

    // Constructor with title and author parameters
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    // Getters
    public string GetTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    // Setters
    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Problem 1: Default constructor
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle()); 
        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle()); 

        // Problem 2: Parameterized constructor (title)
        Book book2 = new Book("Advanced C#");
        Console.WriteLine(book2.GetTitle()); 

        // Problem 3: Constructor overloading (title + author)
        Book book3 = new Book("Advanced C#", "John Doe");
        Console.WriteLine("Title: " + book3.GetTitle());
        Console.WriteLine("Author: " + book3.GetAuthor());

        // Problem 4: Update fields using setter methods
        Book book4 = new Book();
        book4.SetTitle("Mastering C#");
        book4.SetAuthor("Jane Smith");
        Console.WriteLine("Title: " + book4.GetTitle());
        Console.WriteLine("Author: " + book4.GetAuthor());
    }
}
