using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam
{
    class Shelf
    {
        private List<Book> Books;
        public Shelf()
        {
            Books = new List<Book>();
        }

        public int Count
        {
            get
            {
                return Books.Count;
            }
        }
        public Book Head
        {
            get
            {
                return Books.Min();
            }
        }
        public Book Tail
        {
            get
            {
                return Books.Max();
            }
        }

        public void AddBook(string bookId)
        {
            var book = new Book(bookId);
            Books.Add(book);
        }

        public void AddSpecialBook(string bookId)
        {
            Books.Insert(0, new Book(bookId));
        }

        public Book CheckBookIsPresent(string bookId)
        {
           return Books.Where(x => x.BookId == bookId).FirstOrDefault();
        }

        public bool ReleaseBook(string bookId)
        {
            var book = Books.Where(x => x.BookId == bookId).FirstOrDefault();
            return Books.Remove(book);
        }

        public bool ReleaseBook(int index)
        {
            
            if (index >= 0 && index < Books.Count)
            {
                Books.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public StringBuilder ShelfInformation()
        {
            var stb = new StringBuilder();
            if (Books.Count > 0)
            {
                for (int i = 0; i < Books.Count; i++)
                {
                    stb.AppendLine(Books[i].ToString());
                }
                return stb;
            }
            else
            {
                stb.AppendLine("Shelf is empty!");
                return stb;
            }
        }
    }
}
