namespace PatikaWeek7Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book nesnesinden türetilmiş liste oluşturuluyor.
            List<Book> bookList = new List<Book>()
            {  
                new Book { BookId=1,Title="Kar",AuthorId=1},
                new Book { BookId=2,Title="Istanbul",AuthorId=1},
                new Book { BookId=3,Title="Şehrin Aynaları",AuthorId=2},
                new Book { BookId=4, Title="Beyoğlu Rapsodisi", AuthorId=3},
            };

            //Author nesnesinden türetilmiş liste oluşturuluyor.
            List<Author> authorList = new List<Author>()
            {
                new Author { AuthorId=1, Name="Orhan Pamuk"},
                new Author { AuthorId=2,Name="Elif Şafak"},
                new Author { AuthorId=3,Name="Ahmet Ümit"},
                
            };

            //iki liste join metodu ile birleştiriliyor.
            var bookJoin = bookList.Join(authorList, book => book.AuthorId, author => author.AuthorId,
                                      (book, author) => new
                                          {
                                             Title=book.Title,
                                             AuthorName=author.Name,
                                             AuthorId=author.AuthorId,
                                          }
                                      );



            Console.WriteLine("{0,-20} {1,5}\n", "Kitap", "Yazarı" ,"Id");

            foreach (var book in bookJoin)
            {
                //Format  ile çıktı iki sütunlu tablo olarak oluşturuldu..
                Console.WriteLine(String.Format("{0,-20} {1,5} ", book.Title,book.AuthorName,book.AuthorId));

            }



        }
    }
}
