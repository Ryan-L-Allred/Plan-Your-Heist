using System;
using System.Collections.Generic;
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

            List<Member> memberList = new List<Member>();
            Console.WriteLine("Enter difficulty level: ");
            string diffInput = Console.ReadLine();
            int diffLevel = Int32.Parse(diffInput);
            Console.WriteLine("Enter number of runs: ");
            string trialInput = Console.ReadLine();
            int trialRuns = Int32.Parse(trialInput);
            int skillSum = 0;
            bool stillInputting = true;
            while (stillInputting)
            {
                Console.WriteLine("Enter team member's name:");
                string memberName = Console.ReadLine();
                if (memberName == "")
                {
                    stillInputting = false;
                    break;
                }

                Console.WriteLine("Enter team member's skill level:");
                string answerTwo = Console.ReadLine();
                int result = Int32.Parse(answerTwo);

                Console.WriteLine("Enter team member's courage factor:");
                string answerThree = Console.ReadLine();
                double courageFactor = Double.Parse(answerThree);

                Member ryan = new Member(memberName, result, courageFactor);
                memberList.Add(ryan);

            }

            



            Console.WriteLine("This team is comprised of " + memberList.Count + " people");

            int successRuns = 0;
            int failedRuns = 0;
            for (int i = trialRuns; i > 0; i--) {
                for (int j = 0; j < memberList.Count; j++)
                {
                    skillSum += memberList[j].SkillLevel;
                }

                Console.WriteLine($"Team Skill Level is {skillSum}");

                Random r = new Random();
                int LuckLevel = r.Next(-10, 10);

                int BankDifficulty = LuckLevel + diffLevel;
                Console.WriteLine($"Bank Difficulty Level is {BankDifficulty}");

                if (skillSum >= BankDifficulty)
                {
                    Console.WriteLine("Success");
                    successRuns++;
                }
                else
                {
                    Console.WriteLine("Failure");
                    failedRuns++;
                }
                skillSum = 0;
            }
            Console.WriteLine("After action report: " + successRuns + " successful runs and " + failedRuns + " failed runs" );


        }
    }
}
