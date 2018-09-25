using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace CodeFirstDemo
{
    public class LibraryContext:DbContext
    {
        public LibraryContext():base("MyFuckingLibraryDB")
        {
            //инициализаторы для режима работы entity  - создает БД если её нет
            //Database.SetInitializer<LibraryContext>(new DropCreateDatabaseAlways<LibraryContext>());
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books{ get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
