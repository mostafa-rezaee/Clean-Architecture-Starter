using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.ValueObjects
{
    public class Phonebook : BaseValueObject<Phonebook>
    {
        public Phone Telephone { get; }
        public Phone Mobilephone { get; }
        public Phone Fax { get; }

    }
}
