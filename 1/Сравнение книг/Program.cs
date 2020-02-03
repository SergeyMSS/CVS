using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сравнение_книг
{
    class Book : IComparable
    {
        public string Title;
        public int Theme;

        public int CompareTo(object obj)
        {
            var book = (Book)obj;
            var thisBookTheme = Theme;
            var thatBookTheme = book.Theme;
            var thisTitle = Title;
            var thatTitle = book.Title;

            if (thisBookTheme.CompareTo(thatBookTheme) == 0)
                return thisTitle.CompareTo(thatTitle);
            else
                return thisBookTheme.CompareTo(thatBookTheme);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
