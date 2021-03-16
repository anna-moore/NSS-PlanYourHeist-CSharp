using System;

namespace PlanYourHeist
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.AlarmSound -= 50;
            Console.WriteLine($"{Name}  is hacking the alarm system. Decreased security 50 points ");
            if (bank.AlarmSound <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            };
        }

    }
}