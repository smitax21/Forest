using System;
using Forest.Data.Models.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.Repository
{
    public class ForestInitialiser : 
        System.Data.Entity.DropCreateDatabaseIfModelChanges<ForestContext>
    {
        protected override void Seed(ForestContext context)

        {

            //For creating Genre objects 

            Genre genre1 = new Genre() { Name = "Rock" };

            Genre genre2 = new Genre() { Name = "Pop" };

            Genre genre3 = new Genre() { Name = "Country" };

            context.Genres.Add(genre1);

            context.Genres.Add(genre2);

            context.Genres.Add(genre3);



            //For creating Music objects 

            Music music1 = new Music()

            {

                Title = "Sabbath Bloody Sabbath",

                num_track = 6,

                duration = 60,

                DateReleased = Convert.ToDateTime("12/11/1979"),

                Price = 2.5

            };



            Music music2 = new Music()

            {

                Title = "Sabotage",

                num_track = 6,

                duration = 60,

                DateReleased = Convert.ToDateTime("12/11/1976"),

                Price = 12.5

            };



            Music music3 = new Music()

            {

                Title = "Burn",

                num_track = 6,

                duration = 60,

                DateReleased = Convert.ToDateTime("12/11/1975"),

                Price = 2.5

            };



            Music music4 = new Music()

            {

                Title = "Rumours",

                num_track = 6,

                duration = 60,

                DateReleased = Convert.ToDateTime("12/11/1977"),

                Price = 2.5

            };



            Music music5 = new Music()

            {

                Title = "Caravanserai",

                num_track = 6,

                duration = 60,

                DateReleased = Convert.ToDateTime("12/11/1978"),

                Price = 2.5

            };



            Music music6 = new Music()

            {

                Title = "Abraxes",

                num_track = 6,

                duration = 60,

                DateReleased = Convert.ToDateTime("12/11/1972"),

                Price = 2.5

            };

            context.Musics.Add(music1);

            context.Musics.Add(music2);

            context.Musics.Add(music3);

            context.Musics.Add(music4);

            context.Musics.Add(music5);

            context.Musics.Add(music6);



            //For creating Artist Objects 

            Artist artist1 = new Artist() { Name = "Black Sabbath" };

            Artist artist2 = new Artist() { Name = "Deep Purple" };

            Artist artist3 = new Artist() { Name = "Santana" };

            Artist artist4 = new Artist() { Name = "Fleetwood Mac" };

            context.Artists.Add(artist1);

            context.Artists.Add(artist2);

            context.Artists.Add(artist3);

            context.Artists.Add(artist4);



            //For creating OrderLine Object 

            OrderLine orderLine1 = new OrderLine() { Quantity = 10 };

            OrderLine orderLine2 = new OrderLine() { Quantity = 8 };

            OrderLine orderLine3 = new OrderLine() { Quantity = 18 };

            OrderLine orderLine4 = new OrderLine() { Quantity = 16 };

            context.OrderLines.Add(orderLine1);

            context.OrderLines.Add(orderLine2);

            context.OrderLines.Add(orderLine3);

            context.OrderLines.Add(orderLine4);



            //For creating Order Objects 

            Order order1 = new Order() { created = Convert.ToDateTime("12/11/1978"), DelAddress = "123 Muse Lane" };

            Order order2 = new Order() { created = Convert.ToDateTime("12/11/1978"), DelAddress = "456 Abbet Road" };

            context.Orders.Add(order1);

            context.Orders.Add(order2);



            //For creating User Objects 

            User user1 = new User() { UserID = "mo", Name = "Mo", Email = "mo@mo.com" };

            User user2 = new User() { UserID = "sam", Name = "Sam", Email = "sam@sam.com" };

            User user3 = new User() { UserID = "joe", Name = "Joe", Email = "joe@joe.com" };

            context.Users.Add(user1);

            context.Users.Add(user2);

            context.Users.Add(user3);



            context.SaveChanges();

        }
    }
}
