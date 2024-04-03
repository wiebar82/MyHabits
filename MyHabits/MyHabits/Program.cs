// See https://aka.ms/new-console-template for more information
using MyHabits;

Console.WriteLine("Welcome in MyHabits aplication!");
Console.WriteLine();

var user = new UserRatingInFile("Bartek", "Wieczorek");
user.RatingAdd += UserRatingAdded;
void UserRatingAdded(object sender, EventArgs e)
{
    Console.WriteLine("Dodano nową ocenę dla "+ user.UserName + " " + user.UserLast);
    Console.WriteLine();
}

Console.WriteLine();

while (true)
{
    Console.WriteLine("Podaj ocenę: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
      //  if (input >= 0 && input < 7)
        user.AddRating(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Wyjątek: {ex.Message}");
        Console.WriteLine();
    }

    Console.WriteLine("A ile dziś kodowałeś? (Podaj ocenę jako liczbę minut.)");
    var input2 = Console.ReadLine();
    if (input2 == "q") 
    {
        break;
    }
    try
    {
        int timeInput = Int32.Parse(input2);
        user.AddTimeRating(timeInput);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Wyjątek: {ex.Message}");
        Console.WriteLine();
    }
}