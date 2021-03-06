﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Telephony.Exceptions;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string webSite)
        {
            if (webSite.Any(x => char.IsDigit(x)))
            {
                throw new InvalidUrlException();
            }
            return $"Browsing: {webSite}!";
        }

        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(ch => char.IsDigit(ch)))
            {
                throw new InvalidPhoneNumException();
            }
            
            return $"Calling... {phoneNumber}";
        }
    }
}
