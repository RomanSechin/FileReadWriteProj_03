//Objectives: 
//•  When the program starts, ask the user to enter their name. 
//•  By default, the player starts with a score of 0. 
//•  Add 1 point to their score for every keypress they make. 
//•  Display the player’s updated score after each keypress. 
//•  When the player presses the Enter key, end the game. Hint: the following code reads a keypress and 
//checks whether it was the Enter key: Console.ReadKey().Key == ConsoleKey.Enter 
//•  When the player presses Enter, save their score in a file. Hint: Consider saving this to a file named 
//[username].txt. For this challenge, you can assume the user doesn’t enter a name that would produce 
//an illegal file name (such as *). 
//•  When a user enters a name at the start, if they already have a previously saved score, start with that 
//score instead. Objectives: 
//•  When the program starts, ask the user to enter their name. 
//•  By default, the player starts with a score of 0. 
//•  Add 1 point to their score for every keypress they make. 
//•  Display the player’s updated score after each keypress. 
//•  When the player presses the Enter key, end the game. Hint: the following code reads a keypress and 
//checks whether it was the Enter key: Console.ReadKey().Key == ConsoleKey.Enter 
//•  When the player presses Enter, save their score in a file. Hint: Consider saving this to a file named 
//[username].txt. For this challenge, you can assume the user doesn’t enter a name that would produce 
//an illegal file name (such as *). 
//•  When a user enters a name at the start, if they already have a previously saved score, start with that 
//score instead. 
internal class Program
{
  private static string AskName() 
  {
    Console.WriteLine("Enter your name:");
    string name = ""; 
    while(name.Length == 0)
      name = Console.ReadLine();
    return name;
  }
  private static void Main(string[] args)
  {
    String name = AskName();
    int score = 0;

    Console.WriteLine("Enter any keys, <Enter> is exit");

    if (File.Exists(name + ".txt")) 
    {
      if (Int32.TryParse(File.ReadAllText(name + ".txt").Trim(), out score) == false) 
      {
         Console.WriteLine($"Can't parse score from file {name}.txt");
      }      
    }
    Console.WriteLine($"Your score is {score}");
    while (Console.ReadKey().Key != ConsoleKey.Enter) 
    {
      ++score;
      Console.WriteLine($"\t{ name } has score:{ score }");
    }
    File.WriteAllText(name + ".txt", score.ToString());
  }
}