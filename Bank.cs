using System;

namespace PlanYourHeist
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmSound { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }

        public bool IsSecure
        {
            get
            {
                if (CashOnHand <= 0 && AlarmSound <= 0 && VaultScore <= 0 && SecurityGuardScore <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}