using System;

namespace PlanYourHeist
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= 50;
            Console.WriteLine($"{Name} is drilling through the security vault.");
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the security vault.");
            };
        }
    }
}