namespace SyntaxAndSyntaxSugarExercise
{



    public class Program
    {
        private static bool nine;

        static void Main(string[] args)
        {

            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than 9" : $"{answer} is greater than nine";


            Console.Write(response);



        }

    }

}