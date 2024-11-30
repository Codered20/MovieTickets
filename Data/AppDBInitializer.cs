using MovieTickets.Data.Enums;
using MovieTickets.Models;

namespace MovieTickets.Data
{
    public class AppDBInitializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();
                context.Database.EnsureCreated();

                // Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema() {
                            Name = "PVR Crown Plaza",
                            Logo = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Crown.jpg",
                            Description = "Step into the enchanting world of cinemas, where storytelling comes to life on the big screen. Enjoy the latest blockbusters and timeless classics in state-of-the-art theaters, featuring high-definition visuals and immersive sound."
                        },
                        new Cinema() {
                            Name = "PVR Pebble",
                            Logo = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Pebble Cinema.jpg",
                            Description = "Indulge in delicious snacks and comfortable seating for the ultimate movie experience."
                        },
                        new Cinema() {
                            Name = "SRS Cinemas",
                            Logo = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\SRS Logo.png",
                            Description = "Whether it's a family outing or a date night, our cinemas offer something for everyone. Join us for an unforgettable cinematic journey—grab your tickets and dive into a world of adventure today!"
                        },
                        new Cinema() {
                            Name = "Inox EF3 Cinema",
                            Logo = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Inox Logo.png",
                            Description = "With cutting-edge sound and visuals, every screening becomes a captivating experience. Treat yourself to a range of snacks and beverages, making your visit even more enjoyable."
                        },
                        new Cinema() {
                            Name = "Miraj Cinemas",
                            Logo = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Miraj Logo.jpg",
                            Description = "Discover the excitement of cinema, where every film transports you to new worlds. Enjoy a curated selection of the latest releases and timeless classics in comfortable, modern theaters."
                        }
                    });
                    context.SaveChanges();

                }

                // Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer
                        {
                            FullName = "Karan Johar",
                            Bio = "A prominent film producer and director known for his blockbuster films and contributions to Bollywood.",
                            ProfilePicURL = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Karan Johar.jpg"
                        },
                        new Producer
                        {
                            FullName = "Aditya Chopra",
                            Bio = "The head of Yash Raj Films, he is known for producing iconic romantic films in Indian cinema.",
                            ProfilePicURL = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Aditya Chopra.jpg"
                        },
                        new Producer
                        {
                            FullName = "Ritesh Sidhwani",
                            Bio = "A well-known producer known for his work in films like 'Dil Chahta Hai' and 'Zindagi Na Milegi Dobara'.",
                            ProfilePicURL = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Ritesh Sidhwani.jpg"
                        },
                        new Producer
                        {
                            FullName = "Sajid Nadiadwala",
                            Bio = "An influential producer and director recognized for his successful commercial films.",
                            ProfilePicURL = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Sajid Nadiadwala.jpg"
                        },
                        new Producer
                        {
                            FullName = "Ekta Kapoor",
                            Bio = "A leading producer in Indian television and cinema, known for her popular soap operas and films.",
                            ProfilePicURL = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Ekta Kapoor.jpg"
                        }
                    });
                    context.SaveChanges();
                }

                // Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor
                        {
                            FullName = "Akshay Kumar",
                            Bio = "A versatile actor known for his roles in action, comedy, and drama films.",
                            ProfilePicURL = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Akshay Kumar.jpg"
                        },
                        new Actor
                        {
                            FullName = "Salman Khan",
                            Bio = "A popular Bollywood actor known for his charismatic personality and blockbuster hits.",
                            ProfilePicURL = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Salman Khan.jpg"
                        },
                        new Actor
                        {
                            FullName = "Katrina Kaif",
                            Bio = "An acclaimed actoress known for her versatile performances in both comedy and serious roles.",
                            ProfilePicURL = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Katrina Kaif.jpg"
                        },
                        new Actor
                        {
                            FullName = "Shahrukh Khan",
                            Bio = "Known as the 'King of Bollywood', he is famous for his romantic roles and immense popularity.",
                            ProfilePicURL = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Shahrukh Khan.jpg"
                        },
                        new Actor
                        {
                            FullName = "Madhuri Dixit",
                            Bio = "A legendary actress celebrated for her dancing skills and performances in iconic films.",
                            ProfilePicURL = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Madhuri Dixit.jpg"
                        }
                    });
                    context.SaveChanges();
                }

                // Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie
                        {
                            Name = "Kal Ho Na Ho",
                            Description = "A heartwarming story about love, friendship, and the value of time, set in the bustling city of New York.",
                            Price = 200.00,
                            ImageUrl = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Kal Ho.jpg", // Replace with actual image URL
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(24),
                            CinemaId = 1,
                            ProducerId = 3, // Assuming producer ID for Karan Johar
                            MovieCategory = movieCategory.documentary
                        },
                        new Movie
                        {
                            Name = "Chak De! India",
                            Description = "An inspiring sports drama where a former hockey player coaches an underdog women’s hockey team to success.",
                            Price = 180.00,
                            ImageUrl = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Chak De.jpg",
                            StartDate = DateTime.Now.AddDays(-20),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 2,
                            ProducerId = 2, // Assuming producer ID for Karan Johar
                            MovieCategory = movieCategory.thriller
                        },
                        new Movie
                        {
                            Name = "Gold",
                            Description = "A patriotic sports drama about India’s first Olympic gold medal victory as a free nation in hockey.",
                            Price = 150.00,
                            ImageUrl = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Gold.jpg",
                            StartDate = DateTime.Now.AddDays(-1),
                            EndDate = DateTime.Now.AddDays(30),
                            CinemaId = 3,
                            ProducerId = 3, // Assuming producer ID for Karan Johar
                            MovieCategory = movieCategory.comedy
                        },
                        new Movie
                        {
                            Name = "Housefull",
                            Description = "A comedy of errors that follows the chaotic and humorous situations that arise when a group of friends attend a wedding.",
                            Price = 100.00,
                            ImageUrl = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Housefull.jpg",
                            StartDate = DateTime.Now.AddDays(-5),
                            EndDate = DateTime.Now.AddDays(23),
                            CinemaId = 4,
                            ProducerId = 4, // Assuming producer ID for Karan Johar
                            MovieCategory = movieCategory.sci_fi
                        },
                        new Movie
                        {
                            Name = "Once Upon ay Time in Mumbai Dobaara!",
                            Description = "A gripping tale of underworld power, betrayal, and romance in Mumbai’s criminal world.",
                            Price = 130.00,
                            ImageUrl = "C:\\Users\\anuj.bg.kumar\\source\\repos\\MovieTickets\\Data\\Images\\Once Upon.jpg",
                            StartDate = DateTime.Now.AddDays(-2),
                            EndDate = DateTime.Now.AddDays(40),
                            CinemaId = 5,
                            ProducerId = 5, // Assuming producer ID for Karan Johar
                            MovieCategory = movieCategory.Romance
                        }
                    });
                    context.SaveChanges();
                }

                // Actor_Movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>() {
                        new Actor_Movie {
                            ActorId = 2,
                            MovieId = 1
                        },
                        new Actor_Movie {
                            ActorId = 4,
                            MovieId = 2
                        },
                        new Actor_Movie {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie {
                            ActorId = 1,
                            MovieId = 4
                        },
                        new Actor_Movie {
                            ActorId = 5,
                            MovieId = 5
                        },
                        new Actor_Movie {
                            ActorId = 3,
                            MovieId = 3
                        }
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
