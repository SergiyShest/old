using System;
using System.Data.Entity;

namespace BookStore.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class book : DbContext
    {
        // Your context has been configured to use a 'book' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BookStore.Models.book' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'book' 
        // connection string in the application configuration file.
        public book()
            : base("name=book")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}

namespace BookStore.Models
{
    public class BookContext : DbContext, IBookContext
    {
        public virtual  DbSet<Book> Books { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
    }

  internal interface IBookContext
  {
    DbSet<Book> Books { get; set; }
    DbSet<Purchase> Purchases { get; set; }

  }

  public class Book
    {
        // ID книги
        public int Id { get; set; }
        // название книги
        public string Name { get; set; }
        // автор книги
        public string Author { get; set; }
        // цена
        public int Price { get; set; }
    }
    public class Purchase
    {
        // ID покупки
        public int PurchaseId { get; set; }
        // имя и фамилия покупателя
        public string Person { get; set; }
        // адрес покупателя
        public string Address { get; set; }
        // ID книги
        public int BookId { get; set; }
        // дата покупки
        public DateTime Date { get; set; }
    }
}
