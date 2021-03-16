using System;

namespace PlanYourHeist
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= 50;
            Console.WriteLine($"{Name} is overpowering the Security Guards.");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} had disabled all the security systems.");
            };
        }
    }
}