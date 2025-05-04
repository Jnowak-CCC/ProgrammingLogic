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

    // Parameterized Constructor (1 parameter)
    public Book(string title)
    {
        this.title = title;
        this.author = "Unknown Author";
    }

    // Overloaded Constructor (2 parameters)
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

   
    public string GetTitle()
    {
        return title;
    }

    
    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

   
    public string GetAuthor()
    {
        return author;
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
        
        Book book1 = new Book();
        Console.WriteLine(book1.GetTitle());  

        book1.SetTitle("C# Fundamentals");
        Console.WriteLine(book1.GetTitle());

       
        Book book2 = new Book("Advanced C#");
        Console.WriteLine(book2.GetTitle());  

       
        Book book3 = new Book("Advanced C#", "John Doe");
        Console.WriteLine("Title: " + book3.GetTitle());   
        Console.WriteLine("Author: " + book3.GetAuthor());

       
        Book book4 = new Book();
        book4.SetTitle("Mastering C#");
        book4.SetAuthor("Jane Smith");
        Console.WriteLine("Title: " + book4.GetTitle());  
        Console.WriteLine("Author: " + book4.GetAuthor()); 
    }
}
