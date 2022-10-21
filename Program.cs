//Valerie Aguilar
//October 21, 2022

int num1;
int num2;
string input1 = "";
string input2 = "";
bool playAgain = true;
bool valid = true;




while (playAgain)
{
    Console.WriteLine("Let's play a game where I add two numbers for you. Type in your first number.");
    valid = int.TryParse(Console.ReadLine(), out num1);

    if (valid)
    {
        Console.WriteLine("Type in a second number.");
        valid = int.TryParse(Console.ReadLine(), out num2);

        Console.WriteLine($"Your numbers added together equals {num1 + num2}");

        Console.WriteLine("Would you like to play again? Type Y for yes, or Type N for No.");
        Console.ReadLine().ToUpper();

        if (Console.ReadLine().ToUpper() != "Y")
        {
            playAgain = false;
        }
    }

    else
    {
        Console.WriteLine("Please type in a whole number");
    }

}

Console.WriteLine("Thank you for playing.");