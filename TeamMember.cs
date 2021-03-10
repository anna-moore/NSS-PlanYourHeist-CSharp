using System;

namespace PlanYourHeist
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }

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
            Console.Write("Enter a positive interger for your skill level: ");
            int skill = Int32.Parse(Console.ReadLine());
            while (skill > 0)
            {
                Console.Write("Try again with a positive number: ");
                skill = Int32.Parse(Console.ReadLine());
            }

            return skill;
        }

        public static double UserCourageFactor()
        {
            Console.Write("Enter a number 0.0 - 2.0 for your courage level: ");
            double courage = Double.Parse(Console.ReadLine());

            return courage;
        }

        public void DisplayMemberInfo()
        {

            Console.WriteLine(Name);
            Console.WriteLine($"This is user's skill level {SkillLevel}");
            Console.WriteLine($"This is user courage level {CourageFactor}");

        }

    }
}