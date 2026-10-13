using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        //private fields

        private string title;
        private string author;
        private string isbn;

        //public fields

        public string Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Error: Title cannot be blank.");
                }
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author cannot be blank.");
                }
            }
        }
        public string ISBN
        {
            get { return isbn; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }

        //constructor

        public Book(string title, string author, string isbn)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    
