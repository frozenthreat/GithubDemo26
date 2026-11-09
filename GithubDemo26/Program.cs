Console.WriteLine("This is a demo of Github");

Movie movie1 = new("Lost Highway", "David Lynch", 1997, 120);
Movie movie2 = new("Ted", "Seth MacFarlane", 2012, 110);
Console.WriteLine(movie1.ToString());
Console.WriteLine(movie2.ToString());

movie1.Watch();
movie1.RateMovie(10);
movie1.Watch();

movie2.Watch();
movie2.RateMovie(5.2);

Console.WriteLine(movie1.ToString());
Console.WriteLine(movie2.ToString());