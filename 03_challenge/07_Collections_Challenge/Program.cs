using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Challenge
{
    class Program
    {
        static User newUser = new User();

        List<string> newMovie = new List<string>();
        List<string> newTV = new List<string>();
             
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the Movie Hub\n" +
                "Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Would you like to register a (1) Movie or (2) TV show? 1 or 2, 3 exits.");
            string input = Console.ReadLine();
            bool addingShows = true;
            while (addingShows)
            {
                switch (input)
                {
                    case "1":
                        Movie();
                        break;

                    case "2":
                        TV();
                        break;

                    case "3":
                        addingShows = false;
                        break;

                    default:
                        Console.WriteLine("Nah dude");
                        break;
                }

                while (addingShows)
                {
                    Console.WriteLine("Do you want to add another show or review list (4 = movie) (5 = TV)?");
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            Movie();
                            break;

                        case "2":
                            TV();
                            break;
                        case "3":
                            addingShows = false;
                            break;
                        case "4":
                            foreach (Movies newMovie in newUser.MovieList) 
                            Console.WriteLine(newMovie.MovieName + newMovie.MovieRating + newMovie.Genre);
                            break;
                        case "5":
                            foreach (TV newTV in newUser.TVList ) 
                            Console.WriteLine(newTV.TVName + newTV.TVRating + newTV.TVGenre);
                            break;
                        default:
                            Console.WriteLine("Oh no, bb, what is you doin?");
                                break;
                    }
                }
                
             }
            
        }

        static void Register()
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("How old are you? ");
            int age = GetIntput();

            //newUser = new User(firstName, lastName, age, movieList, tvList);
            Console.WriteLine($"Welcome {firstName} {lastName}, welcome, indeed!");
        }

        static int GetIntput()
        {
            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);
            return input;
        }

        static void Movie()
        {
            Console.WriteLine("Movie: ");
            string movieName = Console.ReadLine();

            Console.WriteLine("Rating: ");
            int movieRating = int.Parse(Console.ReadLine());

            Console.WriteLine("Genre: ");
            string genre = Console.ReadLine(); //pass all 3 variables into one instance of 'movie'

            Movies newMovie = new Movies(movieName, movieRating, genre); //pass the variables into the new 'movie' object
            var myList = newUser.MovieList;
            myList.Add(newMovie);

        }

        static void TV()
        {
            
            Console.WriteLine("TV Show: ");
            string tvName = Console.ReadLine();

            Console.WriteLine("Rating: ");
            int tvRating = int.Parse(Console.ReadLine());

            Console.WriteLine("Genre: ");
            string tvGenre = Console.ReadLine(); //pass all 3 variables into one instance of 'movie'

            TV newTV = new TV(tvName, tvRating, tvGenre); //pass the variables into the new 'tv' object
            var myList = newUser.TVList; //THIS ADDS IT TO THE LIST !!! SUPER IMPORTANT STEP!!
            myList.Add(newTV);
        }
    }
    
}
