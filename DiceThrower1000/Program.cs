using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaring parameters here
            ThrowDice("10d6");
            ThrowDice("3d20");
            ThrowDice("100d6");

            Console.ReadKey();

        }
        static void ThrowDice(string diceString)
        {
            var rolls = "10d6";
            // spliting 10d6 to bring out the two numbers
            String[] splitarray = rolls.Split('d');

            // converting number of rolls into an index of 0
            int numRolls = Convert.ToInt32(splitarray[0]);
            // converting number of rolls into an index of 1
            int numSides = Convert.ToInt32(splitarray[1]);

            //printing out the number of rolls
            Console.WriteLine("Throwing: " + diceString);
            Console.WriteLine("Results: ");

            var Random = new Random();
            for (var i = 0; i <= diceString.Length; i++)
            {
                var theRoll = Random.Next(1, numSides + 1);
                //printing out what the roll is and adding a space in between each new roll
                Console.Write(theRoll + " ");
            }


        }
       
    }
}
