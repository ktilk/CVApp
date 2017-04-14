using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Characteristic
    {
        public int CharacteristicId { get; set; }
        public string CharacteristicName { get; set; }
        public List<PersonCharacteristic> PersonCharacteristics { get; set; }
    }
}
