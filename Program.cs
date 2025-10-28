List<int> integers = new List<int> { 1, 2, 3, 4, 5, 6 };

List<int> evens = new List<int>();

// Even = Partall / Evens = Flere partall
foreach (int entry in integers)
{
  if (entry % 2 == 0)
  {
    evens.Add(entry);
  }
}

Console.WriteLine("Here are all even numbers");
foreach (int number in evens)
{
  Console.WriteLine(number);
}
