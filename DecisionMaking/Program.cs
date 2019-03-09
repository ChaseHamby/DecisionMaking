using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;

            Console.WriteLine("Enter your score: ");
            string scoreAsText = Console.ReadLine();
            score = Convert.ToInt32(scoreAsText);

            if (score == 100)
                Console.WriteLine("Perfect score! You win!");
            else if (score >= 90)
                Console.WriteLine("You get an A");
            else if (score >= 80)
                Console.WriteLine("You got a B");
            else if (score >= 70)
                Console.WriteLine("You got a C");
            else if (score >= 65)
                Console.WriteLine("You got a D");
            else
                Console.WriteLine("You got an F");

            Console.ReadKey();
        }
    }
}
