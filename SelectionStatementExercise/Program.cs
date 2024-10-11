namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var favoriteNumber = 555;

            Console.WriteLine("I'm thinking of a number between 1 and 1000.");

            var userInput = int.Parse(Console.ReadLine());

            if(userInput < favoriteNumber){
                Console.WriteLine("Too Low!");
            } else if(userInput > favoriteNumber){
                Console.WriteLine("Too High!");
            } else {
                Console.WriteLine("Never mind.");
            }
        }
    }
}
