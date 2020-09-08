using System;

namespace Task3
{
    class Book
    {
        private Title title;
        private Author author;
        private Content content;

        public Book(Title title, Author author, Content content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }


    
            public class Title
            {
                private string title;
                
                public string SetTitle 
                { 
                    get => title;
                    set => title = value;
                }
                public void Show() 
                { 
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Title: {0}",title);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            public class Author 
            { 
                private string author;
                
                public string SetAuthor 
                { 
                    get => author;
                    set => author = value;
                }
                public void Show() 
                { 
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Author: {0}",author);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            public class Content 
            { 
                private string content;
                
                public string SetContent 
                { 
                    get => content;
                    set => content = value;
                }
                public void Show() 
                { 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(content);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
    
    class Program
    {
        static void Main(string[] args)
        {
            Title title = new Title();
            title.SetTitle = "Fisting in the gym";
            
            Author author = new Author();
            author.SetAuthor = "CUMMON SLAVE";
            
            Content content = new Content();
            content.SetContent = "This book is covered in semen";

            Book kniga = new Book(title,author,content);
            
            kniga.Show();

            Console.ReadKey();
        }
    }
}
