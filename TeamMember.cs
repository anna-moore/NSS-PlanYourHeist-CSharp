using System;
//update to limit the min and max
namespace PlanYourHeist
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }

        public static string UserName()
        {
            Console.Write("Enter your name: ");
            string newMember = Console.ReadLine();

            return newMember;
        }

        //use static because calling a method in the team member class without a team member existing yet ch20
        //add if and else statements to ensure that user input means requirements
        public static int UserSkillLevel()
        {
            int skill = 0;
            Console.Write("Enter a positive interger for your skill level: ");
            skill = Int32.Parse(Console.ReadLine());
            while (skill < 0)
            {
                Console.Write("Try again with a positive number: ");
                skill = Int32.Parse(Console.ReadLine());
            }

            return skill;
        }

        public static decimal UserCourageFactor()
        {
            decimal courage = -1.0m;
            while (courage < 0.0m || courage > 2.0m)
            {
                Console.Write("Enter a number 0.0 - 2.0 for your courage level: ");

                try
                {
                    courage = decimal.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please make sure the courage factor is between 0.0 and 2.0");
                }
            }

            return courage;
        }

        public void DisplayMemberInfo()
        {

            Console.WriteLine($"{Name} is the new team member");
            Console.WriteLine($"This is user's skill level {SkillLevel}");
            Console.WriteLine($"This is user courage level {CourageFactor}");

        }

    }
}