// See https://aka.ms/new-console-template for more information

// Generate random number to use as secret number
Random randInt = new Random();
int secretNumber = randInt.Next(1, 11);
// Variable to hold user guess integer
int userGuess = 0;
// Control variables for while loop
int guessCount = 0;
int guessLimit = 3;

// While user guess is wrong and tries are less than limit, run.
while(userGuess != secretNumber && guessCount < guessLimit) {
    Console.Write("I am a number between 1 and 10. Guess which: ");
    try {
        userGuess = Convert.ToInt32(Console.ReadLine());
    } catch(Exception e) {
        Console.Write(e.Message + "\n");
    }

    // 
    guessCount++;
}

// Check if user won or ran out of tries
if(userGuess == secretNumber) {
    Console.WriteLine("Congrats! You Got It!");
} else {
    Console.WriteLine($"Better luck nes'time, chomp. Secret number was {secretNumber}");
}