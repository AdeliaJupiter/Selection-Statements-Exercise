namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //------------------------FAVORITE NUMBER-----------------------
            //declare and initialize variables
            var r = new Random();
            var favNumber = r.Next(1, 100);

            //Get the user's guess
            Console.WriteLine($"What is my favorite number between 1-100?");
            var userInput = int.Parse(Console.ReadLine());

            //test user's guess against favorite number
            if (userInput < favNumber)
            {
                Console.WriteLine($"too low :(");
                Console.WriteLine($"The number was {favNumber}.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"too high :(");
                Console.WriteLine($"The number was {favNumber}.");
            }
            else
            {
                Console.WriteLine($"You guessed it!!!");
            }

            //-----------------------FAVORITE SCHOOL SUBJECT-----------------------
            //declare and initialize variables
            Console.WriteLine($"What is your favorite school subject?");
            var favSubject = Console.ReadLine();

            favSubject = favSubject.ToLower();

            switch ( favSubject )
            {
                case "math":
                    Console.WriteLine($"I like math too!");
                    break;
                case "english":
                    Console.WriteLine($"That was my favorite subject!");
                    break;
                case "history":
                    Console.WriteLine($"I'm glad someone finds it interesting!");
                    break;
                case "science":
                    Console.WriteLine($"There are so many kinds of sciences!");
                    break;
                case "lunch":
                    Console.WriteLine($"A wonderful time to learn social skills and self care!");
                    break;
                default:
                    Console.WriteLine($"Ah, I haven't taken that one before");
                    break;
            }
        }
    }
}
