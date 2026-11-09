public class MovieRepository
{
    private int _movieCount;
    private Dictionary<int, Movie> _movieList;
    public MovieRepository()
    {
        _movieCount = 0;
        _movieList = new Dictionary<int, Movie>();
    }

    public void Add(Movie movie)
    {
        ++_movieCount;
        _movieList.Add(_movieCount, movie);
    }

    public Movie? Search(int movieNo)
    {
        return _movieList[movieNo];
    }

    public void Delete(int movieNo)
    {
        _movieList.Remove(movieNo);
        --_movieCount;
    }

    public void WatchAll()
    {
        foreach (var movie in _movieList.Values)
        {
            movie.Watch();
        }
    }

    public void PrintAll()
    {
        foreach (var movie in _movieList.Values)
        {
            Console.WriteLine(movie.ToString());
        }
    }
}