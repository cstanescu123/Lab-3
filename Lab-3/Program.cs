// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hi user! Can you please enter your name?");

string userName = Console.ReadLine();

{
    string yesOrNo = "n";

    do
    {
        {
            Console.WriteLine($"Hi {userName}! Can you please enter a number between 1 and 100?");

            {
                int inputNumber = int.Parse(Console.ReadLine());

                int x = inputNumber;

                bool isOdd = x % 2 != 0;

                if (x > 100 || x < 1)
                    Console.WriteLine($"{userName}, that is not a number between 1 and 100."); 
                else if (isOdd && x < 60)
                    Console.WriteLine($"{userName}, {inputNumber} is odd.");
                else if (!isOdd && x >= 2 && x <= 25)
                    Console.WriteLine($"{userName}, {inputNumber} is even and less than 25.");
                else if (!isOdd && x >= 26 && x <= 60)
                    Console.WriteLine($"{userName}, {inputNumber} is even.");
                else if (!isOdd && x > 60)
                    Console.WriteLine($"{userName}, {inputNumber} is even.");
                else if (isOdd && x > 60)
                    Console.WriteLine($"{userName}, {inputNumber} is odd.");
                
               
            }
        }
        Console.WriteLine("Would you like to try another number? (y/n)");
        yesOrNo = Console.ReadLine().ToLower();
    } while (yesOrNo == "y");
}








