
Console.Title = "=====Lucky number Game =====";
Console.WriteLine("you only have 5 chance to guess the number correctly");

// int noOfAttempt = int.Parse(Console.ReadLine()!);

Random rand = new();

try
{
  


int randomNO = rand.Next(1,50);
int noOfAttempt = 5;

for (int i = 1; i <= noOfAttempt; i++)
{
  Console.WriteLine($"input Guess number {i}: enter your guess between 1 - 50");
  int userGuessNo = int.Parse(Console.ReadLine()!);

if(noOfAttempt <= 1)
{
  Console.WriteLine("this is your first attempt");
}


  if (userGuessNo == randomNO)
  {
  Console.WriteLine("you guess a correct number \n ohh!! Congratulation you won a toyotal car");
 break;
  }
    else if(userGuessNo < randomNO)
  {
    Console.WriteLine("you guess a lower number");
    
  }
  else
  {
    Console.WriteLine(" you guess a higher  number");
  }
if(i == noOfAttempt )
{
  
  Console.WriteLine("you lose \nyou have reach your limited attemt\n please try again..");
}
}
}catch (System.Exception ex)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("Error:{0}", ex.Message);
 Console.ResetColor(); 
 
}
// void printMultiplicationTable(int number,int times)
// {
//   for (int i = 1; i <= times; i++)
//   {
//     Console.WriteLine($"{number}*{times}={number * times}");
//   }
// }
// Console.WriteLine("Enter number");
// int number = int.Parse(Console.ReadLine()!);

// Console.WriteLine("number of times");
// int times =  int.Parse(Console.ReadLine()!);







