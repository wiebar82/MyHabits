// See https://aka.ms/new-console-template for more information
using MyHabits;

Console.WriteLine("Witaj w programie MyHabits!");
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
    Console.WriteLine("Co chcesz zrobić: ");
    Console.WriteLine("[D]odaj ocenę.");
    Console.WriteLine("[P]okaż statystyki");
    Console.WriteLine("[W]yjście]");
    Console.WriteLine();
    Console.WriteLine("Wybież opcje.");

    var input = Console.ReadLine();
    if (input == "w" || input == "W")
    {
        break;
    }
    else if (input == "d" || input == "D")
    {
        Console.WriteLine("Podaj ocenę: ");
        input = Console.ReadLine();
        try
        {
            user.AddRating(input);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wyjątek: {ex.Message}");
            Console.WriteLine();
        }

        Console.WriteLine("A ile dziś kodowałeś? (Podaj ocenę jako liczbę minut.)");
        input = Console.ReadLine();
     
        try
        {
            int timeInput = Int32.Parse(input);
            user.AddTimeRating(timeInput);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wyjątek: {ex.Message}");
            Console.WriteLine();
        }
    }
    
}