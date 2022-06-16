using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOperatorOverloading
{
    class BooksForReading
    {
        protected List<String> books = new List<String>();
        
        public BooksForReading()
        {
            Console.WriteLine("LIST_IS_EMPTY");
        }
        public BooksForReading(List<string> books)
        {
            for(int i = 0; i < books.Count; i++) 
            { 
                this.books = books;
            }
        }

        public void FindBook(String key)
        {
            bool result = false;
            for(int i = 0; i < books.Count; i++)
            {
                if(books[i].Equals(key))
                {
                    result = true; 
                }
            }
            if(result)
            {
                Console.WriteLine("We found u`r book!");
            }
            else
            {
                Console.WriteLine("!We cant find u`r book!");
            }
        }

        public void AddBook(String key)
        {
            books.Add(key);
        }
        public void RemoveBook(String key)
        {
            books.Remove(key);
        }
    }
}
