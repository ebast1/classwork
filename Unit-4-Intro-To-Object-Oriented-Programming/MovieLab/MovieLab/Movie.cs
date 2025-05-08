namespace MovieLab;

public class Movie
{
    private string movieTitle;
    private string movieCategory;
    private int movieYear;

    public string MovieTitle
    {
        get { return movieTitle; }
        set { movieTitle = value; }
    }

    public string MovieCategory
    {
        get { return movieCategory; }
        set { movieCategory = value; }
    }

    public int MovieYear
    {
        get { return movieYear; }
        set { movieYear = value; }
    }

    public Movie(string title, string category, int year)
    {
        movieTitle = title;
        movieCategory = category;
        movieYear = year;
    }

    public override string ToString()
    {
        return $"Movie : {movieTitle} - Category : {movieCategory} - Year : {movieYear}";
    }

} // End of Movie class