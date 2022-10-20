// Jasmine Leek
// 20oct2022
// Mini Challenge #7 "Reverse it"
// This is a program that takes a sequence of numbers or letters and reverses them

Console.Clear();
bool playAgain = true;

while (playAgain)
{
    Console.Write("Enter any number, word, or phrase to reverse it: ");
    string originalInput = Console.ReadLine();
    string reverseInput = string.Empty;
    for (int i = originalInput.Length - 1; i >= 0; i--)
    {
        reverseInput += originalInput[i];
    }

    Console.WriteLine("\nVoila!\n");
    Console.Write($"{originalInput} | {reverseInput} \n");
    Console.Write("\nWant to play again?\n \nEnter any key to restart or type 'end' to quit: \n");

    string ready = Console.ReadLine();
    if (ready == "end")
    {
        playAgain = false;
    }
}