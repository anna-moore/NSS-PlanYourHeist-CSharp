using System;
using System.Collections.Generic;

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

            Hacker Rio = new Hacker();
            Hacker Tokyo = new Hacker();
            LockSpecialist Nairobi = new LockSpecialist();
            LockSpecialist Berlin = new LockSpecialist();
            Muscle Denver = new Muscle();
            Muscle Oslo = new Muscle();


            List<IRobber> rolodex = new List<IRobber>()
            {
                Rio, Tokyo, Nairobi, Berlin, Denver, Oslo
            };

            Console.WriteLine($"{rolodex.Count} members of the team.");
        }
    }
}
