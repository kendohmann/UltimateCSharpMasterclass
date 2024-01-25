using System.Security.Cryptography.X509Certificates;
using Game;
using Microsoft.VisualBasic;

public class GuessingGame
{
    private readonly Die _die;
    private const int TriesCount = 3;
    private int tries;

    public GuessingGame()
    {
        _die = new Die();
        tries = 0;
    }
    public void Play()
    {
        var diceRoll = _die.rollDie();
        Console.WriteLine($"Dice rolled. Guess what number it shows in {TriesCount} tries.");
        int guess;
        bool repeat;

        do
        {
            Console.WriteLine("Enter number:");
            guess = ConsoleReader.ReadIntegerRange(1, TriesCount);
            repeat = EvaluateGuess(guess, diceRoll);
        } while(repeat);
    }

    private bool EvaluateGuess(int guess, int correct)
    {
        string incorrectMessage = "Wrong Number.";

        if(guess == correct)
        {
            Console.WriteLine("You win");
            return false;

        } else if( !(tries > TriesCount) ) 
        {
            Console.WriteLine(incorrectMessage);
            return true;
        } else
        {
            Console.WriteLine(incorrectMessage);
            Console.WriteLine("You lose.");
            return false;
        }
    }
}