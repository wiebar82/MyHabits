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
    Console.WriteLine("Wybież odpowiednią literę.");

    var input = Console.ReadLine();
    if (input == "w" || input == "W")
    {
        break;
    }
    else if (input == "d" || input == "D")
    {
        Console.WriteLine("Podaj ocenę: ");
        var input2 = Console.ReadLine();
        try
        {
            //if (input2 >= 0 && input2 < 7)
            user.AddRating(input2);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wyjątek: {ex.Message}");
            Console.WriteLine();
        }

        Console.WriteLine("A ile dziś kodowałeś? (Podaj ocenę jako liczbę minut.)");
        var input3 = Console.ReadLine();
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
    
}