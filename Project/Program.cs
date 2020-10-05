using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string xCordString = "";
            int xCordInt = 0;
            int max = 10; //Maximum number accepted
            int min = 1; //Minimum number accepted
            int answer = 7; //Answer Must be within range
            float nearRange = -1; //How close it needs to be to be a near hit, Set to -# to make 10%
            int shots = 4;

            System.Console.WriteLine("Välkommen till Sänka Skepp");
            if(nearRange < 0){
                nearRange = max/10;
                }
            if(answer > max  || answer < min)
            {
                System.Console.WriteLine("Sorry the answer used is not within Range");
                Console.ReadLine();
                xCordInt = answer;
            }
    
            while(xCordInt != answer && shots != 0){ //Main Loop
                System.Console.WriteLine("Skriv in en kordinat[" + min + "-" + max + "]");
                xCordString = Console.ReadLine();
                try //If answer is a Number
                {
                xCordInt = Int32.Parse(xCordString);

                if(xCordInt == answer) //If answer is correct
                {
                    System.Console.WriteLine("Hit!");
                    shots-=1;
                    System.Console.WriteLine("You finished with " + shots + " shots left");
                    System.Console.WriteLine("Press ENTER to exit Program");
                    Console.ReadLine();
                }
                else if(xCordInt <= answer+nearRange && xCordInt >= answer-nearRange) //If answer is Close
                {
                    shots-=1;
                    Console.Clear();
                    System.Console.WriteLine(xCordInt + " is a near miss");
                    System.Console.WriteLine("You have " + shots + " shots left");
                    xCordString = "";
                    System.Console.WriteLine("");
                }
                else if(xCordInt <= max && xCordInt >= min) //If answer is withing Range
                {
                    shots-=1;
                    Console.Clear();
                    System.Console.WriteLine(xCordInt + " is a miss");
                    System.Console.WriteLine("You have " + shots + " shots left");
                    xCordString = "";
                    System.Console.WriteLine("");
                }
                else if(xCordInt < min) //If answer is to small
                {
                    Console.Clear();
                    System.Console.WriteLine(xCordInt + " is to small");
                    xCordString = "";
                    System.Console.WriteLine("");
                }
                else if(xCordInt > max) //If answer is to big
                {
                    Console.Clear();
                    System.Console.WriteLine(xCordInt + " is to big");
                    xCordString = "";
                    System.Console.WriteLine("");
                }
                }
                catch //If answer is not a number
                {
                    System.Console.WriteLine("Sorry that is not a Number");
                    System.Console.WriteLine("Press ENTER to try again");
                    xCordString = "";
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            if(shots==0 && xCordInt != answer){
                System.Console.WriteLine("Sorry you have no shots left");
                System.Console.WriteLine("Press ENTER to exit Program");
                Console.ReadLine();
            }
        }
    }
}
