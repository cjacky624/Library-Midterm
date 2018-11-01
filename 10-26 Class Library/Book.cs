using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_26_Class_Library
{
    class Book
    {
        private string title;
        private string author;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public Book(string t, string a) //use static if it is going to be uesd in the main
        {
            title = t;
            author = a;
        }
    }
}
