// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Enter a weekday number: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("(Hooray weekend!)");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("It's not a weekday...");
  }
  else Console.WriteLine("(Keep working baby)");
}

CheckingTheDayOfTheWeek(dayNumber);