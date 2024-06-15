using Starships.Enumeration;
using Starships.Objects;

Console.WriteLine("Starting...\n");

Console.WriteLine("A sample list of stars:");
List<Star> stars = new List<Star>();
for (int i = 0; i < 10; i++)
{
    stars.Add(new Star(StarType.K));
    Console.WriteLine(stars[i].Name);
}

Console.ReadKey();