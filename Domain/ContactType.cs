using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ContactType
    {
        public int ContactTypeId { get; set; }
        public string ContactTypeName { get; set; }
        public List<Contact> Contacts { get; set; } = new List<Contact>();
        public List<Person> Persons { get; set; } = new List<Person>();
    }
}
