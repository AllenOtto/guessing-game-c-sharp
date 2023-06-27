// See https://aka.ms/new-console-template for more information

Random randInt = new Random();
int secretNumber = randInt.Next(1, 11);
int userGuess = 0;
int guessCount = 0;
int guessLimit = 3;

while(userGuess != secretNumber && guessCount < guessLimit) {
    Console.Write("I am a number between 1 and 10. Guess which: ");
    try {
        userGuess = Convert.ToInt32(Console.ReadLine());
    } catch(Exception e) {
        Console.Write(e.Message);
    }
    Console.Write(secretNumber + "\n");

    guessCount++;
}

if(userGuess == secretNumber) {
    Console.WriteLine("Very nice! You Win");
} else {
    Console.WriteLine("Better luck nes'time, chomp");
}