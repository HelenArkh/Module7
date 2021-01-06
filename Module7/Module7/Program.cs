using System;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new Book[]
  {
    new Book
    {
      Name = "Мастер и Маргарита",
      Author = "М.А. Булгаков"
    },
    new Book
    {
      Name = "Отцы и дети",
      Author = "И.С. Тургенев"
    },
  };
            BookCollection collection = new BookCollection(array);

            Console.ReadKey();

            Book book = collection[1];
            book = collection[-1];
            book = collection[4];

            Console.ReadKey();

            book = collection["Мастер и Маргарита"];

            Console.ReadKey();

        }
    }
}
