using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Domain.ValueObjects
{
    public class Phone : BaseValueObject<Phone>
    {
        public string Phonenumber { get; }
        public Phone(string phonenumber) 
        { 
            Phonenumber = phonenumber;
        }
    }
}
