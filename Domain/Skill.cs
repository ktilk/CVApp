using System;

namespace Domain
{
    public class Skill
    {
        public int SkillId { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public string SkillName { get; set; }
        public string SkillDescription { get; set; }
    }
}
