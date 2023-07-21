using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review2
{
    public delegate void InfoDelegate(string s);

    public class BookManage: IEnumerable<Book>
    {
        public event InfoDelegate Info;

        List<Book> books = new List<Book>();

        public void CreateBook()
        { 
            Book book = new Book();
            book.Input(); // gọi hàm Input() để nhập liệu
            books.Add(book);
        }

        public void FindByIsSale()
        {
            foreach (Book book in books) 
            {
                if (book.IsSale)
                {
                    book.BookInfo();
                }
            }
        }

        public IEnumerator<Book> GetEnumerator()
        {
            if (books.Count == 0)
            {
                if (Info != null)
                {
                    Info("No Data.");
                }
            }
            else
            { 
                foreach (Book book in books)
                {
                    yield return book;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (books.Count == 0)
            {
                if (Info != null)
                {
                    Info("No Data.");
                }
            }
            else
            {
                foreach (Book book in books)
                {
                    yield return book;
                }
            }
        }
    }
}