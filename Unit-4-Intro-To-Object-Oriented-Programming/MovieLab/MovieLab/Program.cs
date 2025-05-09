namespace MovieLab;

class Program
{
    /*
     *      MovieLab
     *  - stores a list of 10 movies and displays them by category
     *  - user can enter any of the following categories to display the films in the list that match the category
     *  - after the list is displayed, the user is asked if he or she wants to continue, if no the program ends
     *
     *      Overview
     *  - List that holds a list of movies
     *  - Function that shows the user what movies are in the list
     *  - Function that asks the user what category of movies they would like to see
     *  - Function that asks the user if they would like to continue and stops the program if no
     *
     */

    // List of movies
    static List<Movie> moviesList = new List<Movie>
    {
        new Movie("12 Angry Men", "Drama", 1957),
        new Movie("Amelie", "Romance", 2001),
        new Movie("I Saw the TV Glow", "Drama", 2024),
        new Movie("Call Me by Your Name", "Romance", 2017),
        new Movie("Blade Runner 2049", "Drama", 2017),
        new Movie("Easy A", "Comedy", 2010),
        new Movie("The Nanny Diaries", "Comedy", 2007),
        new Movie("Sky High", "Comedy", 2005),
        new Movie("SuperBad", "Comedy", 2007),
        new Movie("Before Sunrise", "Romance", 1995),
        new Movie("Two Weeks Notice", "Comedy", 2002),
        new Movie("Blade", "Action", 1998),
        new Movie("Predator", "Action", 1987),
        new Movie("The Intern", "Comedy", 2015)
    };
    
    static List<string> categoryList = new List<string>();
    static string userInput;
    
    /*****************************
            Helper Methods
    *****************************/
    
    static void showList()
    {
        Console.WriteLine("**************");
        Console.WriteLine(    "Movies"    );
        Console.WriteLine("**************");
        
        Console.WriteLine("\n");
        foreach (var movie in moviesList)
        {
            Console.WriteLine(movie.ToString());
        }
        Console.WriteLine("\n");        
    }

    static void showCategories()
    {
        // should show categories available to see after asking
        
        // would you like to see the categories?
        // user: y
        // lists categories avail in the movie list
        
        // - a way to ask the user
        // - a way to check what categories are in the list of movies
        // - a way to display only the categories
        // - a way to ask the user what category they want to see
        // - a way to display only the movies associated with that genre/category
        
        // I need to loop through the moviesList and add the category if it has not been added before

        foreach (var movie in moviesList)
        {
            if (!categoryList.Contains(movie.MovieCategory))
            {
                categoryList.Add(movie.MovieCategory);
            }

            if (categoryList.Contains(movie.MovieCategory))
            {
                continue;
            }
        }
        
        Console.WriteLine("***** Categories *****");
        foreach (var category in categoryList)
        {
            Console.WriteLine(category);
        }
        Console.WriteLine("**********************");
        
    } // End of showCategories()
    
    static void showMovies()
    {
        // this will take the userInput of what category they select and only display the movies that have that genre/category
        bool validInput = false;
        string userInput = "";
        
        do
        {
            Console.WriteLine("What category of movies would you like to view?");
            userInput = Console.ReadLine();

            if (categoryList.Contains(userInput))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid category");
                validInput = false;
            }
            
        } while (!validInput);

            
        foreach (var movie in moviesList) // going through the list
        {
                // a way to go through the list
                // check the entered category
                // IF the entered category is in category list and is a valid input
                // show the movies from the list that match the input

            if (categoryList.Contains(userInput)) 
            {
                if (movie.MovieCategory == userInput)
                {
                    Console.WriteLine("----");
                    Console.WriteLine($"Title: {movie.MovieTitle}\nGenre: {movie.MovieCategory}\nYear Released: {movie.MovieYear}");
                }
            }
        }
        
    } // End of showMovies()

    /*****************************/
    
    static void Main(string[] args)
    {
        Console.WriteLine("--- Starting MovieLab ---");

        do
        {
            showList();
            showCategories();
            showMovies();

            Console.WriteLine("Would you like to continue looking at the movies? (Y/N)");
            userInput = Console.ReadLine().ToUpper();
            
        } while (userInput == "Y");

        Console.WriteLine("--- Ending MovieLab ---");
        
    } // End of Main()
    
} // End of Program class