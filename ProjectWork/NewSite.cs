namespace ProjectWork
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NewSite : DbContext
    {
        // Контекст настроен для использования строки подключения "NewSite" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "ProjectWork.NewSite" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "NewSite" 
        // в файле конфигурации приложения.
        public NewSite()
            : base("name=NewSite")
        {

        }
        public DbSet<News>news { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<Author>authors { get; set; }
        public DbSet<Client> clients { get; set; }


        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}