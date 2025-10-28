List<int> integers = new List<int> { 1, 2, 3, 4, 5, 6 };

// First LINQ variation
var evens = from n in integers
            where n % 2 == 0
            select n;

var odds = integers
              .Where(n => n % 2 == 1);

Console.WriteLine("Here are all even numbers for 'evens'");
foreach (int number in evens)
{
  Console.WriteLine(number);
}
Console.WriteLine("Here are all odd numbers for 'odds");
foreach (int number in odds)
{
  Console.WriteLine(number);
}
