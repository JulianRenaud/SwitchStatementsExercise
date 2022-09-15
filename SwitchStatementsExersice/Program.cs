using System.Net.Mail;

Console.WriteLine("What is your favorite school subject?");

var subject = Console.ReadLine();
switch (subject)
{
    case "Math":
        Console.WriteLine("Math can be challenging sometimes!");
        break;
    case "Science":
        Console.WriteLine("Science is a tough subject!");
        break;
    case "English":
            Console.WriteLine("English is very interesting!");
        break;
    default:
            Console.WriteLine($"{subject} is very fun and can be a challenge sometimes!");
        break;
}