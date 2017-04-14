using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public List<Language> Languages { get; set; } = new List<Language>();
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Characteristic> Characteristics { get; set; } = new List<Characteristic>();
        public List<Experience> WorkExperiences { get; set; } = new List<Experience>();
        public string AdditionalInformation { get; set; }
        
    }
}
