using System;

namespace DIO.Series
{
    class Program
    {
        static MovieRepository movieRepository = new MovieRepository();
        static void Main(string[] args)
        {
            string userOption = GetUserOption();
            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        ListMovies();
                        break;
                    case "2":
                        InsertMovie();
                        break;
                    case "3":
                        UpdateMovie();
                        break;
                    case "4":
                        RemoveMovie();
                        break;
                    case "5":
                        ShowMovieDetails();
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    default:
                        //throw new ArgumentOutOfRangeException();
                        Console.WriteLine("Sorry, this option is invalid!\nChoose another one!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                userOption = GetUserOption();
            }
            Console.WriteLine("Thank you for using our services!");
            Console.WriteLine();
        }
        private static String GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("*** DIO Movies ***");
            Console.WriteLine("Select one option: ");

            Console.WriteLine("1 - List movies");
            Console.WriteLine("2 - Insert a new movie");
            Console.WriteLine("3 - Update a movie");
            Console.WriteLine("4 - Remove a movie");
            Console.WriteLine("5 - Show movie details");
            Console.WriteLine("6 - Clear screen");
            Console.WriteLine("X - Exit");

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;
        }
        private static void ListMovies()
        {
            Console.WriteLine("*** List of Series ***");
            var moviesList = movieRepository.List();

            if (moviesList.Count == 0)
            {
                Console.WriteLine("Sorry, there is no movie yet!");
                return;
            }

            foreach (var movie in moviesList)
            {
                var removed = movie.IsRemoved();
                Console.WriteLine("#ID {0} - {1} {2}", movie.returnId(), movie.returnTitle(), (removed ? "*Removed*" : ""));
            }
        }
        private static void InsertMovie()
        {
            Console.WriteLine("Insert a new movie");
            //https://docs.microsoft.com/en-us/dotnet/api/system.enum.getvalues?view=net-5.0
            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                //https://docs.microsoft.com/en-us/dotnet/api/system.enum.getname?view=net-5.0
                //https://www.educba.com/enum-in-c-sharp/
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));
            }
            Console.WriteLine("Choose the genre according to the options bellow: ");
            int inputGenre = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the movie title: ");
            string inputTitle = Console.ReadLine();

            Console.WriteLine("Choose the year of the movie: ");
            int inputYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the movie description: ");
            string inputDescription = Console.ReadLine();

            Movie newMovie = new Movie(id: movieRepository.NextId(),
            genre: (Genre)inputGenre,
            title: inputTitle,
            realeaseYear: inputYear,
            description: inputDescription);

            movieRepository.Insert(newMovie);

        }
        private static void UpdateMovie()
        {
            //TO DO: It is the same menu from other methods
            Console.Write("Type the movie ID:  ");
            int inputIdMovie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genre), i));
            }

            Console.WriteLine("Choose the genre according to the options bellow: ");
            int inputGenre = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the movie title: ");
            string inputTitle = Console.ReadLine();

            Console.WriteLine("Choose the year of the movie: ");
            int inputYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the movie description: ");
            string inputDescription = Console.ReadLine();

            Movie movie = new Movie(id: inputIdMovie,
            genre: (Genre)inputGenre,
            title: inputTitle,
            realeaseYear: inputYear,
            description: inputDescription);

            movieRepository.Update(inputIdMovie, movie);
        }

        private static void RemoveMovie()
        {
            //TO DO: Confirmation message
            Console.Write("Type the movie ID:  ");
            int inputIdMovie = int.Parse(Console.ReadLine());

            movieRepository.Delete(inputIdMovie);
        }

        private static void ShowMovieDetails()
        {
            Console.Write("Type the movie ID:  ");
            int inputIdMovie = int.Parse(Console.ReadLine());

            var movie = movieRepository.ReturnById(inputIdMovie);

            //The method to String will run
            Console.WriteLine(movie);
        }

    }
}