using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace CodeFirstDemo
{
    class Program
    {

        private static void AddToDBAuthor(List<Author> author)
        {
            //Author author = new Author { FirstName = "Чак", LastName = "Паланик" };
            using (LibraryContext db = new LibraryContext())
            {
                db.Authors.AddRange(author);
                db.SaveChanges();
            }
            ReadKey();
        }
        private static void ShowAuthors()
        {
            using (LibraryContext db = new LibraryContext())
            {
                foreach (var a in db.Authors)
                {
                    WriteLine(a.FirstName + " " + a.LastName);
                }
            }

        }
        static void Main(string[] args)
        {


            Console.WriteLine("Введите к-тво авторов: ");
            int kol = int.Parse(Console.ReadLine());
            List<Author> author = new List<Author>(kol);
            Console.WriteLine("Укажите имена и фамилии этих авторов.");
            for (int i = 0; i <kol; i++)
            {
                Console.WriteLine("Автор:");
                string fullName=ReadLine();
                author.Add(new Author { FirstName = fullName.Split(' ')[0],LastName = fullName.Split(' ')[1] });
            }
            AddToDBAuthor(author);
            ShowAuthors();
        } 
    }
}
