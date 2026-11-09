Console.WriteLine("This is a demo of Github");

Movie movie1 = new("Lost Highway", "David Lynch", 1997, 120);
Movie movie2 = new("Ted", "Seth MacFarlane", 2012, 110);
Console.WriteLine(movie1.ToString());
Console.WriteLine(movie2.ToString());

movie1.Watch();
movie1.RateMovie(8.9);
movie1.Watch();

movie2.Watch();
movie2.RateMovie(5.2);

Console.WriteLine(movie1.ToString());
Console.WriteLine(movie2.ToString());

MovieRepository movieRepo = new MovieRepository();
movieRepo.Add(movie1);
movieRepo.Add(movie2);

Movie? foundMovie = movieRepo.Search(3);
if (foundMovie == null)
{
    Console.WriteLine("Movie not found");
}
else { Console.WriteLine(foundMovie.ToString()); }

movieRepo.Delete(2);

movieRepo.PrintAll();
