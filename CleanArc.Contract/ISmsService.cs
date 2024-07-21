using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArc.Contract
{
    public interface ISmsService
    {
        void SendMessage(SmsObject sms);
    }

    public class SmsObject
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
    }
}
