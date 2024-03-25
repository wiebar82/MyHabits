// See https://aka.ms/new-console-template for more information
using MyHabits;

Console.WriteLine("Welcome in MyHabits aplication!");
Console.WriteLine();

var user = new UserRatingInFile("Bartek", "Wieczorek");

Console.WriteLine(user.UserName + " " + user.UserLast);
