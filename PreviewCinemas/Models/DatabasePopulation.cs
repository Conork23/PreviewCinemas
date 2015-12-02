using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PreviewCinemas.Models
{
    class DatabasePopulation : System.Data.Entity.DropCreateDatabaseIfModelChanges<CinemaContext>
    {


        protected override void Seed(CinemaContext context)
            {
                var Movies = new List<Movie>
            {
            new Movie{Title="Hotel Transylvania 2", Length=89, Genra="Family", year=2015, ImageURI="../Images/MovieArt/hotelT.jpg"},
            new Movie{Title="The Hunger Games: Mockingjay Part 2", Length=137, Genra="Action", year=2015, ImageURI="../Images/MovieArt/hunger games.jpg"},
            new Movie{Title="The Intern", Length=121, Genra="Comedy", year=2015, ImageURI="../Images/MovieArt/Intern.jpg"},
            new Movie{Title="The Martian", Length=141, Genra="Sci-Fi", year=2015, ImageURI="../Images/MovieArt/martian.jpg"},
            new Movie{Title="Mississippi Grind", Length=109, Genra="Drama", year=2015, ImageURI="../Images/MovieArt/mississippi.jpg"},
            new Movie{Title="Pan", Length=111, Genra="Family", year=2015, ImageURI="../Images/MovieArt/pan.jpg"},
            new Movie{Title="Paranormal Activity: Ghost Dimension", Length=88, Genra="Horror", year=2015, ImageURI="../Images/MovieArt/paranormal.jpg"},
            new Movie{Title="Spectre", Length=148, Genra="Action", year=2015, ImageURI="../Images/MovieArt/spectre.jpg"},
            new Movie{Title="Star Wars: The Force Awakens", Length=00, Genra="Sci-Fi", year=2015, ImageURI="../Images/MovieArt/starwars.jpg"},
            new Movie{Title="The Last Witch Hunter", Length=106, Genra="Action", year=2015, ImageURI="../Images/MovieArt/witchhunter.jpg"}
            };

                Movies.ForEach(m => context.Movies.Add(m));
                context.SaveChanges();

                var Screens = new List<Screen>
            {
            new Screen{ScreenNumber=1, Seats=300,},
            new Screen{ScreenNumber=2, Seats=200,},
            new Screen{ScreenNumber=3, Seats=150,},
            new Screen{ScreenNumber=4, Seats=175,},
            new Screen{ScreenNumber=5, Seats=225,},
            new Screen{ScreenNumber=6, Seats=90,},
            new Screen{ScreenNumber=7, Seats=145,},
            new Screen{ScreenNumber=8, Seats=190,},
            new Screen{ScreenNumber=9, Seats=250,},
            new Screen{ScreenNumber=10, Seats=115,},

            };
                Screens.ForEach(s => context.Screens.Add(s));
                context.SaveChanges();

                var Showings = new List<Showing>
            {
            new Showing{MovieID=1, ScreenID=1, DateAndTime=new DateTime(2015, 11, 1, 10, 0, 0), Price = 5.0},
            new Showing{MovieID=2, ScreenID=2, DateAndTime=new DateTime(2015, 11, 1, 10, 0, 0), Price = 5.0},
            new Showing{MovieID=3, ScreenID=3, DateAndTime=new DateTime(2015, 11, 1, 10, 0, 0), Price = 5.0},
            new Showing{MovieID=4, ScreenID=4, DateAndTime=new DateTime(2015, 11, 1, 10, 0, 0), Price = 5.0},
            new Showing{MovieID=5, ScreenID=5, DateAndTime=new DateTime(2015, 11, 1, 10, 0, 0), Price = 5.0},
            new Showing{MovieID=6, ScreenID=6, DateAndTime=new DateTime(2015, 11, 1, 10, 0, 0), Price = 5.0},
            new Showing{MovieID=7, ScreenID=7, DateAndTime=new DateTime(2015, 11, 1, 10, 0, 0), Price = 5.0},
            new Showing{MovieID=8, ScreenID=8, DateAndTime=new DateTime(2015, 11, 1, 10, 0, 0), Price = 5.0},
            new Showing{MovieID=9, ScreenID=9, DateAndTime=new DateTime(2015, 11, 1, 10, 0, 0), Price = 5.0},
            new Showing{MovieID=10, ScreenID=10, DateAndTime=new DateTime(2015, 11, 1, 10, 0, 0), Price = 5.0},
            new Showing{MovieID=1, ScreenID=1, DateAndTime=new DateTime(2015, 11, 1, 12, 0, 0), Price = 5.0},
            new Showing{MovieID=2, ScreenID=2, DateAndTime=new DateTime(2015, 11, 1, 13, 0, 0), Price = 5.0},
            new Showing{MovieID=2, ScreenID=2, DateAndTime=new DateTime(2015, 11, 2, 10, 0, 0), Price = 5.0},
            new Showing{MovieID=2, ScreenID=2, DateAndTime=new DateTime(2015, 11, 3, 10, 0, 0), Price = 5.0},
            new Showing{MovieID=2, ScreenID=2, DateAndTime=new DateTime(2015, 11, 2, 13, 0, 0), Price = 5.0},
            new Showing{MovieID=3, ScreenID=3, DateAndTime=new DateTime(2015, 11, 1, 13, 0, 0), Price = 5.0},
            new Showing{MovieID=4, ScreenID=4, DateAndTime=new DateTime(2015, 11, 1, 13, 0, 0), Price = 5.0},
            new Showing{MovieID=5, ScreenID=5, DateAndTime=new DateTime(2015, 11, 1, 12, 30, 0), Price = 5.0},
            new Showing{MovieID=6, ScreenID=6, DateAndTime=new DateTime(2015, 11, 1, 13, 0, 0), Price = 5.0},
            new Showing{MovieID=7, ScreenID=7, DateAndTime=new DateTime(2015, 11, 1, 12, 0, 0), Price = 5.0},
            new Showing{MovieID=8, ScreenID=8, DateAndTime=new DateTime(2015, 11, 1, 12, 30, 0), Price = 5.0},
            new Showing{MovieID=9, ScreenID=9, DateAndTime=new DateTime(2015, 11, 1, 13, 30, 0), Price = 5.0},
            new Showing{MovieID=10, ScreenID=10, DateAndTime=new DateTime(2015, 11, 1, 13, 0, 0), Price = 5.0},
    };
                Showings.ForEach(s => context.Showings.Add(s));
                context.SaveChanges();
            }
        
    }
}
