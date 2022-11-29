using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print message "Plan Your Heist!"

            Console.WriteLine("Plan You Heist!");
            /*
               Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. 
               The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
            */

            //Prompt the user to enter a team member's name and save that name.   
            Console.WriteLine("Enter team member's name:");
            string memberName = Console.ReadLine();

            Console.WriteLine("Enter team member's skill level:");
            string answerTwo = Console.ReadLine();
            int result = Int32.Parse(answerTwo);
            
            Console.WriteLine("Enter team member's courage factor:");
            string answerThree = Console.ReadLine();
            double courageFactor = Double.Parse(answerThree);

            Member ryan = new Member(memberName, result, courageFactor);

        
            Console.WriteLine(ryan.Name);
            Console.WriteLine(ryan.SkillLevel);
            Console.WriteLine(ryan.CourageFactor);

        }
    }
}
