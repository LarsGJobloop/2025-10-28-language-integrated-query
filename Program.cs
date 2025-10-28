List<int> integers = new List<int> { 1, 2, 3, 4, 5, 6 };

var evens = from n in integers
            where n % 2 == 0
            select n;

Console.WriteLine("Here are all even numbers");
foreach (int number in evens)
{
  Console.WriteLine(number);
}
