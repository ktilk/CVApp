using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class PersonCharacteristic
    {
        public int PersonCharacteristicId { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int CharacteristicId { get; set; }
        public Characteristic Characteristic { get; set; }
    }
}
