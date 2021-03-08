using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your Heist!");

            TeamMember newUser = new TeamMember()
            {
                Name = TeamMember.UserName(),
                SkillLevel = TeamMember.UserSkillLevel(),
                CourageFactor = TeamMember.UserCourageFactor(),
            };

            newUser.DisplayMemberInfo();

        }
    }
}
