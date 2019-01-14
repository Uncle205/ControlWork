
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectWork
{
    class Program
    {
        public class Logic
        {
            public NewSite context;

            public Logic(NewSite tex)
            {
                context = tex;
            }
            static void Main(string[] args)
            {
                Authentification();


                Console.WriteLine("1.Create News");
                Console.WriteLine("2.Show News");
                Console.WriteLine("3.ADD News");
                int key = 1;
                switch (key)
                {
                    case 1:
                      

                        CreateNewNews();
                        break;
                    case 2:
                        ShowNews();
                        break;
                    case 3:
                       
                        ADDComment( );
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }

                using (var text = new NewSite())
                {

                    var author = new Author
                    {
                        Id = Guid.NewGuid(),
                        Name = "Alex Popov"

                    };
                    var comment = new Comment
                    {
                        Id = Guid.NewGuid(),
                        Body = "AHAHAHAHHA"
                    };

                    var news = new News
                    {
                        Id = Guid.NewGuid(),
                        AuthorId = author.Id,
                        Text = "Abraham Linkoln Alive",
                        CommentId = comment.Id

                    };
                    text.authors.Add(author);
                    text.comments.Add(comment);
                    text.news.Add(news);
                }

            }
            public static void Authentification()
            {
                NewSite context = new NewSite();
                Console.WriteLine("Enter name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter second name");
                string surname = Console.ReadLine();
                if (context.clients.Any(user => user.FirstName == name) && context.clients.Any(user => user.LastName == surname))
                {
                    Console.WriteLine("everything okey");
                }
                else
                {
                    Console.WriteLine("not clear");
                    Authentification();
                }
            }
            public static void CreateNewNews()
            {
                NewSite context = new NewSite();

                Console.WriteLine("Enter Author name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter News");
                string text = Console.ReadLine();
                Console.WriteLine("Enter Comment");
                string commeent = Console.ReadLine();
                var author = new Author
                {
                    Id = Guid.NewGuid(),
                    Name = name

                };
                var comment = new Comment
                {
                    Id = Guid.NewGuid(),
                    Body = commeent
                };

                var news = new News
                {

                    Id = Guid.NewGuid(),
                    AuthorId = author.Id,
                    Text = text,

                };
                context.authors.Add(author);
                context.comments.Add(comment);
                context.news.Add(news);
                context.SaveChanges();


            }
            public static void ADDComment(Client client)
            {
                using (var context = new NewSite())
                {
                    Console.WriteLine("Enter new's Id ");
                    int ArticleId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter your name");
                    string Name = Console.ReadLine();

                    Console.WriteLine("TAP YOUR TEXT");
                    string text = Console.ReadLine();
                    Comment comment = new Comment();
                    comment.Name = client.FirstName;
                    comment.Text = text;
                    List<News> newsList = context.news.ToList();
                    context.news.Add(comment);
                    context.SaveChanges();

                }
            }
            public void ShowNews()
            {
                List<News> newsList = context.news.ToList();

                for (int i = 0; i < newsList.Count; i++)
                {
                    Console.WriteLine("ID: " + newsList[i].Id);
                    Console.WriteLine("Автор: " + newsList[i].AuthirName.FirstName);
                    Console.WriteLine("Заголовок: " + newsList[i].Text);
                    Console.WriteLine("Комментарии:");
                    for (int k = 0; k < newsList[i].Comment.Count; k++)
                    {
                        Console.WriteLine(newsList[i].Comment[k].Name);
                        Console.WriteLine(newsList[i].Comment[k].Text);
                        Console.WriteLine();
                    }

                    Console.WriteLine();
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine();
                }
            }
        }
    }
}
    
    


// using (var text=new NewSite())
//            {
//                Console.WriteLine("Enter author name");
//                string name = Console.ReadLine();
//var author = new Author
//{
//    Id = Guid.NewGuid(),
//    Name = name

//};