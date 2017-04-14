using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int ContactTypeId { get; set; }
        public ContactType ContactType { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public string ContactValue { get; set; }
    }
}
