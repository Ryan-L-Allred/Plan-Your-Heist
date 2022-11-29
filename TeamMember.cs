using System;

namespace PlanYourHeist
{


    public class Member
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public double CourageFactor { get; set; }

        public Member(string Name, int SkillLevel, double CourageFactor)
        {
            this.Name = Name;
            this.SkillLevel = SkillLevel;
            this.CourageFactor = CourageFactor;
        }
    }
}