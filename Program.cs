namespace SelectionStatementExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you favorite school subject?");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();


            bool validInput = false;
            switch(userInput)
            { 
                case "math":
                validInput = true;
                break;

                case "science":
                validInput = true;
                break;

                case "social studies":
                validInput = true;
                break;

                case "history":
                validInput = true;
                break;

                case "biology":
                validInput = true;
                break;
            
            }

            string message = validInput ? $"I think {userInput} is my favorite, too!" : "Yeah, that's not my favorite subject.";
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}