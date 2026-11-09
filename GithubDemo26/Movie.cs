public class Movie
{
    public string Title { get; set; }
    public string Director { get; set; }
    public int Year { get; set; }
    public int Length { get; set; }
    public double Rating { get; set; }
    public int WatchCount { get; private set; }
    
    public Movie(string title, string director, int year, int length)
    {
        Rating = 0.0;
        WatchCount = 0;
        Title = title;
        Director = director;
        Year = year;
        Length = length;
    }

    public void RateMovie(double rating)
    {
        Rating = rating;
    }

    public void Watch()
    {
        WatchCount++;
    }

    public override string ToString()
    {
        return $"The movie is {Title}, directed by {Director} and released in {Year}.\nIt is {Length} minutes long, and holds a rating of {Rating}.\nYou have watched it {WatchCount} times.\n";
    }
}