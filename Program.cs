List<int> integers = new List<int> { 1, 2, 3, 4, 5, 6 };

// newCollection != List, det er en spørring
var newCollection = integers
                    // Filtrer ut all partall
                    .Where(n => n % 2 == 0)
                    // Multipliser de med 2
                    .Select(n => n * 2)
                    // Så filtrer ut all som er større enn 4
                    .Where(n => n > 4)
                    // Evaluer spørringen
                    .ToList();

integers.Add(14);

Console.WriteLine("The new collection");
foreach (int number in newCollection)
{
  Console.WriteLine(number);
}
