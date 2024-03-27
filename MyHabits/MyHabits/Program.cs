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
        user.AddRating(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Wyjątek: {ex.Message}");
        Console.WriteLine();
    }
}