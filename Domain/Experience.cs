using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public string Job { get; set; }
        public string Description { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
