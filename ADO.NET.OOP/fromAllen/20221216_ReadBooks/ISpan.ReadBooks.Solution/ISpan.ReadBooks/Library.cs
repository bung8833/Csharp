using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.ReadBooks
{
    public class Library
    {
        private Dictionary<string, Book> _books;

        //public IEnumerable<Book> Books
        //    => _books.Select(item => item.Value);

        public IEnumerable<Book> Books
        {
            get {
                return _books.Select( item => item.Value );  
            }
        }
        // => _books.Select(item => item.Value);

        public Library()
        {
            _books = new Dictionary<string, Book>();
        }

        /// <summary>
        /// 傳回指定的 Book,若不存在,傳回null
        /// </summary>
        /// <param name="bookTitle"></param>
        /// <returns></returns>
        public Book this[string bookTitle]
        {
            get
            {
                return this._books.ContainsKey(bookTitle)
                    ? this._books[bookTitle]
                    : null;
            }
        }

        /// <summary>
        /// what-加入一本書
        /// </summary>
        /// <param name="book">新書,若為null不做任何動作,若title重覆則置換內容</param>
        public void CheckIn(Book book)
        {
            if (book == null) return;

            if (_books.ContainsKey(book.Title))
            {
                _books[book.Title] = book;
            }
            else
            {
                _books.Add(book.Title, book);
            }

        }

        public int Count()
            => _books.Count;
    }
}
