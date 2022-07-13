// See https://aka.ms/new-console-template for more information


// pick a numb between 1 and 100

//type     variable name        Classes need to be instantiated with the 'new' keyword
Random randomNumberGenerator = new Random();

int random_number = randomNumberGenerator.Next(1, 101);

Console.Write("Pick a number between 1 and 100: ");
string input = Console.ReadLine();
int inputAsInt = int.Parse(input);

bool correctGuess = false;

if(random_number == inputAsInt)
{
    correctGuess = true;
}

//string correctResponse = $"That's right, the number I was thinking of was {random_number}!";
//string incorrectResponse = $"Wow, you're bad at this, I was thinking of {random_number} but you guessed {input}. ";

//ternary

string responseText = correctGuess ?
    $"That's right, the number I was thinking of was {random_number}!" :
    $"Wow, you're bad at this, I was thinking of {random_number} but you guessed {input}. ";

Console.WriteLine(responseText);

//if (correctGuess)
//{
  //  Console.WriteLine(correctResponse);
//}
//else
//{
  //  Console.WriteLine(incorrectResponse);
//}



Console.ReadLine();
