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

            //Create new Heist Team Members
            Hacker Rio = new Hacker();
            Rio.Name = "Rio";
            Rio.SkillLevel = 100;

            Hacker Tokyo = new Hacker();
            Tokyo.Name = "Tokyo";
            Tokyo.SkillLevel = 100;

            LockSpecialist Nairobi = new LockSpecialist();
            Nairobi.Name = "Nairobi";
            Nairobi.SkillLevel = 100;

            LockSpecialist Berlin = new LockSpecialist();
            Berlin.Name = "Berlin";
            Berlin.SkillLevel = 100;

            Muscle Denver = new Muscle();
            Denver.Name = "Denver";
            Denver.SkillLevel = 100;

            Muscle Oslo = new Muscle();
            Oslo.Name = "Oslo";
            Oslo.SkillLevel = 100;


            List<IRobber> rolodex = new List<IRobber>()
            {
                Rio, Tokyo, Nairobi, Berlin, Denver, Oslo
            };


            // Things start here theres a user input called 'value'
            List<int> options = new List<int>()
                {
                    1,
                    2,
                    3
                };

            {
                //what is this number suppose to be?
                string value = Console.ReadLine();
                bool success = Int32.TryParse(value, out int result);

                while (!success && !options.Contains(result))
                {
                    Console.WriteLine($"{value} is an invalid option. Please enter a number: _");
                    string userInputRedux = Console.ReadLine();
                    success = Int32.TryParse(userInputRedux, out result);
                }

                // things end here





                while (true)
                {
                    Console.WriteLine($"{rolodex.Count} members of the team.");
                    Console.WriteLine("");
                    Console.Write("Would you like to add a new person? (hit enter for no)");
                    string answer = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(answer))
                    {
                        break;
                    }
                    Console.Write("Enter the Name of Possible New Member of the crew: ");
                    string NameOfPossibleNewMember = Console.ReadLine();
                    Console.WriteLine($"What specialty does {NameOfPossibleNewMember} have?");
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("  1. Hacker (Disabled Alarms)        ");
                    Console.WriteLine("  2. Muscle (Disarms Guards)         ");
                    Console.WriteLine("  3. Lock Specialists (Cracks Vault) ");
                    Console.WriteLine("-------------------------------------");
                    Console.Write("Enter the number: ");
                    int specialty = Int32.Parse(Console.ReadLine());
                    Console.Write($"What skill level does {NameOfPossibleNewMember} have? (1-100): ");
                    int skill = Int32.Parse(Console.ReadLine());
                    Console.Write($"What percentage of the cut does {NameOfPossibleNewMember} want? (1-100): ");
                    int cut = Int32.Parse(Console.ReadLine());

                    //check the speciality interger 
                    switch (specialty)
                    {
                        case 1:
                            rolodex.Add(new Hacker()
                            {
                                Name = NameOfPossibleNewMember,
                                SkillLevel = skill,
                                PercentageCut = cut
                            });
                            break;

                        case 2:
                            rolodex.Add(new Muscle()
                            {
                                Name = NameOfPossibleNewMember,
                                SkillLevel = skill,
                                PercentageCut = cut
                            });
                            break;

                        case 3:
                            rolodex.Add(new LockSpecialist()
                            {
                                Name = NameOfPossibleNewMember,
                                SkillLevel = skill,
                                PercentageCut = cut
                            });
                            break;
                    }

                    //create a new bank with the min and max preset 
                    Bank newBank = new Bank()
                    {
                        AlarmSound = new Random().Next(0, 100),
                        VaultScore = new Random().Next(0, 100),
                        SecurityGuardScore = new Random().Next(0, 100),
                        CashOnHand = new Random().Next(50000, 1000000),
                    };

                }

            }
        }
    }
}


